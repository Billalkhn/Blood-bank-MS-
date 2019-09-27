using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Blood_Bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Login ad = new Admin_Login();
           
            if (ad.Verify(textBox1,textBox2) == true)
            {
                this.Hide();
                new admin().Show();
            }
            else if (ad.Verify(textBox1,textBox2) == false)
            {
                MessageBox.Show("Invalid UserName or Password");
            }
            //if (textBox1.Text == "admin"  && textBox2.Text == "admin")
            //{
            //    admin ad = new admin();
            //    this.Hide();
            //    ad.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Please Write Correct Name or Password");
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            guest g = new guest();
            this.Hide();
            g.Show();
        }
    }
}
