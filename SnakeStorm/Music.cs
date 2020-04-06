using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeStorm
{
    public partial class Music : Form
    {
        
        public static string settext = "";
        public Music()
        {
            InitializeComponent();
        }

        private void Music_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(picture1.Visible == true)
            {
                picture2.Visible = true;
                picture1.Visible = false;
                settext = "gunna.mp3";
            }
            else if(picture2.Visible ==true)
            {
                picture1.Visible = true;
                picture2.Visible = false;
                settext = "snakestorm soundtrack.mp3";
            }
        }
    }
}
