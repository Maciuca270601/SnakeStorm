namespace SnakeStorm
{
    partial class LoginFacebook
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.picLoginfb = new System.Windows.Forms.PictureBox();
            this.picfbnoselected = new System.Windows.Forms.PictureBox();
            this.picfbemail = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picfbpass = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginfb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfbnoselected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfbemail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfbpass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Silver;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("BRUSHMOSH! Demo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.Location = new System.Drawing.Point(34, 181);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 29);
            this.textBox2.TabIndex = 21;
            this.textBox2.Text = "Password";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("BRUSHMOSH! Demo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Location = new System.Drawing.Point(34, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 29);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "Email";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // picLoginfb
            // 
            this.picLoginfb.Location = new System.Drawing.Point(16, 228);
            this.picLoginfb.Name = "picLoginfb";
            this.picLoginfb.Size = new System.Drawing.Size(153, 41);
            this.picLoginfb.TabIndex = 29;
            this.picLoginfb.TabStop = false;
            this.picLoginfb.Click += new System.EventHandler(this.picLoginfb_Click);
            // 
            // picfbnoselected
            // 
            this.picfbnoselected.Image = global::SnakeStorm.Properties.Resources.facebook_first1;
            this.picfbnoselected.Location = new System.Drawing.Point(0, 0);
            this.picfbnoselected.Name = "picfbnoselected";
            this.picfbnoselected.Size = new System.Drawing.Size(370, 549);
            this.picfbnoselected.TabIndex = 33;
            this.picfbnoselected.TabStop = false;
            // 
            // picfbemail
            // 
            this.picfbemail.Image = global::SnakeStorm.Properties.Resources.facebook_user;
            this.picfbemail.Location = new System.Drawing.Point(0, 0);
            this.picfbemail.Name = "picfbemail";
            this.picfbemail.Size = new System.Drawing.Size(370, 549);
            this.picfbemail.TabIndex = 32;
            this.picfbemail.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(113, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // picfbpass
            // 
            this.picfbpass.Image = global::SnakeStorm.Properties.Resources.facebook_pass;
            this.picfbpass.Location = new System.Drawing.Point(0, 0);
            this.picfbpass.Name = "picfbpass";
            this.picfbpass.Size = new System.Drawing.Size(370, 549);
            this.picfbpass.TabIndex = 28;
            this.picfbpass.TabStop = false;
            // 
            // picClose
            // 
            this.picClose.Location = new System.Drawing.Point(340, 13);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(18, 18);
            this.picClose.TabIndex = 34;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // LoginFacebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(370, 549);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.picLoginfb);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.picfbnoselected);
            this.Controls.Add(this.picfbemail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picfbpass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginFacebook";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginFacebook";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LoginFacebook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLoginfb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfbnoselected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfbemail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfbpass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox picfbpass;
        private System.Windows.Forms.PictureBox picLoginfb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picfbemail;
        private System.Windows.Forms.PictureBox picfbnoselected;
        private System.Windows.Forms.PictureBox picClose;
    }
}