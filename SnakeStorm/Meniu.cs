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
    

    public partial class Meniu : Form//forma aceasta se foloseste pe post de login
    {
        public static string settext = "";
        public Meniu()
        {
            InitializeComponent();
           
        }

        SqlConnection dbConn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        public static int id;
        public static string name;
        Launcher launcher = new Launcher();
        accountdetails acc = new accountdetails();
        

        private void Menu_Load(object sender, EventArgs e)
        {
           dbConn = new SqlConnection(Properties.Settings.Default.dbConnection);
            picLogin.Parent = pictureBox1;
            picLogin.BackColor = Color.Transparent;
            picClose.Parent = pictureBox3;
            picClose.BackColor = Color.Transparent;
          
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            picClose.Parent = pictureBox2;
            picClose.BackColor = Color.Transparent;
            Username.Clear();
             
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox1.Visible = true;
            picClose.Parent = pictureBox1;
            picClose.BackColor = Color.Transparent;
            Password.Clear();
            Password.PasswordChar = '•';
            
          
        }

        private void picLogin_Click(object sender, EventArgs e)
        {
            dbConn.Open();
            string query = "SELECT Username FROM TabelaLogin WHERE Username = '" + Username.Text + "' and Password = '" + Password.Text + "'";
            SqlCommand cmd = new SqlCommand("SELECT ID FROM TabelaLogin WHERE Username = '" + Username.Text + "' and Password = '" + Password.Text + "'", dbConn);
            SqlCommand cmd2 = new SqlCommand("SELECT Username FROM TabelaLogin WHERE Username = '" + Username.Text + "' and Password = '" + Password.Text + "'", dbConn);
            name = Convert.ToString(cmd2.ExecuteScalar());
            id = Convert.ToInt32(cmd.ExecuteScalar());
            da = new SqlDataAdapter(query, dbConn);
            da.Fill(ds);
            dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {

                settext = Username.Text;
                this.TopMost = false;
                launcher.TopMost = true;
                launcher.Show();
            }
            else
            {
                MessageBox.Show("Invalid login credentials!");
            }
            dbConn.Close();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
