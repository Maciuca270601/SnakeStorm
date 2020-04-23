namespace SnakeStorm
{
    partial class Music
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
            this.picPrevious = new System.Windows.Forms.PictureBox();
            this.picNext = new System.Windows.Forms.PictureBox();
            this.picThreeHeadedSnake = new System.Windows.Forms.PictureBox();
            this.picBrokenLove = new System.Windows.Forms.PictureBox();
            this.picContact = new System.Windows.Forms.PictureBox();
            this.picPickUp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThreeHeadedSnake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBrokenLove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPickUp)).BeginInit();
            this.SuspendLayout();
            // 
            // picPrevious
            // 
            this.picPrevious.Image = global::SnakeStorm.Properties.Resources.previous1;
            this.picPrevious.Location = new System.Drawing.Point(56, 326);
            this.picPrevious.Name = "picPrevious";
            this.picPrevious.Size = new System.Drawing.Size(24, 24);
            this.picPrevious.TabIndex = 8;
            this.picPrevious.TabStop = false;
            this.picPrevious.Click += new System.EventHandler(this.picPrevious_Click);
            // 
            // picNext
            // 
            this.picNext.Image = global::SnakeStorm.Properties.Resources.next1;
            this.picNext.Location = new System.Drawing.Point(266, 326);
            this.picNext.Name = "picNext";
            this.picNext.Size = new System.Drawing.Size(24, 24);
            this.picNext.TabIndex = 5;
            this.picNext.TabStop = false;
            this.picNext.Click += new System.EventHandler(this.picNext_Click);
            // 
            // picThreeHeadedSnake
            // 
            this.picThreeHeadedSnake.Image = global::SnakeStorm.Properties.Resources.guna3;
            this.picThreeHeadedSnake.Location = new System.Drawing.Point(0, 0);
            this.picThreeHeadedSnake.Name = "picThreeHeadedSnake";
            this.picThreeHeadedSnake.Size = new System.Drawing.Size(340, 500);
            this.picThreeHeadedSnake.TabIndex = 1;
            this.picThreeHeadedSnake.TabStop = false;
            // 
            // picBrokenLove
            // 
            this.picBrokenLove.Image = global::SnakeStorm.Properties.Resources.template_music3;
            this.picBrokenLove.Location = new System.Drawing.Point(0, 0);
            this.picBrokenLove.Name = "picBrokenLove";
            this.picBrokenLove.Size = new System.Drawing.Size(340, 500);
            this.picBrokenLove.TabIndex = 3;
            this.picBrokenLove.TabStop = false;
            this.picBrokenLove.Visible = false;
            // 
            // picContact
            // 
            this.picContact.Image = global::SnakeStorm.Properties.Resources.tyga;
            this.picContact.Location = new System.Drawing.Point(0, 0);
            this.picContact.Name = "picContact";
            this.picContact.Size = new System.Drawing.Size(340, 500);
            this.picContact.TabIndex = 6;
            this.picContact.TabStop = false;
            this.picContact.Visible = false;
            // 
            // picPickUp
            // 
            this.picPickUp.Image = global::SnakeStorm.Properties.Resources.dababy;
            this.picPickUp.Location = new System.Drawing.Point(0, 0);
            this.picPickUp.Name = "picPickUp";
            this.picPickUp.Size = new System.Drawing.Size(340, 500);
            this.picPickUp.TabIndex = 7;
            this.picPickUp.TabStop = false;
            this.picPickUp.Visible = false;
            // 
            // Music
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(340, 500);
            this.Controls.Add(this.picPrevious);
            this.Controls.Add(this.picNext);
            this.Controls.Add(this.picThreeHeadedSnake);
            this.Controls.Add(this.picBrokenLove);
            this.Controls.Add(this.picContact);
            this.Controls.Add(this.picPickUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Music";
            this.Text = "Music";
            this.Load += new System.EventHandler(this.Music_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThreeHeadedSnake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBrokenLove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPickUp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picThreeHeadedSnake;
        private System.Windows.Forms.PictureBox picBrokenLove;
        private System.Windows.Forms.PictureBox picNext;
        private System.Windows.Forms.PictureBox picContact;
        private System.Windows.Forms.PictureBox picPickUp;
        private System.Windows.Forms.PictureBox picPrevious;
    }
}