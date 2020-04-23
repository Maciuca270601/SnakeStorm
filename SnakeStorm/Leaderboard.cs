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
    public partial class Leaderboard : Form
    {
        SqlConnection dbConn;
        SqlDataAdapter da;
        DataSet ds;
        DataRow dr;
       
        

        public Leaderboard()
        {
            InitializeComponent();
        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {
            dbConn = new SqlConnection(Properties.Settings.Default.dbConnection);
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;
            label5.Parent = pictureBox1;
            label5.BackColor = Color.Transparent;
            label6.Parent = pictureBox1;
            label6.BackColor = Color.Transparent;
            label7.Parent = pictureBox1;
            label7.BackColor = Color.Transparent;
            label8.Parent = pictureBox1;
            label8.BackColor = Color.Transparent;
            label9.Parent = pictureBox1;
            label9.BackColor = Color.Transparent;
            label10.Parent = pictureBox1;
            label10.BackColor = Color.Transparent;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.button_selected;
            dbConn.Open();
            string query = "SELECT username,score FROM TabelaScore ORDER BY score DESC";
            da = new SqlDataAdapter(query, dbConn);
            ds = new DataSet("leaderboard");
            da.Fill(ds, "leaderboard");
            for(int currentRow = 0;currentRow<5;currentRow++)
            {
                if (currentRow == 0)
                {
                    dr = ds.Tables["leaderboard"].Rows[currentRow];
                    label1.Text = dr.ItemArray.GetValue(0).ToString();
                    label6.Text = dr.ItemArray.GetValue(1).ToString();
                }
                if (currentRow == 1)
                {
                    dr = ds.Tables["leaderboard"].Rows[currentRow];
                    label2.Text = dr.ItemArray.GetValue(0).ToString();
                    label7.Text = dr.ItemArray.GetValue(1).ToString();
                }
                if (currentRow == 2)
                {
                    dr = ds.Tables["leaderboard"].Rows[currentRow];
                    label3.Text = dr.ItemArray.GetValue(0).ToString();
                    label8.Text = dr.ItemArray.GetValue(1).ToString();
                }
                if (currentRow == 3)
                {
                    dr = ds.Tables["leaderboard"].Rows[currentRow];
                    label4.Text = dr.ItemArray.GetValue(0).ToString();
                    label9.Text = dr.ItemArray.GetValue(1).ToString();
                }
                if (currentRow == 4)
                {
                    dr = ds.Tables["leaderboard"].Rows[currentRow];
                    label5.Text = dr.ItemArray.GetValue(0).ToString();
                    label10.Text = dr.ItemArray.GetValue(1).ToString();
                }
            }


            dbConn.Close();
        }

       
    }
}
