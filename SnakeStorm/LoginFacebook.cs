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
       

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
         

       
       

      
            
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.PasswordChar = '•';
          

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KaizenSoftFBEL.KaizenSoftFBEL fbLogin = new KaizenSoftFBEL.KaizenSoftFBEL();

            if (fbLogin.Enter(textBox1.Text, textBox2.Text))

            {
                fb = 1;
                settext = "facebook";
                this.TopMost = false;
                launcher.TopMost = true;
                launcher.Show();
            }

            else

            { MessageBox.Show("Login Error!"); }
        }
    }
}
