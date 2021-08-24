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
    public partial class ReadyItem : Form
    {
        private Form returnForm;
        Helper help;
        public ReadyItem()
        {
            InitializeComponent();
            this.panel1.BackColor = Color.FromArgb(40, Color.Black);
            this.panel2.BackColor = Color.FromArgb(70, Color.Blue);
            this.panel4.BackColor = Color.FromArgb(100, Color.Wheat);
            RowStyle rowStyle = new RowStyle(SizeType.AutoSize);
            this.ReadyItemTable.RowStyles.Add(rowStyle);
           // this.ReadyItemTable.Controls.Add(row);
        }
        public ReadyItem(Form form)
        {
            InitializeComponent();
            this.panel1.BackColor = Color.FromArgb(40, Color.Black);
            this.panel2.BackColor = Color.FromArgb(70, Color.Blue);
            this.panel4.BackColor = Color.FromArgb(100, Color.Wheat);
            this.returnForm = form;
            RowStyle rowStyle = new RowStyle(SizeType.AutoSize);
            this.ReadyItemTable.RowStyles.Add(rowStyle);
            // this.ReadyItemTable.Controls.Add(row);
        }
        private void btnBack_Click(object sender, EventArgs e)
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            try
            {
                help = new Helper("Home", this);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form Not Found");
            }
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

        private void btnOrder_Click(object sender, EventArgs e)
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

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help localHelp = new Help("ReadyItem");
            localHelp.Show();
        }
    }
}
