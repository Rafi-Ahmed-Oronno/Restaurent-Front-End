using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp4.Help;

namespace WindowsFormsApp4.Forms
{
    public partial class Home : Form
    {
        Helper help;
        Form returnForm;
        public Home()
        {
            InitializeComponent();
            this.panel1.BackColor = Color.FromArgb(40, Color.Black);
            this.panel2.BackColor = Color.FromArgb(70, Color.White);
        }
        public Home(Form form)
        {
            InitializeComponent();
            this.panel1.BackColor = Color.FromArgb(40, Color.Black);
            this.panel2.BackColor = Color.FromArgb(70, Color.White);
            this.returnForm = form;
        }
        private void btnReplacement_Click(object sender, EventArgs e)
        {
            try
            {
                help = new Helper("Replacement", this);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form Not Found");
            }
        }
        private void btnCross_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnFoodmenu_Click(object sender, EventArgs e)
        {
            try
            {
                help = new Helper("FoodMenu", this);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form Not Found");
            }
        }
        private void btnInventory_Click(object sender, EventArgs e)
        {
            try
            {
                help = new Helper("Inventory", this);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form Not Found");
            }
        }
        private void btnOrder_Click_1(object sender, EventArgs e)
        {
            try
            {
                help = new Helper("Order", this);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form Not Found");
            }
        }
        private void btnPlaceorder_Click(object sender, EventArgs e)
        {
            try
            {
                help = new Helper("PlaceOrder", this);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form Not Found");
            }
        }
        private void btnReadyitem_Click_1(object sender, EventArgs e)
        {
            try
            {
                help = new Helper("ReadyItem", this);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form Not Found");
            }
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            if (Helper.Back == null)
            {
                MessageBox.Show("History is empty");
            }
            else
            {
                try
                {
                    this.returnForm = Helper.Back;
                    Helper.Back = this;
                    this.returnForm.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("exception in back");
                }
            }
        }
    }
}
