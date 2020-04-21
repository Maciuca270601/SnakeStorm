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
    public partial class frmSnake : Form
    {
        SqlConnection dbConn;
        Random rand; //o variabila de tipul random
        int SnakeScore = 0;
        SolidBrush BlackRussian = new SolidBrush(Color.FromArgb(17,17,17));
        int userID = Meniu.id;
        string name_user = Meniu.name;
        int semfb = LoginFacebook.fb;
        int sem = 1;// pot fi puse diamante pe mapa
        int numberGems = 0;
        WindowsMediaPlayer gameplayer = new WindowsMediaPlayer();
        string songlink = Music.settext;
        
       
      
   

        enum GameBoardFields 
        { 
                Free,
                Snake,
                Bonus,
                Virus,
                Diamond
        };

        enum Directions
        {
                Up,
                Down,
                Left,
                Right
        };

        struct SnakeCoordinates 
        {
            public int x;
            public int y;
        }

        GameBoardFields[,] gameBoardField; // tine minte ce tb sa faca pe board 
        SnakeCoordinates[] snakeXY;   // utilizeaza x si y ul la fiecare pas
        int snakeLength;      // calculeaza lungimea sarpelui
        Directions direction; // tine minte pozitie la fiecare mutare
        Graphics g;   // cu graphics pot sa desenez pe formular


        public frmSnake()
        {
            InitializeComponent();
            gameplayer.URL = songlink;

            gameBoardField = new GameBoardFields[17, 17];
            snakeXY = new SnakeCoordinates[256];
            rand = new Random();
        }
        private void DrawTheWalls()
        {
            for (int i = 1; i <= 16; i++)
            {
                //top and bottom walls
                g.DrawImage(imgList.Images[6], i * 35, 0);
                g.DrawImage(imgList.Images[6], i * 35, 595);
            }

            for (int i = 0; i <= 17; i++)
            {
                //left and right walls
                g.DrawImage(imgList.Images[6], 0, i * 35);
                g.DrawImage(imgList.Images[6], 595, i * 35);
            }
        }

        private void DrawStartSnake()
        {
            //initial snake body and head
            snakeXY[0].x = 8;//snake head
            snakeXY[0].y = 8;
            snakeXY[1].x = 8;//snake first body part
            snakeXY[1].y = 9;
            snakeXY[2].x = 8;//snake second body part
            snakeXY[2].y = 10;
            g.DrawImage(imgList.Images[5], 8 * 35, 8 * 35);//draw snake head
            g.DrawImage(imgList.Images[4], 8 * 35, 9 * 35);//draw snake first body part
            g.DrawImage(imgList.Images[4], 8 * 35, 10 * 35);//draw snake second body part

            gameBoardField[8, 8] = GameBoardFields.Snake;
            gameBoardField[8, 9] = GameBoardFields.Snake;
            gameBoardField[8, 10] = GameBoardFields.Snake;
        }
        
        private void DrawSnakeHead()
        {
            //draw the head
            g.DrawImage(imgList.Images[5], snakeXY[0].x * 35, snakeXY[0].y * 35);
            gameBoardField[snakeXY[0].x, snakeXY[0].y] = GameBoardFields.Snake;
           
        }
        private void GenerateBomb()
        {
            for (int i = 0; i <= 3; i++)
            {
                DrawBomb();
            }
        }

        private void GenerateVirus()
        {
            for(int i=0;i<=3;i++)
            {
                DrawVirus();
            }
        }

        private void frmSnake_Load(object sender, EventArgs e)
        {
            picGameBoard.Image = new Bitmap(630,630);
            g = Graphics.FromImage(picGameBoard.Image);
            g.Clear(Color.FromArgb(17,17,17));
            DrawTheWalls();
            DrawStartSnake();
            GenerateBomb();
            GenerateVirus();
            DrawBonus();
            label3.Parent = pictureBox1;
            label4.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
           
            gameplayer.controls.play();
            


            direction = Directions.Up;
            snakeLength = 3;
            dbConn = new SqlConnection(Properties.Settings.Default.dbConnection);
        }

        private void DrawBonus()
        {
            int x, y;
            var ImageIndex = rand.Next(0, 4);
            do
            {
                x = rand.Next(1, 16);
                y = rand.Next(1, 16);
            } while (gameBoardField[x, y] != GameBoardFields.Free);

            gameBoardField[x, y] = GameBoardFields.Bonus;
            g.DrawImage(imgList.Images[ImageIndex], x * 35, y * 35);
        }
        private void DrawBomb()
        {
            int x, y;
            do
            {
                x = rand.Next(1, 16);
                y = rand.Next(1, 16);
            } while (gameBoardField[x, y] != GameBoardFields.Free);

            gameBoardField[x, y] = GameBoardFields.Snake;
            g.DrawImage(imgList.Images[7], x * 35, y * 35);
        }

        private void DrawDiamond()
        {
            int x, y;
            do
            {
                x = rand.Next(1, 16);
                y = rand.Next(1, 16);
            } while (gameBoardField[x, y] != GameBoardFields.Free);
            gameBoardField[x, y] = GameBoardFields.Diamond;
            g.DrawImage(imgList.Images[9], x * 35, y * 35);
        }

        private void DrawVirus()
        {
            int x, y;
            do
            {
                x = rand.Next(1, 16);
                y = rand.Next(1, 16);
            } while (gameBoardField[x, y] != GameBoardFields.Free);

            gameBoardField[x, y] = GameBoardFields.Virus;
            g.DrawImage(imgList.Images[8], x * 35, y * 35);
        }

        private void Key_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && direction != Directions.Down)
                direction = Directions.Up;
            else if (e.KeyCode == Keys.Down && direction != Directions.Up)
                direction = Directions.Down;
            else if (e.KeyCode == Keys.Left && direction != Directions.Right)
                direction = Directions.Left;
            else if (e.KeyCode == Keys.Right && direction != Directions.Left)
                direction = Directions.Right;
            if (e.KeyCode == Keys.Space)
            {
                timer.Enabled = true;
            }
               
            if (e.KeyCode == Keys.Escape)
                this.Close();

        }
        private void Gameover()
        {
            timer.Enabled = false;
            picGameOver.Visible = true;
            gameplayer.controls.stop();
           

            //if(semfb==0)
            //addCurrentScore();
            
        
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //delete the end of the snake
            g.FillRectangle(BlackRussian, snakeXY[snakeLength - 1].x * 35, snakeXY[snakeLength - 1].y * 35, 35, 35);
            gameBoardField[snakeXY[snakeLength - 1].x, snakeXY[snakeLength - 1].y] = GameBoardFields.Free;

            //move snake field on the position of the previous field
            for (int i = snakeLength; i > 0; i--)
            {
                snakeXY[i].x = snakeXY[i - 1].x;
                snakeXY[i].y = snakeXY[i - 1].y;
            }
            g.DrawImage(imgList.Images[4], snakeXY[0].x * 35, snakeXY[0].y * 35);
            
            //change direction of the head
            switch(direction)
            {
                case Directions.Up:
                    snakeXY[0].y = snakeXY[0].y - 1;
                    break;
                case Directions.Down:
                    snakeXY[0].y = snakeXY[0].y + 1;
                    break;
                case Directions.Left:
                    snakeXY[0].x = snakeXY[0].x - 1;
                    break;
                case Directions.Right:
                    snakeXY[0].x = snakeXY[0].x + 1;
                    break;
            }

            // check if snake hits the wall
            if(snakeXY[0].x<1 || snakeXY[0].x>16 || snakeXY[0].y<1 || snakeXY[0].y>16)
            {
                Gameover();
                picGameBoard.Refresh();
                return;
            }

            // check if the snake hits his own body
            if(gameBoardField[snakeXY[0].x,snakeXY[0].y]==GameBoardFields.Snake)
            {
                Gameover();
                picGameBoard.Refresh();
                return;
            }

            // check if the snake ate a bonus 
            if (gameBoardField[snakeXY[0].x, snakeXY[0].y] == GameBoardFields.Bonus)
            {
                g.DrawImage(imgList.Images[4], snakeXY[snakeLength].x * 35, snakeXY[snakeLength].y * 35);
                gameBoardField[snakeXY[snakeLength].x, snakeXY[snakeLength].y] = GameBoardFields.Snake;
                snakeLength++;
                if (snakeLength < 254)
                    DrawBonus();
                SnakeScore += 100;

            }

            // check if the snake got in a trap --> -300pct
            if(gameBoardField[snakeXY[0].x, snakeXY[0].y] == GameBoardFields.Virus)
            {
                DrawVirus();
                SnakeScore -= 300;
                
            }

            //check if there is any diamond to generate
            if(SnakeScore %300 == 0 && SnakeScore > 0 && sem ==1)
            {
                DrawDiamond();
                sem = 0;
            }

            
            // check if the snake got the diamond --> 1000pct
            if(gameBoardField[snakeXY[0].x, snakeXY[0].y] == GameBoardFields.Diamond)
            {
                SnakeScore += 400;
                sem = 1;
                numberGems++;
                
                

            }
            label3.Text = Convert.ToString(SnakeScore);
            label4.Text = Convert.ToString(numberGems);
            DrawSnakeHead();

            picGameBoard.Refresh(); 
            
        }
            private void addCurrentScore()
            {
                dbConn.Open();
                //string query = "UPDATE  TabelaLogin SET Score=@SnakeScore  WHERE ID = @userID";
                string query = "INSERT INTO TabelaScore(id_user, score , username ) VALUES(@userID , @SnakeScore , @name_user)";
                SqlCommand cmd = new SqlCommand(query, dbConn);
                cmd.Parameters.Add("@SnakeScore", SnakeScore);
                cmd.Parameters.Add("@userID", userID);
                cmd.Parameters.Add("@name_user", name_user);
                cmd.ExecuteNonQuery();

                dbConn.Close();
            }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

