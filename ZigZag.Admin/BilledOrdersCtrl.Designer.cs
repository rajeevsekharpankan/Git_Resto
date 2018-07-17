namespace ZigZag.Admin
{
    partial class BilledOrdersCtrl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlbills = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // pnlbills
            // 
            this.pnlbills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlbills.Location = new System.Drawing.Point(0, 0);
            this.pnlbills.Name = "pnlbills";
            this.pnlbills.Size = new System.Drawing.Size(814, 475);
            this.pnlbills.TabIndex = 0;
            // 
            // BilledOrdersCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlbills);
            this.Name = "BilledOrdersCtrl";
            this.Size = new System.Drawing.Size(814, 475);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlbills;
    }
}
