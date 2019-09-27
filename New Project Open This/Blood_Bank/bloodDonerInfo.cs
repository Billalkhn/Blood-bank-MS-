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
    public partial class bloodDonerInfo : Form
    {
        public bloodDonerInfo()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            guest gst = new guest();
            this.Close();
            gst.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            //StreamWriter sw = new StreamWriter("info.txt",true);
            //sw.WriteLine(textBox1.Text);
            //sw.WriteLine(comboBox2.Text);
            //sw.WriteLine(textBox2.Text);
            //sw.WriteLine(comboBox1.Text);
            //sw.WriteLine(comboBox3.Text);
            //sw.Close();
            donorEntry de =new donorEntry();
            de.DonorEntry(textBox1, textBox2, textBox4, comboBox1, comboBox2, comboBox3);
            
            if (de.textcomboCheck(textBox1, textBox2, textBox4, comboBox1, comboBox2, comboBox3))
            {
                BloodNeedD bn = new BloodNeedD();
                this.Hide();
                bn.Show();
            }
            

        }

        private void bloodDonerInfo_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
