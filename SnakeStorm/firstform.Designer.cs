namespace SnakeStorm
{
    partial class firstform
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picfb = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.piclogin = new System.Windows.Forms.PictureBox();
            this.picreg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picreg)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SnakeStorm.Properties.Resources.design_login_menu1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 549);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // picfb
            // 
            this.picfb.Location = new System.Drawing.Point(38, 176);
            this.picfb.Name = "picfb";
            this.picfb.Size = new System.Drawing.Size(152, 43);
            this.picfb.TabIndex = 1;
            this.picfb.TabStop = false;
            this.picfb.Click += new System.EventHandler(this.picfb_Click);
            // 
            // picClose
            // 
            this.picClose.Location = new System.Drawing.Point(341, 13);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(17, 18);
            this.picClose.TabIndex = 2;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // piclogin
            // 
            this.piclogin.Location = new System.Drawing.Point(37, 121);
            this.piclogin.Name = "piclogin";
            this.piclogin.Size = new System.Drawing.Size(152, 43);
            this.piclogin.TabIndex = 3;
            this.piclogin.TabStop = false;
            this.piclogin.Click += new System.EventHandler(this.piclogin_Click);
            // 
            // picreg
            // 
            this.picreg.Location = new System.Drawing.Point(156, 234);
            this.picreg.Name = "picreg";
            this.picreg.Size = new System.Drawing.Size(46, 10);
            this.picreg.TabIndex = 4;
            this.picreg.TabStop = false;
            this.picreg.Click += new System.EventHandler(this.picreg_Click);
            // 
            // firstform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 549);
            this.Controls.Add(this.picreg);
            this.Controls.Add(this.piclogin);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.picfb);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "firstform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "firstform";
            this.Load += new System.EventHandler(this.firstform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picreg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picfb;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox piclogin;
        private System.Windows.Forms.PictureBox picreg;
    }
}