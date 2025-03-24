using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ParcelDeliveryGame
{
    public partial class GameScreen : UserControl
    {
        //Create global variables
        public static bool goingLeft, goingRight, goingUp, goingDown, spaceDown;
        public static int targetnumber;
        public static int deliveriesMade = 0;
        public static string gameOver;
        public static string Collide = "";

        //Created Brushes
        Brush lightGreenBrush = new SolidBrush(Color.MediumSeaGreen);
        Brush GreenBrush = new SolidBrush(Color.MediumAquamarine);
        Brush playerBrush = new SolidBrush(Color.Red);

        //Pollygons that make up the continents
        PointF[] NA;
        PointF[] SA;
        PointF[] EU;
        PointF[] GL;
        PointF[] AF;
        PointF[] MG;
        PointF[] AS;
        PointF[] AU;
        PointF[] NZ1;
        PointF[] NZ2;

        Player player = new Player(220, 450 / 2); //Where player will spawn

        static Random randGen = new Random(); //Random number generator

        static Label tempLabel; //Middle man for targetLabel

        public GameScreen()
        {
            InitializeComponent();

            //Set up the game screen
            goingLeft = false;
            goingRight = false;
            goingUp = false;
            goingDown = false;
            spaceDown = false;

            stopwatch.Start();

            tempLabel = targetLabel; //Move info to other label
            deliveriesMade = 0;

            ChooseTarget();

            NorthAmerica();
            SouthAmerica();
            Europe();
            Africa();
            Asia();
            Oceania();
        }

        public void NorthAmerica()
        {
            //Gathered points that make up North America
            NA = new PointF[23];
            NA[0] = new PointF(280, 55);
            NA[1] = new PointF(410, 55);
            NA[2] = new PointF(380, 80);
            NA[3] = new PointF(395, 95);
            NA[4] = new PointF(410, 80);
            NA[5] = new PointF(440, 80);
            NA[6] = new PointF(455, 110);
            NA[7] = new PointF(420, 120);
            NA[8] = new PointF(375, 160);
            NA[9] = new PointF(370, 180);
            NA[10] = new PointF(355, 165);
            NA[11] = new PointF(325, 170);
            NA[12] = new PointF(330, 200);
            NA[13] = new PointF(345, 195);
            NA[14] = new PointF(365, 240);
            NA[15] = new PointF(300, 195);
            NA[16] = new PointF(285, 175);
            NA[17] = new PointF(285, 190);
            NA[18] = new PointF(270, 145);
            NA[19] = new PointF(290, 125);
            NA[20] = new PointF(290, 85);
            NA[21] = new PointF(225, 90);
            NA[22] = new PointF(280, 55);
        }

        public void SouthAmerica()
        {
            //Gathered points that make up South America
            SA = new PointF[15];
            SA[0] = new PointF(370, 240);
            SA[1] = new PointF(435, 235);
            SA[2] = new PointF(445, 260);
            SA[3] = new PointF(485, 275);
            SA[4] = new PointF(470, 320);
            SA[5] = new PointF(455, 335);
            SA[6] = new PointF(450, 355);
            SA[7] = new PointF(425, 375);
            SA[8] = new PointF(425, 405);
            SA[9] = new PointF(435, 425);
            SA[10] = new PointF(390, 390);
            SA[11] = new PointF(390, 320);
            SA[12] = new PointF(380, 310);
            SA[13] = new PointF(360, 265);
            SA[14] = new PointF(370, 240);
        }

        public void Europe()
        {
            //Gathered points that make up mainland Europe
            EU = new PointF[30];
            EU[0] = new PointF(615, 55);
            EU[1] = new PointF(640, 50);
            EU[2] = new PointF(665, 60);
            EU[3] = new PointF(675, 125);
            EU[4] = new PointF(655, 115);
            EU[5] = new PointF(650, 130);
            EU[6] = new PointF(640, 130);
            EU[7] = new PointF(635, 150);
            EU[8] = new PointF(625, 130);
            EU[9] = new PointF(610, 120);
            EU[10] = new PointF(620, 130);
            EU[11] = new PointF(615, 140);
            EU[12] = new PointF(600, 120);
            EU[13] = new PointF(565, 145);
            EU[14] = new PointF(555, 145);
            EU[15] = new PointF(555, 125);
            EU[16] = new PointF(570, 125);
            EU[17] = new PointF(570, 110);
            EU[18] = new PointF(595, 95);
            EU[19] = new PointF(595, 85);
            EU[20] = new PointF(600, 95);
            EU[21] = new PointF(630, 90);
            EU[22] = new PointF(640, 80);
            EU[23] = new PointF(630, 75);
            EU[24] = new PointF(630, 60);
            EU[25] = new PointF(615, 85);
            EU[26] = new PointF(605, 80);
            EU[27] = new PointF(595, 80);
            EU[28] = new PointF(595, 70);
            EU[29] = new PointF(615, 55);

            //Gathered points that make up Greenland (map looks wrong without)
            GL = new PointF[8];
            GL[0] = new PointF(445, 40);
            GL[1] = new PointF(530, 35);
            GL[2] = new PointF(515, 50);
            GL[3] = new PointF(485, 65);
            GL[4] = new PointF(470, 80);
            GL[5] = new PointF(460, 70);
            GL[6] = new PointF(460, 50);
            GL[7] = new PointF(445, 40);
        }

        public void Africa()
        {
            //Gathered points that make up mainland Africa
            AF = new PointF[24];
            AF[0] = new PointF(550, 150);
            AF[1] = new PointF(605, 145);
            AF[2] = new PointF(605, 160);
            AF[3] = new PointF(625, 165);
            AF[4] = new PointF(635, 160);
            AF[5] = new PointF(665, 165);
            AF[6] = new PointF(660, 170);
            AF[7] = new PointF(660, 175);
            AF[8] = new PointF(690, 225);
            AF[9] = new PointF(710, 225);
            AF[10] = new PointF(685, 270);
            AF[11] = new PointF(685, 300);
            AF[12] = new PointF(665, 310);
            AF[13] = new PointF(665, 345);
            AF[14] = new PointF(650, 360);
            AF[15] = new PointF(620, 360);
            AF[16] = new PointF(605, 310);
            AF[17] = new PointF(610, 295);
            AF[18] = new PointF(605, 275);
            AF[19] = new PointF(600, 240);
            AF[20] = new PointF(560, 245);
            AF[21] = new PointF(530, 240);
            AF[22] = new PointF(530, 190);
            AF[23] = new PointF(560, 150);

            //Gathered points that make up Madagascar
            MG = new PointF[5];
            MG[0] = new PointF(710, 295);
            MG[1] = new PointF(695, 335);
            MG[2] = new PointF(685, 315);
            MG[3] = new PointF(690, 305);
            MG[4] = new PointF(710, 295);
        }

        public void Asia()
        {
            //Gathered points that make up Asia
            AS = new PointF[54];
            AS[0] = new PointF(760, 35);
            AS[1] = new PointF(835, 50);
            AS[2] = new PointF(955, 60);
            AS[3] = new PointF(945, 70);
            AS[4] = new PointF(955, 70);
            AS[5] = new PointF(950, 80);
            AS[6] = new PointF(935, 80);
            AS[7] = new PointF(945, 105);
            AS[8] = new PointF(930, 95);
            AS[9] = new PointF(930, 75);
            AS[10] = new PointF(895, 80);
            AS[11] = new PointF(885, 95);
            AS[12] = new PointF(905, 105);
            AS[13] = new PointF(910, 125);
            AS[14] = new PointF(900, 135);
            AS[15] = new PointF(905, 155);
            AS[16] = new PointF(890, 140);
            AS[17] = new PointF(870, 140);
            AS[18] = new PointF(895, 170);
            AS[19] = new PointF(885, 185);
            AS[20] = new PointF(850, 200);
            AS[21] = new PointF(870, 220);
            AS[22] = new PointF(855, 235);
            AS[23] = new PointF(845, 220);
            AS[24] = new PointF(845, 230);
            AS[25] = new PointF(855, 250);
            AS[26] = new PointF(840, 235);
            AS[27] = new PointF(835, 215);
            AS[28] = new PointF(825, 210);
            AS[29] = new PointF(815, 190);
            AS[30] = new PointF(790, 215);
            AS[31] = new PointF(790, 230);
            AS[32] = new PointF(780, 235);
            AS[33] = new PointF(770, 195);
            AS[34] = new PointF(760, 195);
            AS[35] = new PointF(750, 180);
            AS[36] = new PointF(725, 175);
            AS[37] = new PointF(705, 165);
            AS[38] = new PointF(710, 185);
            AS[39] = new PointF(725, 180);
            AS[40] = new PointF(735, 190);
            AS[41] = new PointF(695, 220);
            AS[42] = new PointF(670, 175);
            AS[43] = new PointF(670, 150);
            AS[44] = new PointF(645, 150);
            AS[45] = new PointF(645, 135);
            AS[46] = new PointF(655, 135);
            AS[47] = new PointF(660, 120);
            AS[48] = new PointF(680, 135);
            AS[49] = new PointF(675, 60);
            AS[50] = new PointF(715, 55);
            AS[51] = new PointF(720, 45);
            AS[52] = new PointF(740, 45);
            AS[53] = new PointF(760, 35);
        }

        public void Oceania()
        {
            //Gathered points that make up Australia
            AU = new PointF[17];
            AU[0] = new PointF(955, 310);
            AU[1] = new PointF(960, 320);
            AU[2] = new PointF(965, 340);
            AU[3] = new PointF(975, 355);
            AU[4] = new PointF(955, 390);
            AU[5] = new PointF(930, 395);
            AU[6] = new PointF(930, 390);
            AU[7] = new PointF(915, 380);
            AU[8] = new PointF(870, 385);
            AU[9] = new PointF(875, 350);
            AU[10] = new PointF(910, 320);
            AU[11] = new PointF(920, 320);
            AU[12] = new PointF(930, 310);
            AU[13] = new PointF(940, 315);
            AU[14] = new PointF(940, 325);
            AU[15] = new PointF(950, 325);
            AU[16] = new PointF(955, 310);

            //Gathered points that make up upper New Zealand
            NZ1 = new PointF[5];
            NZ1[0] = new PointF(1005, 400);
            NZ1[1] = new PointF(985, 410);
            NZ1[2] = new PointF(980, 415);
            NZ1[3] = new PointF(990, 415);
            NZ1[4] = new PointF(1005, 400);

            //Gathered points that make up lower New Zealand
            NZ2 = new PointF[7];
            NZ2[0] = new PointF(1020, 380);
            NZ2[1] = new PointF(1020, 390);
            NZ2[2] = new PointF(1010, 395);
            NZ2[3] = new PointF(1010, 400);
            NZ2[4] = new PointF(1025, 390);
            NZ2[5] = new PointF(1020, 390);
            NZ2[6] = new PointF(1020, 380);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //Code that allows game to be played
            #region move code
            //Decides if player movement is on or not
            if (goingRight == true)
            {
                player.Move("right");
            }

            if (goingLeft == true)
            {
                player.Move("left");
            }

            if (goingUp == true)
            {
                player.Move("up");
            }

            if (goingDown == true)
            {
                player.Move("down");
            }
            #endregion

            player.Collisions();

            deliveriesMadeLabel.Text = $"{deliveriesMade}";

            PlayerWin();

            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //Drawing continents on GameScreen and deciding which colour to draw based on if player is colliding with the continent
            if (Collide == "NA")
            {
                e.Graphics.FillPolygon(GreenBrush, NA);
            }
            else
            {
                e.Graphics.FillPolygon(lightGreenBrush, NA);
            }

            if (Collide == "SA")
            {
                e.Graphics.FillPolygon(GreenBrush, SA);
            }
            else
            {
                e.Graphics.FillPolygon(lightGreenBrush, SA);
            }

            if (Collide == "EU")
            {
                e.Graphics.FillPolygon(GreenBrush, EU);
                e.Graphics.FillPolygon(GreenBrush, GL);
            }
            else
            {
                e.Graphics.FillPolygon(lightGreenBrush, EU);
                e.Graphics.FillPolygon(lightGreenBrush, GL);
            }

            if (Collide == "AF")
            {
                e.Graphics.FillPolygon(GreenBrush, AF);
                e.Graphics.FillPolygon(GreenBrush, MG);
            }
            else
            {
                e.Graphics.FillPolygon(lightGreenBrush, AF);
                e.Graphics.FillPolygon(lightGreenBrush, MG);
            }

            if (Collide == "AS")
            {
                e.Graphics.FillPolygon(GreenBrush, AS);
            }
            else
            {
                e.Graphics.FillPolygon(lightGreenBrush, AS);
            }

            if (Collide == "OC")
            {
                e.Graphics.FillPolygon(GreenBrush, AU);
                e.Graphics.FillPolygon(GreenBrush, NZ1);
                e.Graphics.FillPolygon(GreenBrush, NZ2);
            }
            else
            {
                e.Graphics.FillPolygon(lightGreenBrush, AU);
                e.Graphics.FillPolygon(lightGreenBrush, NZ1);
                e.Graphics.FillPolygon(lightGreenBrush, NZ2);
            }

            //Draw the player
            e.Graphics.FillRectangle(playerBrush, player.x, player.y, player.width, player.height);
        }

        private void stopwatch_Tick(object sender, EventArgs e)
        {
            //If run out of time and lose
            gameOver = "You Lost!!! (Out of Time)";

            SoundPlayer lose = new SoundPlayer(Properties.Resources.loseSound); //Lose sound
            lose.Play();

            gameTimer.Stop();
            stopwatch.Stop();

            Form1.ChangeScreen(this, new MenuScreen());
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //Sets a key to no longer be pushed
                switch (e.KeyCode)
                {
                case Keys.Left:
                    goingLeft = false;
                    break;
                case Keys.Right:
                    goingRight = false;
                    break;
                case Keys.Up:
                    goingUp = false;
                    break;
                case Keys.Down:
                    goingDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
                case Keys.C:
                    goingLeft = false;
                    break;
                case Keys.X:
                    goingRight = false;
                    break;
                case Keys.V:
                    goingUp = false;
                    break;
                case Keys.Z:
                    goingDown = false;
                    break;
                }
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //Decides if/which key is pushed down
                switch (e.KeyCode)
                {
                case Keys.Left:
                    goingLeft = true;
                    break;
                case Keys.Right:
                    goingRight = true;
                    break;
                case Keys.Up:
                    goingUp = true;
                    break;
                case Keys.Down:
                    goingDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                case Keys.C:
                    goingLeft = true;
                    break;
                case Keys.X:
                    goingRight = true;
                    break;
                case Keys.V:
                    goingUp = true;
                    break;
                case Keys.Z:
                    goingDown = true;
                    break;
            }
        }

        public static void ChooseTarget()
        {
            //Chooses a random target
            targetnumber = randGen.Next(6); //Choose random number

            //Assign random number to target continent
            if (targetnumber == 0)
            {
                tempLabel.Text = "North America"; //Display chosen continent
            }
            else if (targetnumber == 1)
            {
                tempLabel.Text = "South America";
            }
            else if (targetnumber == 2)
            {
                tempLabel.Text = "Europe";
            }
            else if (targetnumber == 3)
            {
                tempLabel.Text = "Africa";
            }
            else if (targetnumber == 4)
            {
                tempLabel.Text = "Asia";
            }
            else if (targetnumber == 5)
            {
                tempLabel.Text = "Oceania";
            }
        }

        private void PlayerWin()
        {
            //If player wins
            if (deliveriesMade == 3)
            {
                gameOver = "You Win!!!";

                SoundPlayer win = new SoundPlayer(Properties.Resources.winSound); //Win sound
                win.Play();

                gameTimer.Stop();
                stopwatch.Stop();

                Form1.ChangeScreen(this, new MenuScreen());
            }
        }
    }
}