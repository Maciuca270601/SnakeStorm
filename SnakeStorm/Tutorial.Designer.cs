namespace SnakeStorm
{
    partial class Tutorial
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
            this.picNext = new System.Windows.Forms.PictureBox();
            this.picPrevious = new System.Windows.Forms.PictureBox();
            this.picMovement = new System.Windows.Forms.PictureBox();
            this.picBonuses = new System.Windows.Forms.PictureBox();
            this.picVirus = new System.Windows.Forms.PictureBox();
            this.picDiamond = new System.Windows.Forms.PictureBox();
            this.picWallTail = new System.Windows.Forms.PictureBox();
            this.picFacebook = new System.Windows.Forms.PictureBox();
            this.picBomb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMovement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBonuses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVirus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiamond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWallTail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBomb)).BeginInit();
            this.SuspendLayout();
            // 
            // picNext
            // 
            this.picNext.Image = global::SnakeStorm.Properties.Resources.next_button;
            this.picNext.Location = new System.Drawing.Point(130, 11);
            this.picNext.Name = "picNext";
            this.picNext.Size = new System.Drawing.Size(51, 23);
            this.picNext.TabIndex = 9;
            this.picNext.TabStop = false;
            this.picNext.Click += new System.EventHandler(this.picNext_Click);
            // 
            // picPrevious
            // 
            this.picPrevious.Image = global::SnakeStorm.Properties.Resources.previous_button;
            this.picPrevious.Location = new System.Drawing.Point(25, 11);
            this.picPrevious.Name = "picPrevious";
            this.picPrevious.Size = new System.Drawing.Size(98, 23);
            this.picPrevious.TabIndex = 8;
            this.picPrevious.TabStop = false;
            this.picPrevious.Click += new System.EventHandler(this.picPrevious_Click);
            // 
            // picMovement
            // 
            this.picMovement.Image = global::SnakeStorm.Properties.Resources.snake_movement2;
            this.picMovement.Location = new System.Drawing.Point(0, 0);
            this.picMovement.Name = "picMovement";
            this.picMovement.Size = new System.Drawing.Size(340, 500);
            this.picMovement.TabIndex = 7;
            this.picMovement.TabStop = false;
            // 
            // picBonuses
            // 
            this.picBonuses.Image = global::SnakeStorm.Properties.Resources.bonuses1;
            this.picBonuses.Location = new System.Drawing.Point(0, 0);
            this.picBonuses.Name = "picBonuses";
            this.picBonuses.Size = new System.Drawing.Size(340, 500);
            this.picBonuses.TabIndex = 6;
            this.picBonuses.TabStop = false;
            this.picBonuses.Visible = false;
            // 
            // picVirus
            // 
            this.picVirus.Image = global::SnakeStorm.Properties.Resources.Virus1;
            this.picVirus.Location = new System.Drawing.Point(0, 0);
            this.picVirus.Name = "picVirus";
            this.picVirus.Size = new System.Drawing.Size(340, 500);
            this.picVirus.TabIndex = 5;
            this.picVirus.TabStop = false;
            this.picVirus.Visible = false;
            // 
            // picDiamond
            // 
            this.picDiamond.Image = global::SnakeStorm.Properties.Resources.diamond;
            this.picDiamond.Location = new System.Drawing.Point(0, 0);
            this.picDiamond.Name = "picDiamond";
            this.picDiamond.Size = new System.Drawing.Size(340, 500);
            this.picDiamond.TabIndex = 10;
            this.picDiamond.TabStop = false;
            // 
            // picWallTail
            // 
            this.picWallTail.Image = global::SnakeStorm.Properties.Resources.Walls_and_Tail1;
            this.picWallTail.Location = new System.Drawing.Point(0, 0);
            this.picWallTail.Name = "picWallTail";
            this.picWallTail.Size = new System.Drawing.Size(340, 500);
            this.picWallTail.TabIndex = 3;
            this.picWallTail.TabStop = false;
            this.picWallTail.Visible = false;
            // 
            // picFacebook
            // 
            this.picFacebook.Image = global::SnakeStorm.Properties.Resources.facebook_au1;
            this.picFacebook.Location = new System.Drawing.Point(0, 0);
            this.picFacebook.Name = "picFacebook";
            this.picFacebook.Size = new System.Drawing.Size(340, 500);
            this.picFacebook.TabIndex = 2;
            this.picFacebook.TabStop = false;
            this.picFacebook.Visible = false;
            // 
            // picBomb
            // 
            this.picBomb.Image = global::SnakeStorm.Properties.Resources.Bomb1;
            this.picBomb.Location = new System.Drawing.Point(0, 0);
            this.picBomb.Name = "picBomb";
            this.picBomb.Size = new System.Drawing.Size(340, 500);
            this.picBomb.TabIndex = 4;
            this.picBomb.TabStop = false;
            this.picBomb.Visible = false;
            // 
            // Tutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(340, 500);
            this.Controls.Add(this.picNext);
            this.Controls.Add(this.picPrevious);
            this.Controls.Add(this.picMovement);
            this.Controls.Add(this.picBonuses);
            this.Controls.Add(this.picVirus);
            this.Controls.Add(this.picBomb);
            this.Controls.Add(this.picDiamond);
            this.Controls.Add(this.picWallTail);
            this.Controls.Add(this.picFacebook);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tutorial";
            this.Text = "Tutorial";
            this.Load += new System.EventHandler(this.Tutorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMovement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBonuses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVirus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiamond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWallTail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBomb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picFacebook;
        private System.Windows.Forms.PictureBox picWallTail;
        private System.Windows.Forms.PictureBox picBomb;
        private System.Windows.Forms.PictureBox picVirus;
        private System.Windows.Forms.PictureBox picBonuses;
        private System.Windows.Forms.PictureBox picMovement;
        private System.Windows.Forms.PictureBox picPrevious;
        private System.Windows.Forms.PictureBox picNext;
        private System.Windows.Forms.PictureBox picDiamond;
    }
}