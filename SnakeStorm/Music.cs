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
    public partial class Music : Form
    {
        
        public static string settext = "";
        public Music()
        {
            InitializeComponent();
        }

        private void Music_Load(object sender, EventArgs e)
        {
            settext = "ThreeHeadedSnake.mp3";
        }
        private void picNext_Click(object sender, EventArgs e)
        {
            if (picThreeHeadedSnake.Visible == true)
            {
                picBrokenLove.Visible = true;
                picThreeHeadedSnake.Visible = false;
                settext = "BrokenLove.mp3";
            }
            else if (picBrokenLove.Visible == true)
            {
                picContact.Visible = true;
                picBrokenLove.Visible = false;
                settext = "Contact.mp3";
            }
            else if (picContact.Visible == true)
            {
                picPickUp.Visible = true;
                picContact.Visible = false;
                settext = "PickItUp.mp3";
            }
            else if (picPickUp.Visible == true)
            {
                picThreeHeadedSnake.Visible = true;
                picPickUp.Visible = false;
                settext = "ThreeHeadedSnake.mp3";
            }
        }

        private void picPrevious_Click(object sender, EventArgs e)
        {
            if (picThreeHeadedSnake.Visible == true)
            {
                picPickUp.Visible = true;
                picThreeHeadedSnake.Visible = false;
                settext = "PickItUp.mp3";
            }
            else if (picPickUp.Visible == true)
            {
                picContact.Visible = true;
                picPickUp.Visible = false;
                settext = "Contact.mp3";
            }
            else if (picContact.Visible == true)
            {
                picBrokenLove.Visible = true;
                picContact.Visible = false;
                settext = "BrokenLove.mp3";
            }
            else if (picBrokenLove.Visible == true)
            {
                picThreeHeadedSnake.Visible = true;
                picBrokenLove.Visible = false;
                settext = "ThreeHeadedSnake.mp3";
            }
        }
    }
}
