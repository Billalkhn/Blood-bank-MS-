using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Blood_Bank
{
    public partial class BloodNeedD : Form
    {
        public BloodNeedD()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            guest gt = new guest();
            this.Close();
            gt.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Bloos_Reciever_Need bs = new Bloos_Reciever_Need();
            bs.reciver(sender, e, dataGridView2, textBox1);
        }
    }
}
