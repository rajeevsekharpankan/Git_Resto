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

namespace ZigZag.Admin
{
    public partial class billCtrl : CommonCtrl
    {
        public Boolean ismanagement { get; set; }
        public billCtrl()
        {
            InitializeComponent();
        }

        private void tmrcolor_Tick(object sender, EventArgs e)
        {
            //try
            //{
            //    if (panel1.BackColor == Color.Red)
            //    {
            //        panel1.BackColor = Color.FromArgb(182, 172, 0);
            //    }
            //    else
            //    {
            //        panel1.BackColor = Color.Red;
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        private void billCtrl_Load(object sender, EventArgs e)
        {

        }
        OrderForm orderform = null;
        private void btnview_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ismanagement)
                {
                    this.parentform.orderCtrl1.FillDetails((billmasterModel)this.Tag);
                    this.parentform.orderCtrl1.parentform = this.parentform;
                    this.parentform.orderCtrl1.BringToFront();
                }
                else
                {
                    if (orderform == null) orderform = new OrderForm();
                    orderform.FillBillDetails((billmasterModel)this.Tag);
                    orderform.ShowDialog();
                }

            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString() + Environment.NewLine + ex.StackTrace.ToString());
            }
        }
    }
}
