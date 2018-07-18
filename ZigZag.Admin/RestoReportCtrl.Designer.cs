namespace ZigZag.Admin
{
    partial class RestoReportCtrl
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnsales = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnpurchase = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnsales);
            this.flowLayoutPanel1.Controls.Add(this.btnpurchase);
            this.flowLayoutPanel1.Controls.Add(this.bunifuTileButton1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(948, 488);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnsales
            // 
            this.btnsales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnsales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsales.color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnsales.colorActive = System.Drawing.Color.Gold;
            this.btnsales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsales.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnsales.ForeColor = System.Drawing.Color.White;
            this.btnsales.Image = global::ZigZag.Admin.Properties.Resources.reporticon;
            this.btnsales.ImagePosition = 20;
            this.btnsales.ImageZoom = 50;
            this.btnsales.LabelPosition = 41;
            this.btnsales.LabelText = "Sales";
            this.btnsales.Location = new System.Drawing.Point(6, 6);
            this.btnsales.Margin = new System.Windows.Forms.Padding(6);
            this.btnsales.Name = "btnsales";
            this.btnsales.Size = new System.Drawing.Size(128, 129);
            this.btnsales.TabIndex = 0;
            this.btnsales.Click += new System.EventHandler(this.btnsales_Click);
            // 
            // btnpurchase
            // 
            this.btnpurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnpurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpurchase.color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnpurchase.colorActive = System.Drawing.Color.Gold;
            this.btnpurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpurchase.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnpurchase.ForeColor = System.Drawing.Color.White;
            this.btnpurchase.Image = global::ZigZag.Admin.Properties.Resources.reporticon;
            this.btnpurchase.ImagePosition = 20;
            this.btnpurchase.ImageZoom = 50;
            this.btnpurchase.LabelPosition = 41;
            this.btnpurchase.LabelText = "Purchase";
            this.btnpurchase.Location = new System.Drawing.Point(146, 6);
            this.btnpurchase.Margin = new System.Windows.Forms.Padding(6);
            this.btnpurchase.Name = "btnpurchase";
            this.btnpurchase.Size = new System.Drawing.Size(128, 129);
            this.btnpurchase.TabIndex = 0;
            this.btnpurchase.Visible = false;
            this.btnpurchase.Click += new System.EventHandler(this.btnpurchase_Click);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.bunifuTileButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTileButton1.color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.bunifuTileButton1.colorActive = System.Drawing.Color.Gold;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = global::ZigZag.Admin.Properties.Resources.reporticon;
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "Purchase";
            this.bunifuTileButton1.Location = new System.Drawing.Point(286, 6);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(128, 129);
            this.bunifuTileButton1.TabIndex = 0;
            this.bunifuTileButton1.Visible = false;
            this.bunifuTileButton1.Click += new System.EventHandler(this.btnpurchase_Click);
            // 
            // RestoReportCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "RestoReportCtrl";
            this.Size = new System.Drawing.Size(948, 488);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton btnsales;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuTileButton btnpurchase;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
    }
}