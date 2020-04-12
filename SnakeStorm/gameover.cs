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
    public partial class gameover : Form
    {
        WindowsMediaPlayer gameoverplayer = new WindowsMediaPlayer();

        public gameover()
        {
            InitializeComponent();
            gameoverplayer.URL = "gameover soundtrack.mp3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gameover_Load(object sender, EventArgs e)
        {
            gameoverplayer.controls.play();
        }
    }
}
