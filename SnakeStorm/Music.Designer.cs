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
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.picture2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).BeginInit();
            this.SuspendLayout();
            // 
            // picture1
            // 
            this.picture1.Image = global::SnakeStorm.Properties.Resources.template_music;
            this.picture1.Location = new System.Drawing.Point(0, 0);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(344, 510);
            this.picture1.TabIndex = 1;
            this.picture1.TabStop = false;
            // 
            // picture2
            // 
            this.picture2.Image = global::SnakeStorm.Properties.Resources.guna;
            this.picture2.Location = new System.Drawing.Point(0, 0);
            this.picture2.Name = "picture2";
            this.picture2.Size = new System.Drawing.Size(344, 510);
            this.picture2.TabIndex = 3;
            this.picture2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Music
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(344, 510);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picture1);
            this.Controls.Add(this.picture2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Music";
            this.Text = "Music";
            this.Load += new System.EventHandler(this.Music_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.PictureBox picture2;
        private System.Windows.Forms.Button button1;
    }
}