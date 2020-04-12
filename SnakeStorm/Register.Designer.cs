namespace SnakeStorm
{
    partial class Register
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picRegister = new System.Windows.Forms.PictureBox();
            this.picCreateAccount = new System.Windows.Forms.PictureBox();
            this.picCreateUsername = new System.Windows.Forms.PictureBox();
            this.picCreatePassword = new System.Windows.Forms.PictureBox();
            this.picCreateEmail = new System.Windows.Forms.PictureBox();
            this.picAccountCreated = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCreateAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCreateUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCreatePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCreateEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccountCreated)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Silver;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("BRUSHMOSH! Demo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.Location = new System.Drawing.Point(88, 275);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(180, 29);
            this.textBox3.TabIndex = 25;
            this.textBox3.Text = "Email";
            this.textBox3.Click += new System.EventHandler(this.textBox3_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Silver;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("BRUSHMOSH! Demo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.Location = new System.Drawing.Point(88, 215);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 29);
            this.textBox2.TabIndex = 24;
            this.textBox2.Text = "Password";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("BRUSHMOSH! Demo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(88, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 29);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "Username";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // picClose
            // 
            this.picClose.Location = new System.Drawing.Point(339, 13);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(19, 21);
            this.picClose.TabIndex = 34;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.Close_Click);
            // 
            // picRegister
            // 
            this.picRegister.Location = new System.Drawing.Point(107, 328);
            this.picRegister.Name = "picRegister";
            this.picRegister.Size = new System.Drawing.Size(156, 42);
            this.picRegister.TabIndex = 33;
            this.picRegister.TabStop = false;
            this.picRegister.Click += new System.EventHandler(this.picRegister_Click);
            // 
            // picCreateAccount
            // 
            this.picCreateAccount.Image = global::SnakeStorm.Properties.Resources.createaccount;
            this.picCreateAccount.Location = new System.Drawing.Point(0, 0);
            this.picCreateAccount.Name = "picCreateAccount";
            this.picCreateAccount.Size = new System.Drawing.Size(370, 549);
            this.picCreateAccount.TabIndex = 32;
            this.picCreateAccount.TabStop = false;
            // 
            // picCreateUsername
            // 
            this.picCreateUsername.Image = global::SnakeStorm.Properties.Resources.createaccount_user;
            this.picCreateUsername.Location = new System.Drawing.Point(0, 0);
            this.picCreateUsername.Name = "picCreateUsername";
            this.picCreateUsername.Size = new System.Drawing.Size(370, 549);
            this.picCreateUsername.TabIndex = 31;
            this.picCreateUsername.TabStop = false;
            // 
            // picCreatePassword
            // 
            this.picCreatePassword.Image = global::SnakeStorm.Properties.Resources.createaccount_pass;
            this.picCreatePassword.Location = new System.Drawing.Point(0, 0);
            this.picCreatePassword.Name = "picCreatePassword";
            this.picCreatePassword.Size = new System.Drawing.Size(370, 549);
            this.picCreatePassword.TabIndex = 30;
            this.picCreatePassword.TabStop = false;
            // 
            // picCreateEmail
            // 
            this.picCreateEmail.Image = global::SnakeStorm.Properties.Resources.createaccount_email;
            this.picCreateEmail.Location = new System.Drawing.Point(0, 0);
            this.picCreateEmail.Name = "picCreateEmail";
            this.picCreateEmail.Size = new System.Drawing.Size(370, 549);
            this.picCreateEmail.TabIndex = 29;
            this.picCreateEmail.TabStop = false;
            // 
            // picAccountCreated
            // 
            this.picAccountCreated.Image = global::SnakeStorm.Properties.Resources.accountcreated1;
            this.picAccountCreated.Location = new System.Drawing.Point(0, 0);
            this.picAccountCreated.Name = "picAccountCreated";
            this.picAccountCreated.Size = new System.Drawing.Size(370, 549);
            this.picAccountCreated.TabIndex = 28;
            this.picAccountCreated.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(370, 549);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.picRegister);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.picCreateAccount);
            this.Controls.Add(this.picCreateUsername);
            this.Controls.Add(this.picCreatePassword);
            this.Controls.Add(this.picCreateEmail);
            this.Controls.Add(this.picAccountCreated);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCreateAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCreateUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCreatePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCreateEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccountCreated)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox picAccountCreated;
        private System.Windows.Forms.PictureBox picCreateEmail;
        private System.Windows.Forms.PictureBox picCreatePassword;
        private System.Windows.Forms.PictureBox picCreateUsername;
        private System.Windows.Forms.PictureBox picCreateAccount;
        private System.Windows.Forms.PictureBox picRegister;
        private System.Windows.Forms.PictureBox picClose;
    }
}