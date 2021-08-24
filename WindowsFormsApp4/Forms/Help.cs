using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp4.Forms
{
    public partial class Help : Form
    {
        public Help(string helpName)
        {
            InitializeComponent();
            Transparent();
            // this.Hidepanel();
            if (helpName == "Inventory")
            {
                this.FoodMenu.Hide();
                this.PlaceOrder.Hide();
               
            }
            //else if (helpName == "ReadyItem") this.ReadyItem.Show();
            //else if (helpName == "PlaceOrder") this.PlaceOrder.Show();
            //else if (helpName == "Replacement") this.Replacement.Show();
            //else if (helpName == "FoodMenu") this.FoodMenu.Show();
            //else if (helpName == "Order") this.Order.Show();
            //else MessageBox.Show("Help name not found");

        }
        private void Transparent()
        {
            this.ReadyItem.BackColor = Color.FromArgb(50, Color.NavajoWhite);
            this.PlaceOrder.BackColor = Color.FromArgb(50, Color.NavajoWhite);
            this.Order.BackColor = Color.FromArgb(50, Color.NavajoWhite);
            this.FoodMenu.BackColor = Color.FromArgb(50, Color.NavajoWhite);
            this.Replacement.BackColor = Color.FromArgb(50, Color.NavajoWhite);
            this.Inventory.BackColor = Color.FromArgb(50, Color.NavajoWhite);
        }
        private void Hidepanel()
        {

            this.ReadyItem.Hide();
            this.PlaceOrder.Hide();
            this.FoodMenu.Hide();
            this.Replacement.Hide();
            this.Order.Hide();
            this.Inventory.Hide();
        
        }

       

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void placeOrderBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
