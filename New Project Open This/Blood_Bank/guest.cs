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
    public partial class guest : Form
    {
        public guest()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About_us ab = new About_us();
            ab.Show();
        }

        private void btnBloodDoner_Click(object sender, EventArgs e)
        {
          
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm1 = new Form1();
            this.Close();
            fm1.Show();
        }

        private void guest_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bloodDonerInfo brr = new bloodDonerInfo();
            this.Close();
            brr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BloodRecieverR br = new BloodRecieverR();
            this.Hide();
            br.Show();
        }
    }
}
