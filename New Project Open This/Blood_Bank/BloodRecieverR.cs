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
    public partial class BloodRecieverR : Form
    {
        public BloodRecieverR()
        {
            InitializeComponent();
            //dataGridView1.Rows.Clear();
            //int NumberOfLines = File.ReadAllLines(@"donorinfo/info.txt").Length;
            //StreamReader sr = new StreamReader(@"donorinfo/info.txt");
            //string[] ListLines = new string[NumberOfLines];
            //for (int i = 0; i < NumberOfLines; i++)
            //{
            //    ListLines[i] = sr.ReadLine();
            //    string[] lines = ListLines[i].Split(',');
            //    //listView1.Items.Add(lines[0] + " " + lines[1] + " " + lines[2] + " " + lines[3] + " " + lines[4] + lines[5]);
            //    if (lines[3] == textBox1.Text)
            //    {
            //        dataGridView1.Rows.Add(lines[0], lines[1], lines[2], lines[3], lines[4], lines[5]);
            //    }

            //}
            //sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bloos_Reciever_Need bs = new Bloos_Reciever_Need();
            bs.reciver(sender, e, dataGridView1, textBox1);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            guest gt = new guest();
            this.Hide();
            gt.Show();
        }
    }
}
