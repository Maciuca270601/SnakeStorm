namespace SnakeStorm
{
    partial class Meniu
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
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.Silver;
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Font = new System.Drawing.Font("BRUSHMOSH! Demo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Username.HideSelection = false;
            this.Username.Location = new System.Drawing.Point(33, 136);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(180, 29);
            this.Username.TabIndex = 2;
            this.Username.Text = "Username";
            this.Username.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.Silver;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Font = new System.Drawing.Font("BRUSHMOSH! Demo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Password.Location = new System.Drawing.Point(33, 187);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(180, 29);
            this.Password.TabIndex = 7;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox3.Image = global::SnakeStorm.Properties.Resources.register_no_selection2;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(370, 549);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SnakeStorm.Properties.Resources.register_username_selected1;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(370, 549);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SnakeStorm.Properties.Resources.register_password_selected1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 549);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // picLogin
            // 
            this.picLogin.Location = new System.Drawing.Point(18, 234);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(150, 40);
            this.picLogin.TabIndex = 13;
            this.picLogin.TabStop = false;
            this.picLogin.Click += new System.EventHandler(this.picLogin_Click);
            // 
            // picClose
            // 
            this.picClose.Location = new System.Drawing.Point(338, 13);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(20, 21);
            this.picClose.TabIndex = 14;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // Meniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(370, 549);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.picLogin);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Meniu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.PictureBox picClose;
    }
}