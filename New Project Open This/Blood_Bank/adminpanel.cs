using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Blood_Bank
{
    class adminpanel
    {
        public void admin(DataGridView dataGridView1)
        {
            StreamReader sr = new StreamReader(@"donorinfo/info.txt");
            string allString = sr.ReadToEnd();

            string allData = allString;
            // CHECK BELOW---------------
            int NumberOfLines = File.ReadAllLines(@"donorinfo/info.txt").Length;
            sr.Close();
            StreamReader sr1 = new StreamReader(@"donorinfo/info.txt");
            string[] ListLines = new string[NumberOfLines];
            for (int i = 0; i < NumberOfLines; i++)
            {
                ListLines[i] = sr1.ReadLine();
                string[] lines = ListLines[i].Split(',');
                //listView1.Items.Add(lines[0] + " " + lines[1] + " " + lines[2] + " " + lines[3] + " " + lines[4] + lines[5]);
                dataGridView1.Rows.Add(lines[0], lines[1], lines[2], lines[3], lines[4], lines[5]);
            }

            sr1.Close();

        }

    }
}
