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
          
            picuser.Parent = pictureBox3;
            picuser.BackColor = Color.Transparent;
            picClose.Parent = pictureBox3;
            picClose.BackColor = Color.Transparent;
           



        }

        

        private void picLaunchgame_Click(object sender, EventArgs e)//Launch game
        {
            frmSnake frm = new frmSnake();
            this.Close();
            firstform.loginplayer.controls.stop();

            frm.Show();
        }

        private void picLeaderboards_Click(object sender, EventArgs e)//Leaderboards
        {
            picLeaderboards.Image = Properties.Resources.leaderboardsselected1;
            picHighscore.Image = Properties.Resources.highscorebutton1;
            picMusic.Image = Properties.Resources.musicbutton1;
            picTutorial.Image = Properties.Resources.tutorialbutton1;
            picPageChanger.Image = Properties.Resources.bubble2;

            Leaderboard leaderb = new Leaderboard();
            leaderb.TopLevel = false;
            leaderb.FormBorderStyle = FormBorderStyle.None;
            leaderb.WindowState = FormWindowState.Maximized;
            picpanel.Controls.Add(leaderb);
            leaderb.Show();
        }

        private void picHighscore_Click(object sender, EventArgs e)//Highscore
        {
            picLeaderboards.Image = Properties.Resources.leaderboardsbutton1;
            picHighscore.Image = Properties.Resources.highscoreselected1;
            picMusic.Image = Properties.Resources.musicbutton1;
            picTutorial.Image = Properties.Resources.tutorialbutton1;
            picPageChanger.Image = Properties.Resources.bubble3;

            Highscore highsc = new Highscore();
            highsc.TopLevel = false;
            highsc.FormBorderStyle = FormBorderStyle.None;
            highsc.WindowState = FormWindowState.Maximized;
            picpanel.Controls.Add(highsc);
            highsc.Show();
        }

        private void picMusic_Click(object sender, EventArgs e)//Music
        {
            picLeaderboards.Image = Properties.Resources.leaderboardsbutton1;
            picHighscore.Image = Properties.Resources.highscorebutton1;
            picMusic.Image = Properties.Resources.musicselected1;
            picTutorial.Image = Properties.Resources.tutorialbutton1;
            picPageChanger.Image = Properties.Resources.bubble4;

            Music songmeniu = new Music();
            songmeniu.TopLevel = false;
            songmeniu.FormBorderStyle = FormBorderStyle.None;
            songmeniu.WindowState = FormWindowState.Maximized;
            picpanel.Controls.Add(songmeniu);
            songmeniu.Show();
        }

        private void picTutorial_Click(object sender, EventArgs e)//Tutorial
        {
            picLeaderboards.Image = Properties.Resources.leaderboardsbutton1;
            picHighscore.Image = Properties.Resources.highscorebutton1;
            picMusic.Image = Properties.Resources.musicbutton1;
            picTutorial.Image = Properties.Resources.tutorialselected1;
            picPageChanger.Image = Properties.Resources.bubble5;

            Tutorial tut = new Tutorial();
            tut.TopLevel = false;
            tut.FormBorderStyle = FormBorderStyle.None;
            tut.WindowState = FormWindowState.Maximized;
            picpanel.Controls.Add(tut);
            tut.Show();
        }

        private void picuser_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            accountdetails acc = new accountdetails();
            acc.TopLevel = false;
            acc.FormBorderStyle = FormBorderStyle.None;
            acc.WindowState = FormWindowState.Maximized;
            pictureBox1.Controls.Add(acc);
            acc.Show();
            
          

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
