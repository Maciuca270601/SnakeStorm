using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;


namespace SnakeStorm
{
   
    public partial class Launcher : Form
    {

        //snakestorm soundtrack.mp3
        //Sweeper You.mp3
        //Stranger Things.mp3
        //gunna.mp3
        // rotmg soundtrack
        public Launcher()
        {
            InitializeComponent();

        }



        private void Launcher_Load(object sender, EventArgs e)
        {
            label6.Text = Meniu.settext;
            if (Meniu.settext == "")
                label6.Text = LoginFacebook.settext;
            panel1.Parent = pictureBox3;
            panel1.BackColor = Color.Transparent;
            panel2.Parent = pictureBox3;
            panel2.BackColor = Color.Transparent;
            panel3.Parent = pictureBox3;
            panel3.BackColor = Color.Transparent;
            panel4.Parent = pictureBox3;
            panel4.BackColor = Color.Transparent;
            panel5.Parent = pictureBox3;
            panel5.BackColor = Color.Transparent;
            
 
            
        }

        private void label1_Click(object sender, EventArgs e)//launchGame
        {
            panel1.BackColor = Color.FromArgb(44, 152, 224);
            label1.ForeColor = Color.WhiteSmoke;
            
            panel2.Parent = pictureBox3;
            panel2.BackColor = Color.Transparent;
            label2.ForeColor = Color.FromArgb(110, 110, 110);
            panel3.Parent = pictureBox3;
            panel3.BackColor = Color.Transparent;
            label3.ForeColor = Color.FromArgb(110, 110, 110);
            panel4.Parent = pictureBox3;
            panel4.BackColor = Color.Transparent;
            label4.ForeColor = Color.FromArgb(110, 110, 110);
            panel5.Parent = pictureBox3;
            panel5.BackColor = Color.Transparent;
            label5.ForeColor = Color.FromArgb(110, 110, 110);

            frmSnake frm = new frmSnake();
            this.Close();
            firstform.loginplayer.controls.stop();
            
             frm.Show();
            

        }

        private void label3_Click(object sender, EventArgs e)//highscore
        {
            panel3.BackColor = Color.FromArgb(254, 208, 114);
            label3.ForeColor = Color.White;

            panel1.Parent = pictureBox3;
            panel1.BackColor = Color.Transparent;
            label1.ForeColor = Color.FromArgb(110, 110, 110);
            panel2.Parent = pictureBox3;
            panel2.BackColor = Color.Transparent;
            label2.ForeColor = Color.FromArgb(110, 110, 110);
            panel4.Parent = pictureBox3;
            panel4.BackColor = Color.Transparent;
            label4.ForeColor = Color.FromArgb(110, 110, 110);
            panel5.Parent = pictureBox3;
            panel5.BackColor = Color.Transparent;
            label5.ForeColor = Color.FromArgb(110, 110, 110);

            Highscore highsc = new Highscore();
            highsc.TopLevel = false;
            highsc.FormBorderStyle = FormBorderStyle.None;
            highsc.WindowState = FormWindowState.Maximized;
            panel6.Controls.Add(highsc);
            highsc.Show();

        }

        private void label4_Click(object sender, EventArgs e)//music
        {
            panel4.BackColor = Color.FromArgb(27, 184, 155);
            label4.ForeColor = Color.White;
            
            panel1.Parent = pictureBox3;
            panel1.BackColor = Color.Transparent;
            label1.ForeColor = Color.FromArgb(110, 110, 110);
            panel2.Parent = pictureBox3;
            panel2.BackColor = Color.Transparent;
            label2.ForeColor = Color.FromArgb(110, 110, 110);
            panel3.Parent = pictureBox3;
            panel3.BackColor = Color.Transparent;
            label3.ForeColor = Color.FromArgb(110, 110, 110);
            panel5.Parent = pictureBox3;
            panel5.BackColor = Color.Transparent;
            label5.ForeColor = Color.FromArgb(110, 110, 110);

            Music songmeniu = new Music();
            songmeniu.TopLevel = false;
            songmeniu.FormBorderStyle = FormBorderStyle.None;
            songmeniu.WindowState = FormWindowState.Maximized;
            panel6.Controls.Add(songmeniu);
            songmeniu.Show();
            
        }

        private void label5_Click(object sender, EventArgs e)//tutorial
        {
            panel5.BackColor = Color.FromArgb(27, 184, 155);
            label5.ForeColor = Color.White;
            
            panel2.Parent = pictureBox3;
            panel2.BackColor = Color.Transparent;
            label2.ForeColor = Color.FromArgb(110, 110, 110);
            panel3.Parent = pictureBox3;
            panel3.BackColor = Color.Transparent;
            label3.ForeColor = Color.FromArgb(110, 110, 110);
            panel1.Parent = pictureBox3;
            panel1.BackColor = Color.Transparent;
            label1.ForeColor = Color.FromArgb(110, 110, 110);
            panel4.Parent = pictureBox3;
            panel4.BackColor = Color.Transparent;
            label4.ForeColor = Color.FromArgb(110, 110, 110);

            Tutorial tut = new Tutorial();
            tut.TopLevel = false;
            tut.FormBorderStyle = FormBorderStyle.None;
            tut.WindowState = FormWindowState.Maximized;
            panel6.Controls.Add(tut);
            tut.Show();
            
        }

        

        private void label2_Click(object sender, EventArgs e)//leaderboards
        {
            panel2.BackColor = Color.FromArgb(254, 208, 114);
            label2.ForeColor = Color.White;

            panel1.Parent = pictureBox3;
            panel1.BackColor = Color.Transparent;
            label1.ForeColor = Color.FromArgb(110, 110, 110);
            panel3.Parent = pictureBox3;
            panel3.BackColor = Color.Transparent;
            label3.ForeColor = Color.FromArgb(110, 110, 110);
            panel4.Parent = pictureBox3;
            panel4.BackColor = Color.Transparent;
            label4.ForeColor = Color.FromArgb(110, 110, 110);
            panel5.Parent = pictureBox3;
            panel5.BackColor = Color.Transparent;
            label5.ForeColor = Color.FromArgb(110, 110, 110);

            Leaderboard leaderb = new Leaderboard();
            leaderb.TopLevel = false;
            leaderb.FormBorderStyle = FormBorderStyle.None;
            leaderb.WindowState = FormWindowState.Maximized;
            panel6.Controls.Add(leaderb);
            leaderb.Show();
        }
        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
