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
    public partial class accountdetails : Form
    {
        public accountdetails()
        {
            InitializeComponent();
        }

        private void accountdetails_Load(object sender, EventArgs e)
        {

            playername.Text = Meniu.settext;
            if (Meniu.settext == "")
                playername.Text = LoginFacebook.settext;
            playername.Parent = pictureBox1;
            playername.BackColor = Color.Transparent;



            
        }
    }
}
