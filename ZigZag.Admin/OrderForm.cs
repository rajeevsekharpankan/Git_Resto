using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resto.Manager;
using Resto.Models;
namespace ZigZag.Admin
{
    public partial class OrderForm : Form
    {
        billManager manager = new billManager();
        public OrderForm()
        {
            InitializeComponent();
        }
        public void FillBillDetails(billmasterModel bill)
        {
            List<billdetails> details = manager.GetFinalBillDetails(bill.billno);
            pnlbills.Controls.Clear();
            SellItemCtrl product = null;
            ItemModel itemmodel = null;
            this.Text = "[ Bill No : " + bill.billno.ToString() + Environment.NewLine + " ]     [ Bill Date: " + bill.billdate.ToShortDateString() + " ]]     [Bill Amount: " + string.Format("{0:0.00}", bill.amount) + " ]";
            //string imagepath = ConfigurationManager.AppSettings["imagepath"].ToString();
            foreach (billdetails item in details)
            {
                itemmodel = new ItemModel();
                itemmodel.itemname = item.itemname;
                itemmodel.price = item.amount;
                itemmodel.qty = item.qty;
                itemmodel.imagepath = item.imagepath;

                product = new SellItemCtrl(itemmodel);
                product.lblqty.Text = item.qty.ToString();
                product.txtqty.Visible = false;
                product.lblqty.Visible = true;
                product.btnaddtocart.Visible = false;
                product.btndelete.Visible = false;
                product.lblprice.Visible = true;
                pnlbills.Controls.Add(product);
            }
        }
    }
}
