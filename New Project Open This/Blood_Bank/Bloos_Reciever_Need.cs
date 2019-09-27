using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Blood_Bank
{
    class Bloos_Reciever_Need
    {
        public void reciver(object sender, EventArgs e, DataGridView dataGridView1, TextBox textBox1)
        {
            dataGridView1.Rows.Clear();
            int NumberOfLines = File.ReadAllLines(@"donorinfo/info.txt").Length;
            StreamReader sr = new StreamReader(@"donorinfo/info.txt");
            string[] ListLines = new string[NumberOfLines];
            for (int i = 0; i < NumberOfLines; i++)
            {
                ListLines[i] = sr.ReadLine();
                string[] lines = ListLines[i].Split(',');
                //listView1.Items.Add(lines[0] + " " + lines[1] + " " + lines[2] + " " + lines[3] + " " + lines[4] + lines[5]);
                if (lines[3] == textBox1.Text)
                {
                    dataGridView1.Rows.Add(lines[0], lines[1], lines[2], lines[3], lines[4], lines[5]);
                }

            }
            sr.Close();
        }
    }
}
