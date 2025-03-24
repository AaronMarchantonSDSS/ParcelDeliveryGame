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
    public partial class InstructionScreen : UserControl
    {
        public InstructionScreen()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Exit program
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new MenuScreen()); //Send player to MenuScreen

            SoundPlayer click = new SoundPlayer(Properties.Resources.buttonSound); //Button sound
            click.Play();
        }
    }
}
