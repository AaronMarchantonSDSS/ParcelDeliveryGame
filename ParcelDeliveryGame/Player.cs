using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;

namespace ParcelDeliveryGame
{
    internal class Player
    {
        //Global variables that control aspects of player
        public int x, y;
        public int width =  15;
        public int height = 15;
        public int speed = 12;

        SoundPlayer delivered = new SoundPlayer(Properties.Resources.deliveredSound); //Successful delivery sound

        public Player(int _x, int _y) //Allows x and y values to change with input
        {
            x = _x;
            y = _y;
        }

        public void Move(string direction)
        {
            //Controls direction in which player moves
            if (direction == "right" && x < 1050 - width)
            {
                x += speed;
            }
            else if (direction == "left" && x > 202)
            {
                x += -speed;
            }
            else if (direction == "up" && y > 0)
            {
                y += -speed;
            }
            else if (direction == "down" && y < 450 - height)
            {
                y += +speed;
            }
        }

        public void Collisions()
        {
            //Create Rectangles so player can interact with continents
            Rectangle playerRec = new Rectangle(x, y, width, height);

            Rectangle NARec = new Rectangle(270, 55, 185, 185);
            Rectangle SARec = new Rectangle(360, 235, 125, 185);
            Rectangle EURec = new Rectangle(555, 50, 120, 95);
            Rectangle GLRec = new Rectangle(445, 35, 85, 45);
            Rectangle AF1Rec = new Rectangle(530, 145, 135, 100);
            Rectangle AF2Rec = new Rectangle(610, 245, 100, 110);
            Rectangle ASRec = new Rectangle(680, 35, 275, 195);
            Rectangle OCRec = new Rectangle(870, 310, 155, 105);

            //If statements that check if a player is interacting with a continent
            if (playerRec.IntersectsWith(NARec))
            {
                GameScreen.Collide = "NA"; //Change variable so colour can be accurate

                if (GameScreen.spaceDown == true && GameScreen.targetnumber == 0) //Check for parcel was dropped
                {
                    GameScreen.deliveriesMade ++;

                    delivered.Play();

                    GameScreen.ChooseTarget();
                }
            }
            else if (playerRec.IntersectsWith(SARec))
            {
                GameScreen.Collide = "SA";

                if (GameScreen.spaceDown == true && GameScreen.targetnumber == 1)
                {
                    GameScreen.deliveriesMade++;

                    delivered.Play();

                    GameScreen.ChooseTarget();
                }
            }
            else if (playerRec.IntersectsWith(EURec) || playerRec.IntersectsWith(GLRec))
            {
                GameScreen.Collide = "EU";

                if (GameScreen.spaceDown == true && GameScreen.targetnumber == 2)
                {
                    GameScreen.deliveriesMade++;

                    delivered.Play();

                    GameScreen.ChooseTarget();
                }
            }
            else if (playerRec.IntersectsWith(ASRec))
            {
                GameScreen.Collide = "AS";

                if (GameScreen.spaceDown == true && GameScreen.targetnumber == 4)
                {
                    GameScreen.deliveriesMade++;

                    delivered.Play();

                    GameScreen.ChooseTarget();
                }
            }
            else if (playerRec.IntersectsWith(AF1Rec) || playerRec.IntersectsWith(AF2Rec))
            {
                GameScreen.Collide = "AF";

                if (GameScreen.spaceDown == true && GameScreen.targetnumber == 3)
                {
                    GameScreen.deliveriesMade++;

                    delivered.Play();

                    GameScreen.ChooseTarget();
                }
            }
            else if (playerRec.IntersectsWith(OCRec))
            {
                GameScreen.Collide = "OC";

                if (GameScreen.spaceDown == true && GameScreen.targetnumber == 5)
                {
                    GameScreen.deliveriesMade++;

                    delivered.Play();

                    GameScreen.ChooseTarget();
                }
            }
            else //If player is colliding with any continent
            {
                GameScreen.Collide = "";
            }
        }
    }
}