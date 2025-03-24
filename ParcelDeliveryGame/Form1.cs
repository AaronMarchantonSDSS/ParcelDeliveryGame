//Aaron Marchanton
//March 21, 2025
//Parcel Delivery Game

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcelDeliveryGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Sets up proportions of new screens and adds them to list
            MenuScreen ms = new MenuScreen();
            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
            this.Controls.Add(ms);
        }

        public static void ChangeScreen(object sender, UserControl next)
        {
            //Sends you to desired screen
            Form f;

            if (sender is Form)
            {
                f = (Form)sender;
            }
            else
            {
                UserControl current = (UserControl)sender;
                f = current.FindForm();
                f.Controls.Remove(current);
            }

            next.Location = new Point((f.ClientSize.Width - next.Width) / 2, (f.ClientSize.Height - next.Height) / 2);
            f.Controls.Add(next);

            next.Focus();
        }
    }
}
