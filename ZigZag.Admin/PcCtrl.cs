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
    public partial class PcCtrl : CommonCtrl
    {
        public PcListCtrl.EditPcsCtrl EditPcCallback;
        public Boolean isInOrder { get; set; }
        public PcCtrl()
        {
            InitializeComponent();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                EditPcCallback((PcModel)this.Tag);
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString());
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString());
            }
        }

        private void pnlparent_Click(object sender, EventArgs e)
        {

        }
        public PcBillingCtrl pcBillingCtrl1 { get; set; }
        private void PcCtrl_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString());
            }
        }

        private void imgitem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.isInOrder)
                {
                    if (pcBillingCtrl1 == null) pcBillingCtrl1 = new PcBillingCtrl();
                    pcBillingCtrl1.FillCatagories();
                    pcBillingCtrl1.parentform = this.parentform;
                    pcBillingCtrl1.Dock = DockStyle.Fill;
                    this.parentform.splitContainer1.Panel2.Controls.Add(pcBillingCtrl1);
                    pcBillingCtrl1.BringToFront();
                    pcBillingCtrl1.AddItemCallbackFn(pcBillingCtrl1.catagories.Count > 0 ? pcBillingCtrl1.catagories.FirstOrDefault() : new CategoryModel() { Id = 0 });
                }
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString());
            }
        }
    }
}
