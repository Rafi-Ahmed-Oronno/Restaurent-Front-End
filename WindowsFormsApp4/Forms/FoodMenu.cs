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
    public partial class FoodMenu : Form
    {
        private Home home;
        private Order order;
        private Inventory inventory;
        private ReadyItem readyItem;
        private Replacement replacement;
        private Form returnForm;
        private Helper help;

        public FoodMenu()
        {
            InitializeComponent();
            this.panel1.BackColor = Color.FromArgb(40, Color.Black);
            this.panel2.BackColor = Color.FromArgb(70, Color.Blue);
            this.panel3.BackColor = Color.FromArgb(100, Color.Wheat);
            
            this.dataGrid.RowTemplate.Height = 100;
            insertData();
        }
        public FoodMenu(Form form)
        {
            InitializeComponent();
            this.panel1.BackColor = Color.FromArgb(40, Color.Black);
            this.panel2.BackColor = Color.FromArgb(70, Color.Blue);
            this.panel3.BackColor = Color.FromArgb(100, Color.Wheat);
            this.dataGrid.RowTemplate.Height = 100;
            returnForm = form;
            insertData();
        }
        public int insertData()
        {
            Image img = Image.FromFile("../../../FoodPicture/Burger.jpg");
            this.dataGrid.Rows.Add("1", "Burger",img, "100");
            return 0;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
           this.WindowState = FormWindowState.Minimized;
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            try
            {
                help = new Helper("Home", this);
                this.Hide();
            }
            catch(Exception ex)
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

        private void btnIneventory_Click(object sender, EventArgs e)
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

        private void btnReadyItem_Click(object sender, EventArgs e)
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

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help localHelp = new Help("FoodMenu");
            localHelp.Show();
        }
    }
}
