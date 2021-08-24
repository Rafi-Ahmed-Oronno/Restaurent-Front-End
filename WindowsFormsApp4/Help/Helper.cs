using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp4.Forms;

namespace WindowsFormsApp4.Help
{
    class Helper
    {
        Form form;
        public Helper(string name,Form form)
        {
            this.form = form;
            if (name == "Inventory") Inventory();
            else if (name == "Replacement") Replacement();
            else if (name == "Home") Home();
            else if (name == "Order") Order();
            else if (name == "ReadyItem") ReadyItem();
            else if (name == "FoodMenu") FoodMenu();
            else if (name == "PlaceOrder") PlaceOrder();
            else { this.form = null; }
            
        }
        public void Replacement()
        {
            Replacement replacement = new Replacement();
            Back = this.form;
            replacement.Show();
        }
        private void Inventory()
        {
            Inventory inventory = new Inventory();
            Back = this.form;
            inventory.Show();
        }
        private void Home()
        {
            Home home = new Home();
            Back = this.form;
            home.Show();
        }
        private void Order()
        {
            Order order = new Order();
            Back = this.form;
            order.Show();
        }
        private void ReadyItem()
        {
            ReadyItem readyItem = new ReadyItem();
            Back = this.form;
            readyItem.Show();
        }
        private void FoodMenu()
        {
            FoodMenu foodMenu = new FoodMenu();
            Back = this.form;
            foodMenu.Show();
        }
        private void PlaceOrder()
        {
            PlaceOrder placeOrder = new PlaceOrder();
            Back = this.form;
            placeOrder.Show();

        }
        public static Form Back { get; set; }
    }
}
