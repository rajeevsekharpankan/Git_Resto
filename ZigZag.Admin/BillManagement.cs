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
namespace ZigZag.Admin
{
    public partial class BillManagement : CommonCtrl
    {
        billManager manager = new billManager();

        public BillManagement()
        {
            InitializeComponent();
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            try
            {
                List<billmasterModel> bills = manager.SelectFinalBillsWithPc();
                bills.InsertRange(bills.Count - 1, manager.SelectFinalBillsWitoutPc());
                bills = bills.OrderByDescending(x => x.billno).ToList();
                billCtrl bill = null;
                pnlbills.Controls.Clear();
                foreach (billmasterModel item in bills)
                {
                    bill = new billCtrl();
                    bill.lblname.Text = item.billno.ToString();
                    bill.lblamount.Text = string.Format("{0:0.00}", item.amount);
                    bill.ismanagement = true;
                    bill.lbldate.Text = item.billdate.ToShortDateString();
                    bill.lbldatecaption.Visible = true;
                    bill.lbldate.Visible = true;
                    bill.Tag = item;
                    pnlbills.Controls.Add(bill);
                }
                //bills = manager.SelectFinalBillsWitoutPc();
                //foreach (billmasterModel item in bills)
                //{
                //    bill = new billCtrl();
                //    bill.lblname.Text = item.billno.ToString();
                //    bill.lblamount.Text = string.Format("{0:0.00}", item.amount);
                //    bill.lbldate.Text = item.billdate.ToShortDateString();
                //    bill.lbldatecaption.Visible = true;
                //    bill.lbldate.Visible = true;
                //    bill.ismanagement = true;
                //    bill.Tag = item;
                //    pnlbills.Controls.Add(bill);
                //}
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString() + Environment.NewLine + ex.StackTrace.ToString());
            }
        }
    }
}
