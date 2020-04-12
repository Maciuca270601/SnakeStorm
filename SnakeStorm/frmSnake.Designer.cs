namespace SnakeStorm
{
    partial class frmSnake
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSnake));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picGameBoard = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGameBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 150;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "apple.png");
            this.imgList.Images.SetKeyName(1, "ytitit.png");
            this.imgList.Images.SetKeyName(2, "cupcake.png");
            this.imgList.Images.SetKeyName(3, "donut.png");
            this.imgList.Images.SetKeyName(4, "snak.png");
            this.imgList.Images.SetKeyName(5, "headsnake.png");
            this.imgList.Images.SetKeyName(6, "brickwall (2).png");
            this.imgList.Images.SetKeyName(7, "bomb.png");
            this.imgList.Images.SetKeyName(8, "icons8-microbe-35.png");
            this.imgList.Images.SetKeyName(9, "diamond.png");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(219, 739);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 31);
            this.label3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(484, 739);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 31);
            this.label4.TabIndex = 5;
            // 
            // picGameBoard
            // 
            this.picGameBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.picGameBoard.Location = new System.Drawing.Point(49, 58);
            this.picGameBoard.Name = "picGameBoard";
            this.picGameBoard.Size = new System.Drawing.Size(630, 630);
            this.picGameBoard.TabIndex = 0;
            this.picGameBoard.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SnakeStorm.Properties.Resources.overlaygame;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(728, 796);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // frmSnake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(730, 797);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picGameBoard);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSnake";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSnake";
            this.Load += new System.EventHandler(this.frmSnake_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            ((System.ComponentModel.ISupportInitialize)(this.picGameBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGameBoard;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

