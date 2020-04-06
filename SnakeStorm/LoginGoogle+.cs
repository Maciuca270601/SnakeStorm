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
    public partial class LoginGoogle_ : Form
    {
        public LoginGoogle_()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            picUser.Image = Properties.Resources.username_selected;
            panel1.BackColor = Color.SteelBlue;
            textBox1.ForeColor = Color.SteelBlue;

            picPass.Image = Properties.Resources.locker_ini;
            panel3.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.PasswordChar = '•';
            picPass.Image = Properties.Resources.locker_selected;
            panel3.BackColor = Color.SteelBlue;
            textBox2.ForeColor = Color.SteelBlue;

            picUser.Image = Properties.Resources.username_ini;
            panel1.BackColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.WhiteSmoke;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unfortunately the app doesn't support google+ registration yet...");
        }
    }
}
