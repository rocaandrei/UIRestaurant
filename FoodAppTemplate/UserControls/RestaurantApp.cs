using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodAppTemplate
{
    public partial class RestaurantApp : Form
    {
        public RestaurantApp()
        {
            InitializeComponent();
            MoveSidePanel(HomeButton);
            firstCustomControl1.BringToFront();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(HomeButton);
            firstCustomControl1.BringToFront();
        }

        private void EatInButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(EatInButton);
            secondUserControl1.BringToFront();
        }

        private void CollectionButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(CollectionButton);
            //DO Something...
        }

        private void DeliveryButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(DeliveryButton);
            //Do Something...
        }

        private void TakeAwayButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(TakeAwayButton);
            //Do something...
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(PaymentButton);
            //Do Something...
        }

        private void CustomersButtons_Click(object sender, EventArgs e)
        {
            MoveSidePanel(CustomersButtons);
        }
        /// <summary>
        /// This method will animate the SidePannel set on buttons
        /// </summary>
        /// <param name="nextButton"></param>
        private void MoveSidePanel(Button nextButton)
        {
            SidePannelButton.Height = nextButton.Height;
            SidePannelButton.Top = nextButton.Top;
        }

    }
}
