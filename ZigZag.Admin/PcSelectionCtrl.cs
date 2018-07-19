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
    public partial class PcSelectionCtrl : CommonCtrl
    {
        PcManager manager = new PcManager();
      
        public PcSelectionCtrl()
        {
            InitializeComponent();
        }
        public void FillPcs()
        {
            List<PcModel> pcs = manager.GetPcs();
            pnlpcs.Controls.Clear();
            pcs.Add(new PcModel() { id = 0, pcname = "Takeaway" });
            pcs = pcs.OrderBy(x => x.id).ToList();
            PcCtrl pcctrl;
            foreach (PcModel item in pcs)
            {
                pcctrl = new PcCtrl();
                pcctrl.lblname.Text = item.pcname;
                pcctrl.Tag = item;
                if (item.id == 0) pcctrl.imgitem.Image = ZigZag.Admin.Properties.Resources.take2;
                pcctrl.btnedit.Visible = false;
                pcctrl.btndelete.Visible = false;
                pcctrl.isInOrder = true;
                pcctrl.parentform = this.parentform;
                // pcctrl.EditPcCallback = new EditPcsCtrl(EditPcsCtrlCallback);
                pnlpcs.Controls.Add(pcctrl);
            }
        }
    }
}
