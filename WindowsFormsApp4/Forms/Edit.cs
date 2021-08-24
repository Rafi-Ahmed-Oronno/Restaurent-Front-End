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
    public partial class Edit : Form
    {
        Form returnForm;
        Helper help;
        public Edit()
        {
            InitializeComponent();
            this.panel1.BackColor = Color.FromArgb(40, Color.Black);
            this.panel2.BackColor = Color.FromArgb(60, Color.White);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (dialog.ShowDialog()==System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    img.ImageLocation = imageLocation;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("An error was occured"+ex);
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
    }
}
