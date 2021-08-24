using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp4.Help;

namespace WindowsFormsApp4
{
    public partial class Order : Form
    {
        Form returnForm;
        Helper help;
        public Order()
        {
            InitializeComponent();
            this.panel1.BackColor = Color.FromArgb(40, Color.Black);
            //this.panel2.BackColor = Color.FromArgb(70, Color.Blue);
            this.panel3.BackColor = Color.FromArgb(100, Color.Wheat);
            this.btnMinimize.BackColor = Color.FromArgb(60, Color.Black);
            this.btnCross.BackColor = Color.FromArgb(60, Color.Black);
        }
        public Order(Form form)
        {
            InitializeComponent();
            this.panel1.BackColor = Color.FromArgb(40, Color.Black);
            //this.panel2.BackColor = Color.FromArgb(70, Color.Blue);
            this.panel3.BackColor = Color.FromArgb(100, Color.Wheat);
            this.btnMinimize.BackColor = Color.FromArgb(60, Color.Black);
            this.btnCross.BackColor = Color.FromArgb(60, Color.Black);
            this.returnForm = form;
        }

        private void Order_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // this.button1.BackColor = Color.Red;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

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
    }
}
