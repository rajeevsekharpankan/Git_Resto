namespace ZigZag.Admin
{
    partial class PcCtrl
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
            this.pnlparent = new System.Windows.Forms.Panel();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.imgitem = new System.Windows.Forms.PictureBox();
            this.pnlparent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgitem)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlparent
            // 
            this.pnlparent.BackColor = System.Drawing.Color.White;
            this.pnlparent.Controls.Add(this.btndelete);
            this.pnlparent.Controls.Add(this.btnedit);
            this.pnlparent.Controls.Add(this.imgitem);
            this.pnlparent.Controls.Add(this.lblname);
            this.pnlparent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlparent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.pnlparent.Location = new System.Drawing.Point(0, 0);
            this.pnlparent.Name = "pnlparent";
            this.pnlparent.Size = new System.Drawing.Size(102, 131);
            this.pnlparent.TabIndex = 5;
            this.pnlparent.Click += new System.EventHandler(this.pnlparent_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(45, 101);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(53, 26);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.Color.White;
            this.btnedit.Location = new System.Drawing.Point(3, 101);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(43, 26);
            this.btnedit.TabIndex = 2;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(8, 3);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(64, 16);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Pc name";
            // 
            // imgitem
            // 
            this.imgitem.Image = global::ZigZag.Admin.Properties.Resources.pc;
            this.imgitem.Location = new System.Drawing.Point(4, 26);
            this.imgitem.Name = "imgitem";
            this.imgitem.Size = new System.Drawing.Size(94, 71);
            this.imgitem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgitem.TabIndex = 1;
            this.imgitem.TabStop = false;
            this.imgitem.Click += new System.EventHandler(this.imgitem_Click);
            // 
            // PcCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlparent);
            this.Name = "PcCtrl";
            this.Size = new System.Drawing.Size(102, 131);
            this.Click += new System.EventHandler(this.PcCtrl_Click);
            this.pnlparent.ResumeLayout(false);
            this.pnlparent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgitem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlparent;
        public System.Windows.Forms.PictureBox imgitem;
        public System.Windows.Forms.Label lblname;
        public System.Windows.Forms.Button btnedit;
        public System.Windows.Forms.Button btndelete;
    }
}
