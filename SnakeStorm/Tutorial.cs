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
    public partial class Tutorial : Form
    {
        public Tutorial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox1.Visible = true;
              
            }

            else if (pictureBox1.Visible==true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
               
            }
            

        }
    }
}
