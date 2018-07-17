using Resto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZigZag.Admin
{
    public partial class RestoReportCtrl : CommonCtrl
    {
        public RestoReportCtrl()
        {
            InitializeComponent();
        }

        public BillManagement billManagement;
        public PurchaseReportCtrl PurchaseReportCtrl1;

        private void btnsales_Click(object sender, EventArgs e)
        {
            try
            {
                if (billManagement == null) billManagement = new BillManagement();
                this.parentform.splitContainer1.Panel2.Controls.Add(billManagement);
                billManagement.Dock = DockStyle.Fill;
                billManagement.parentform = this.parentform;
                this.billManagement.BringToFront();
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString() + Environment.NewLine + ex.StackTrace.ToString());
            }
        }

        private void btnpurchase_Click(object sender, EventArgs e)
        {
            try
            {
                if (PurchaseReportCtrl1 == null) PurchaseReportCtrl1 = new PurchaseReportCtrl();
                this.parentform.splitContainer1.Panel2.Controls.Add(PurchaseReportCtrl1);
                PurchaseReportCtrl1.Dock = DockStyle.Fill;
                PurchaseReportCtrl1.parentform = this.parentform;
                this.PurchaseReportCtrl1.BringToFront();
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString() + Environment.NewLine + ex.StackTrace.ToString());
            }
        }
    }
}
