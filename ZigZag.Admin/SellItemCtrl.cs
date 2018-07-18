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
using System.Threading;

namespace ZigZag.Admin
{
    public partial class SellItemCtrl : CommonCtrl
    {
        //public PcBillingCtrl.AddBillItemDelegate AddItemCallback;
        public billscontrol.AddOrderItemDelegate AddOrderItemCallback;
        public billscontrol.DeleteOrderItemDelegate DeleteItemCallback;
        public billscontrol.UpdateAmountDelegate UpdateAmountCallback;
        public item CurrentItem { get; set; }
        public ItemModel product { get; set; }

        public SellItemCtrl()
        {

        }

        public SellItemCtrl(ItemModel product)
        {
            string imagepath = ConfigurationManager.AppSettings["imagepath"].ToString();
            InitializeComponent();
            picitem.ImageLocation = imagepath + product.imagepath;
            lblproductname.Text = product.itemname;
            this.product = product;
            this.product.qty = product.qty > 0 ? product.qty : 1;
            this.txtqty.Value = this.product.qty;
            this.Name = this.product.controlname = "item_" + this.product.itemname + "_" + this.product.id.ToString();
            this.lblprice.Text = string.Format("{0:0.00}", this.product.price);

            this.Tag = product;
        }

        private async void btnaddtocart_Click(object sender, EventArgs e)
        {
            if (!(txtqty.Value > 0))
            {
                Utilities.ShowInfo("Please enter valid quantity!!");
                return;
            }
            ItemModel currentitem = (ItemModel)this.Tag;
            if (currentitem.isstockable)
            {
                if (!CheckQty(currentitem)) return;
            }
            this.product.qty = int.Parse(this.txtqty.Value.ToString());
            SellItemCtrl item = new SellItemCtrl(currentitem);
            lblresponse.Visible = true;
            await Task.Delay(500).ConfigureAwait(AddOrderItemCallback(item));
            AddOrderItemCallback(item);
           // Thread.Sleep(5000);
            this.txtqty.Value = 1;
            lblresponse.Visible = false;
        }
        billManager manager = new billManager();
        int currentstock = 0;
        public Boolean CheckQty(ItemModel item)
        {
            if (item.isstockable)
            {
                currentstock = manager.GetStock(item.id);
                if (currentstock < txtqty.Value)
                {
                    Utilities.ShowInfo("Current stock is :" + currentstock.ToString());
                    txtqty.Value = txtqty.Minimum;
                    /// valuechanged = false;
                    return false;
                }

            }
            return true;
        }

        private void txtqty_ValueChanged(object sender, EventArgs e)
        {
            if (this.Tag == null) return;
            ItemModel item = (ItemModel)this.Tag;
            //if (item.isstockable)
            //{
            //    Utilities.ShowInfo("stockable!!");
            //}

            if (item.isstockable)
            {
                if (!CheckQty(item)) return;
            }

            if (btndelete.Visible)
            {
                Form1 form = (Form1)this.ParentForm;
                UpdateAmountCallback();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                SellItemCtrl deleted = this;
                DeleteItemCallback(deleted);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString() + Environment.NewLine + ex.StackTrace.ToString());
            }
        }
    }
}
