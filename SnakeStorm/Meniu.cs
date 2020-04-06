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
using WMPLib;

namespace SnakeStorm
{ 
    

    public partial class Meniu : Form
    {
        public static string settext = "";
        public Meniu()
        {
            InitializeComponent();
            player.URL = "MicroVolts Surge Soundtrack.mp3";
        }

        SqlConnection dbConn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        public static int id;
        public static string name;
        WindowsMediaPlayer player = new WindowsMediaPlayer();




        LoginFacebook logfb = new LoginFacebook();
        LoginTwitter logtw = new LoginTwitter();
        LoginGoogle_ logg = new LoginGoogle_();
        Launcher launcher = new Launcher();
        Register reg = new Register();

        private void Menu_Load(object sender, EventArgs e)
        {
           dbConn = new SqlConnection(Properties.Settings.Default.dbConnection);
            player.controls.play();

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

        

        private void picfb_Click(object sender, EventArgs e)
        {
            
            this.TopMost = false;
            logfb.TopMost = true;
            logfb.Show();
        }


        private void label2_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void pictw_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            logtw.TopMost = true;
            logtw.Show();

        }

        private void picg_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            logg.TopMost = true;
            logg.Show();

        }

        private void button2_Click(object sender, EventArgs e)//register
        {

            this.TopMost = false;
            reg.TopMost=true;
            reg.Show();
        }

        private void button1_Click(object sender, EventArgs e)//login
        {
            dbConn.Open();
            string query = "SELECT Username FROM TabelaLogin WHERE Username = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'";
            SqlCommand cmd = new SqlCommand("SELECT ID FROM TabelaLogin WHERE Username = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'", dbConn);
            SqlCommand cmd2 = new SqlCommand("SELECT Username FROM TabelaLogin WHERE Username = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'", dbConn);
            name = Convert.ToString(cmd2.ExecuteScalar());
            id = Convert.ToInt32(cmd.ExecuteScalar());
            da = new SqlDataAdapter(query, dbConn);
            da.Fill(ds);
            dt = ds.Tables[0];
         
            if(dt.Rows.Count>0)
            {
                
                settext = textBox1.Text;
                this.TopMost = false;
                launcher.TopMost = true;
                player.controls.pause();
                launcher.Show();
            }
            else
            {
                MessageBox.Show("Invalid login credentials!");
            }
            dbConn.Close();
        }

        
    }
}
