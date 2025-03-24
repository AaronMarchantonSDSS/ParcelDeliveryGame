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
    public partial class MenuScreen : UserControl
    {
        SoundPlayer click = new SoundPlayer(Properties.Resources.buttonSound); //Button sound

        public MenuScreen()
        {
            InitializeComponent();

            gameOverLabel.Text = $"{GameScreen.gameOver}"; //Display if win or loss
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new GameScreen()); //Send player to GameScreen

            click.Play();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Exit Program
        }

        private void instructionsButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new InstructionScreen()); //Send player to InstructionScreen

            click.Play();
        }
    }
}
