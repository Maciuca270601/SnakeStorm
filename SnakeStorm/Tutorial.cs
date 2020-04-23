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
    public partial class Tutorial : Form
    {
        public Tutorial()
        {
            InitializeComponent();
        }


        private void Tutorial_Load(object sender, EventArgs e)
        {
          
        }

        private void picNext_Click(object sender, EventArgs e)
        {
            if (picMovement.Visible == true)
            {
                picBonuses.Visible = true;
                picMovement.Visible = false;
            }
            else if (picBonuses.Visible == true)
            {
                picVirus.Visible = true;
                picBonuses.Visible = false;
            }
            else if (picVirus.Visible == true)
            {
                picBomb.Visible = true;
                picVirus.Visible = false;
            }
            else if (picBomb.Visible == true)
            {
                picDiamond.Visible = true;
                picBomb.Visible = false;
            }
            else if (picDiamond.Visible == true)
            {
                picWallTail.Visible = true;
                picDiamond.Visible = false;
            }
            else if (picWallTail.Visible == true)
            {
                picFacebook.Visible = true;
                picWallTail.Visible = false;
            }
            else if (picFacebook.Visible == true)
            {
                picMovement.Visible = true;
                picFacebook.Visible = false;
            }
        }

        private void picPrevious_Click(object sender, EventArgs e)
        {
            if (picMovement.Visible == true)
            {
                picFacebook.Visible = true;
                picMovement.Visible = false;
            }
            else if (picFacebook.Visible == true)
            {
                picWallTail.Visible = true;
                picFacebook.Visible = false;
            }
            else if (picWallTail.Visible == true)
            {
                picDiamond.Visible = true;
                picWallTail.Visible = false;
            }
            else if (picDiamond.Visible == true)
            {
                picBomb.Visible = true;
                picDiamond.Visible = false;
            }
            else if (picBomb.Visible == true)
            {
                picVirus.Visible = true;
                picBomb.Visible = false;
            }
            else if (picVirus.Visible == true)
            {
                picBonuses.Visible = true;
                picVirus.Visible = false;
            }
            else if (picBonuses.Visible == true)
            {
                picMovement.Visible = true;
                picBonuses.Visible = false;
            }
        }

      
    }
}
