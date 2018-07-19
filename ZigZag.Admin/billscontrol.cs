using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resto.Models;
using Resto.Manager;
using System.Configuration;

namespace ZigZag.Admin
{
    public partial class billscontrol : UserControl
    {
        public delegate Boolean AddOrderItemDelegate(SellItemCtrl item);
        public delegate void DeleteOrderItemDelegate(SellItemCtrl item);
        public delegate void UpdateAmountDelegate();
        billManager manager = new billManager();
        public List<Product> products = new List<Product>();
        Boolean fmload = false;
        public Boolean isloaded = false;
        PcCtrl pcCtrl1 = null;
        public billscontrol()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            try
            {
                SellItemCtrl item = e.Control as SellItemCtrl;
                item.DeleteItemCallback = new DeleteOrderItemDelegate(this.DeleteCallBackfn);
                item.UpdateAmountCallback = new UpdateAmountDelegate(UpdateAmount);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        public Boolean AddItemCallbackFn(SellItemCtrl orderitem)
        {
            Boolean returndata = false;
            orderitem.btndelete.Visible = true;
            orderitem.btnaddtocart.Visible = false;

            Form1 form1 = (Form1)this.ParentForm;


            int itemcount = pnlbill.Controls.Find(orderitem.product.controlname, false).Count();
            if (itemcount >= 1)
            {

                decimal qty = orderitem.txtqty.Value;
                //if (itemcount >= 1)
                //{
                //   // pnlbill.Controls.Remove(pnlbill.Controls.Find(orderitem.product.controlname, false)[1]);
                //    orderitem = pnlbill.Controls.Find(orderitem.product.controlname, false).SingleOrDefault() as item;
                //    orderitem.txtqty.Value = p.qty;
                //}
                SellItemCtrl billitem = pnlbill.Controls.Find(orderitem.product.controlname, false).FirstOrDefault() as SellItemCtrl;
                billitem.txtqty.Value += qty;
                billitem.lblqty.Text = (int.Parse(billitem.lblqty.Text) + qty).ToString();
                orderitem.Tag = orderitem.product;
                returndata = true;
            }
            else
            {
                //form1.products.Add(orderitem.product);
                orderitem.Tag = orderitem.product;
                pnlbill.Controls.Add(orderitem);
                returndata = true;
            }
            UpdateAmount();
            return returndata;
        }

        public void DeleteCallBackfn(SellItemCtrl orderitem)
        {
            this.pnlbill.Controls.Remove(orderitem);
            UpdateAmount();
        }
        public void UpdateAmount()
        {
            Form1 form = (Form1)this.ParentForm;
            double amount = 0;
            lblamount.Text = "0.00";

            foreach (Control ctrl in pnlbill.Controls)
            {
                SellItemCtrl prod = (SellItemCtrl)ctrl;
                amount = amount + ((int.Parse(prod.txtqty.Value.ToString())) * (prod.product.price));
            }
            lblamount.Text = string.Format("{0:0.00}", amount);


        }



        private void btnbillsubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateControls()) return;
            try
            {
                if (!(double.Parse(lblamount.Text) > 0))
                {
                    Utilities.ShowInfo("Please select valid items!");
                    return;
                }
                List<billdetails> billdetails = new List<billdetails>();
                billmasterModel billmaster = new billmasterModel();
                foreach (Control item in pnlbill.Controls)
                {
                    ItemModel model = (ItemModel)item.Tag;
                    SellItemCtrl billitem = (SellItemCtrl)item;
                    billdetails details = new billdetails();
                    details.item = new ItemModel();
                    details.item = model;
                    details.itemid = model.id;
                    details.qty = int.Parse(billitem.txtqty.Value.ToString());
                    details.amount = model.price;
                    details.total = (model.price * int.Parse(billitem.txtqty.Value.ToString()));
                    billmaster.amount = billmaster.amount + (model.price * int.Parse(billitem.txtqty.Value.ToString()));
                    billdetails.Add(details);
                }
                billmaster.userid = Utilities.pcname = "cash";
                billmaster.ispaid = true;
                billmaster.isserved = true;
                billmaster.machinename = Environment.MachineName;
                billmaster.billdate = DateTime.Now;
                billmaster.customerid = 1;
                billmaster.customername = pcCtrl1.lblname.Text;
                billmaster.billdetails = billdetails;

                Utilities.currentpc = (PcModel)pcCtrl1.Tag;
                billmaster.pcid = Utilities.currentpc.id;
                string returndata = manager.InsertFinalBill(billmaster);
                // lblbillno.Text = returndata;
                if (returndata != "0") Cleartexts();
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString());
            }
        }
        public void FillPc(PcCtrl pc)
        {
            pcCtrl1 = pc;
            pcCtrl1.Dock = DockStyle.Fill;
            pnlselected.Controls.Clear();
            pnlselected.Controls.Add(pcCtrl1);
        }

        private void Cleartexts()
        {
            pnlbill.Controls.Clear();
            pnlselected.Controls.Clear();
            pnlselected.Controls.Add(new PcCtrl());
            UpdateAmount();
        }
        private Boolean ValidateControls()
        {
            Boolean returndata = true;
            if (pcCtrl1 == null)
            {
                Utilities.ShowInfo("Please select a Pc from the list");
                returndata = false;
            }
            return returndata;
        }
        PcManager pcmanager = new PcManager();
        CustomerManager cmanager = new CustomerManager();


        billManager billmanager = new billManager();

        private void billscontrol_Load(object sender, EventArgs e)
        {
            try
            {
                this.pnlselected.Controls.Add(new PcCtrl());
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString());
            }
        }
    }
}
