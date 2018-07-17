namespace ZigZag.Admin
{
    partial class BillManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlpcs = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpfrom = new System.Windows.Forms.DateTimePicker();
            this.dtpto = new System.Windows.Forms.DateTimePicker();
            this.btnfind = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnfind);
            this.panel1.Controls.Add(this.dtpto);
            this.panel1.Controls.Add(this.dtpfrom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ddlpcs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 102);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 410;
            this.label1.Text = "PCs";
            // 
            // ddlpcs
            // 
            this.ddlpcs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlpcs.FormattingEnabled = true;
            this.ddlpcs.ItemHeight = 23;
            this.ddlpcs.Location = new System.Drawing.Point(12, 36);
            this.ddlpcs.Name = "ddlpcs";
            this.ddlpcs.Size = new System.Drawing.Size(310, 29);
            this.ddlpcs.TabIndex = 409;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(368, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 410;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(543, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 410;
            this.label3.Text = "To";
            // 
            // dtpfrom
            // 
            this.dtpfrom.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfrom.Location = new System.Drawing.Point(328, 37);
            this.dtpfrom.Name = "dtpfrom";
            this.dtpfrom.Size = new System.Drawing.Size(128, 26);
            this.dtpfrom.TabIndex = 411;
            // 
            // dtpto
            // 
            this.dtpto.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpto.Location = new System.Drawing.Point(471, 37);
            this.dtpto.Name = "dtpto";
            this.dtpto.Size = new System.Drawing.Size(128, 26);
            this.dtpto.TabIndex = 411;
            // 
            // btnfind
            // 
            this.btnfind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnfind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnfind.color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnfind.colorActive = System.Drawing.Color.Gold;
            this.btnfind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfind.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnfind.ForeColor = System.Drawing.Color.White;
            this.btnfind.Image = global::ZigZag.Admin.Properties.Resources.reporticon;
            this.btnfind.ImagePosition = 20;
            this.btnfind.ImageZoom = 50;
            this.btnfind.LabelPosition = 35;
            this.btnfind.LabelText = "Find";
            this.btnfind.Location = new System.Drawing.Point(608, 23);
            this.btnfind.Margin = new System.Windows.Forms.Padding(6);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(128, 42);
            this.btnfind.TabIndex = 412;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // BillManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "BillManagement";
            this.Size = new System.Drawing.Size(997, 508);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox ddlpcs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.DateTimePicker dtpto;
        internal System.Windows.Forms.DateTimePicker dtpfrom;
        private Bunifu.Framework.UI.BunifuTileButton btnfind;
    }
}
