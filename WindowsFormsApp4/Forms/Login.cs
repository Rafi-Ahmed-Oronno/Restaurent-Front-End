using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.CallApi;

namespace WindowsFormsApp4
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.pictureBox1.Visible==true)
            {
                this.pictureBox1.Visible = false;
                this.pictureBox1_1.Visible = true;
            }
            else
            {
                this.pictureBox1_1.Visible = false;
                this.pictureBox1.Visible = true;
            }

            if (this.pictureBox2_0.Visible == true)
            {
                this.pictureBox2_0.Visible = false;
                this.pictureBox2_1.Visible = true;
            }
            else
            {
                this.pictureBox2_1.Visible = false;
                this.pictureBox2_0.Visible = true;
            }


            if (this.pictureBox3_0.Visible == true)
            {
                this.pictureBox3_0.Visible = false;
                this.pictureBox3_1.Visible = true;
            }
            else
            {
                this.pictureBox3_1.Visible = false;
                this.pictureBox3_0.Visible = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private async void btnlogin_Click(object sender, EventArgs e)
        {
            
           /* var res = await loginCall.Login(this.Id.Text,this.password.Text);
            MessageBox.Show(res);
            MessageBox.Show(this.Id.Text, this.password.Text);*/
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
