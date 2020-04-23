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

        private void textBox1_Click(object sender, EventArgs e)//username
        {
            picCreateAccount.Visible = false;
            picCreateUsername.Visible = true;
            picAccountCreated.Visible = false;
            picCreateEmail.Visible = false;
            picCreatePassword.Visible = false;
            picClose.Parent = picCreateUsername;
            picClose.BackColor = Color.Transparent;
            textBox1.Clear();
            
        }

        private void textBox2_Click(object sender, EventArgs e)//password
        {
            picCreateUsername.Visible = false;
            picCreatePassword.Visible = true;
            picCreateAccount.Visible = false;
            picCreateEmail.Visible = false;
            picAccountCreated.Visible = false;
            picClose.Parent = picCreatePassword;
            picClose.BackColor = Color.Transparent;
            textBox2.Clear();
            textBox2.PasswordChar = '•';
        }
           

        private void textBox3_Click(object sender, EventArgs e)//email
        {
            picCreatePassword.Visible = false;
            picCreateEmail.Visible = true;
            picCreateUsername.Visible = false;
            picCreateAccount.Visible = false;
            picAccountCreated.Visible = false;
            picClose.Parent = picCreateEmail;
            picClose.BackColor = Color.Transparent;
            textBox3.Clear();
            
        }

        private void Register_Load(object sender, EventArgs e)
        {
            dbConn = new SqlConnection(Properties.Settings.Default.dbConnection);
            picRegister.Parent = picCreateEmail;
            picRegister.BackColor = Color.Transparent;
            picClose.Parent = picCreateAccount;
            picClose.BackColor = Color.Transparent;
            picReturn.Parent = picAccountCreated;
            picReturn.BackColor = Color.Transparent;
          
        }

        private void picRegister_Click(object sender, EventArgs e)
        {
            dbConn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TabelaLogin(Username , Password , Email) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", dbConn);
            cmd.ExecuteNonQuery();
            dbConn.Close();
            picRegister.Visible = false;
            picReturn.Visible = true;
            picCreateAccount.Visible = false;
            picCreateUsername.Visible = false;
            picCreateEmail.Visible = false;
            picCreatePassword.Visible = false;
            picAccountCreated.Visible = true;
        }


        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
