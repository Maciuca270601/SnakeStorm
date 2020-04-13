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
    public partial class firstform : Form
    {
        
        
        
        public static WindowsMediaPlayer loginplayer = new WindowsMediaPlayer();

        public firstform()
        {
            InitializeComponent();
            //loginplayer.URL = "ncs.mp3";
        }
        
        LoginFacebook logfb = new LoginFacebook();
        Register reg = new Register();
        Meniu menu = new Meniu();

        private void firstform_Load(object sender, EventArgs e)
        {
            
            picfb.Parent = pictureBox1;
            picfb.BackColor = Color.Transparent;
            picClose.Parent = pictureBox1;
            picClose.BackColor = Color.Transparent;
            piclogin.Parent = pictureBox1;
            piclogin.BackColor = Color.Transparent;
            picreg.Parent = pictureBox1;
            picreg.BackColor = Color.Transparent;
            loginplayer.controls.play();

        }

        private void picfb_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            logfb.TopMost = true;
            logfb.Show();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void piclogin_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            menu.TopMost = true;
            menu.Show();
        }

        private void picreg_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            reg.TopMost = true;
            reg.Show();
        }
    }
}
