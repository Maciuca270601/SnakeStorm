using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SnakeStorm
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        SqlConnection dbConn = new SqlConnection();

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            picUser.Image = Properties.Resources.username_selected;
            panel1.BackColor = Color.SteelBlue;
            textBox1.ForeColor = Color.SteelBlue;

            picPass.Image = Properties.Resources.locker_ini;
            panel3.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            picEmail.Image = Properties.Resources.mail_ini;
            panel4.BackColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;
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

            picEmail.Image = Properties.Resources.mail_ini;
            panel4.BackColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            picEmail.Image = Properties.Resources.mail_selected;
            panel4.BackColor = Color.SteelBlue;
            textBox3.ForeColor = Color.SteelBlue;

            picPass.Image = Properties.Resources.locker_ini;
            panel3.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            picUser.Image = Properties.Resources.username_ini;
            panel1.BackColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.WhiteSmoke;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            this.Close();
           
        }

        private void button2_Click(object sender, EventArgs e)//inregistrare
        {
            dbConn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TabelaLogin(Username , Password , Email) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", dbConn);
            cmd.ExecuteNonQuery();
            label1.Text = "Registered";
            dbConn.Close();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            dbConn = new SqlConnection(Properties.Settings.Default.dbConnection);
        }
    }
}
