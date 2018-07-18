namespace ZigZag.Admin
{
    partial class PcSelectionCtrl
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
            this.pnlpcs = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // pnlpcs
            // 
            this.pnlpcs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlpcs.Location = new System.Drawing.Point(0, 0);
            this.pnlpcs.Name = "pnlpcs";
            this.pnlpcs.Size = new System.Drawing.Size(943, 514);
            this.pnlpcs.TabIndex = 0;
            // 
            // PcSelectionCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlpcs);
            this.Name = "PcSelectionCtrl";
            this.Size = new System.Drawing.Size(943, 514);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlpcs;
    }
}
