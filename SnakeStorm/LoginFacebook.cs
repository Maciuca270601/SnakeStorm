using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;

namespace SnakeStorm
{
    public partial class LoginFacebook : Form
    {
        public static string settext = "";
        public static int fb = 0;
        public LoginFacebook()
        {
            InitializeComponent();
        }
        Launcher launcher = new Launcher();
      

        private void textBox1_Click(object sender, EventArgs e)
        {
            picfbnoselected.Visible = false;
            picfbemail.Visible = true;
            textBox1.Clear();
     
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            picfbemail.Visible = false;
            picfbpass.Visible = true;
            textBox2.Clear();
            textBox2.PasswordChar = '•';
          
        }

     

        private void picLoginfb_Click(object sender, EventArgs e)
        {
            KaizenSoftFBEL.KaizenSoftFBEL fbLogin = new KaizenSoftFBEL.KaizenSoftFBEL();

            if (fbLogin.Enter(textBox1.Text, textBox2.Text))

            {
                fb = 1;
                settext = "facebook user";
                this.TopMost = false;
                launcher.TopMost = true;
                launcher.Show();
            }

            else

            { MessageBox.Show("Login Error!"); }
        }

        private void LoginFacebook_Load(object sender, EventArgs e)
        {
            picClose.Parent = picfbnoselected;
            picClose.BackColor = Color.Transparent;
            picLoginfb.Parent = picfbpass;
            picLoginfb.BackColor = Color.Transparent;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
