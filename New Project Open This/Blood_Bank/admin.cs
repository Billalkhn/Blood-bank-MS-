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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm1 = new Form1();
            this.Close();
            fm1.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            recieverinfo ri = new recieverinfo();
            ri.recieverentry(textBoxnameR,textBoxphoneR,comboBoxgenderR,comboBoxcityR,comboBoxbdgroupR);
            MessageBox.Show("Reviver Added!");
            dataGridView2.Rows.Add(textBoxnameR.Text, textBoxphoneR.Text, comboBoxgenderR.Text, comboBoxcityR.Text, comboBoxbdgroupR.Text);
            //int NumberOfLines = File.ReadAllLines(@"donorinfo/Recieverinfo.txt").Length;
            //StreamReader sr = new StreamReader(@"donorinfo/Recieverinfo.txt");
            //string[] ListLines = new string[NumberOfLines];
            //for (int i = 0; i < NumberOfLines; i++)
            //{
            //    ListLines[i] = sr.ReadLine();
            //    string[] lines = ListLines[i].Split(',');
            //    //listView1.Items.Add(lines[0] + " " + lines[1] + " " + lines[2] + " " + lines[3] + " " + lines[4] + lines[5]);
            //    dataGridView2.Rows.Add(lines[0], lines[1], lines[2] ,lines[3], lines[4]);
            //}

            //sr.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void admin_Load(object sender, EventArgs e)
        {
            adminpanel adp = new adminpanel();
            adp.admin(dataGridView1);

        //    StreamReader sr = new StreamReader(@"donorinfo/info.txt");
        //    string allString = sr.ReadToEnd();

        //    string allData = allString;
        //   // CHECK BELOW---------------
        //   int NumberOfLines = File.ReadAllLines(@"donorinfo/info.txt").Length;
        //    sr.Close();
        //    StreamReader sr1 = new StreamReader(@"donorinfo/info.txt");
        //    string[] ListLines = new string[NumberOfLines];
        //    for (int i = 0; i < NumberOfLines; i++)
        //    {
        //        ListLines[i] = sr1.ReadLine();
        //        string[] lines = ListLines[i].Split(',');
        //        //listView1.Items.Add(lines[0] + " " + lines[1] + " " + lines[2] + " " + lines[3] + " " + lines[4] + lines[5]);
        //        dataGridView1.Rows.Add(lines[0], lines[1], lines[2] , lines[3], lines[4], lines[5]);
        //    }

        //    sr1.Close();
            // CHECK ABOVE--------------------
            //while (1==1)\\
            //{
            //    if (sr.ReadLine() != null)
            //    {


            //        string record = sr.ReadLine();
            //        string[] splitArr = record.Split(',');
            //    }


            //}


            //ListViewItem k = new ListViewItem(sr.ReadLine());



            //k.SubItems.Add(sr.ReadLine());
            //k.SubItems.Add(sr.ReadLine());
            //k.SubItems.Add(sr.ReadLine());
            //k.SubItems.Add(sr.ReadLine());
            //k.SubItems.Add(sr.ReadLine());
            //listView1.Items.Add(k);
            //k = new ListViewItem(sr.ReadLine());
            //k.SubItems.Add(sr.ReadLine());
            //k.SubItems.Add(sr.ReadLine());
            //k.SubItems.Add(sr.ReadLine());
            //k.SubItems.Add(sr.ReadLine());
            //k.SubItems.Add(sr.ReadLine());
            //listView1.Items.Add(k);
            //k = new ListViewItem(sr.ReadLine());
            //k.SubItems.Add(sr.ReadLine());
            //k.SubItems.Add(sr.ReadLine());
            //k.SubItems.Add(sr.ReadLine());
            //k.SubItems.Add(sr.ReadLine());
            //k.SubItems.Add(sr.ReadLine());
            //listView1.Items.Add(k);
            //sr.Close();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            guest gt = new guest();
            this.Hide();
            gt.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
