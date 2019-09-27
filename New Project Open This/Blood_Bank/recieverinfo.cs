using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Blood_Bank
{
    class recieverinfo
    {
        public void recieverentry(TextBox name,TextBox phone,ComboBox gend,ComboBox ct,ComboBox bdgroup)
        {
            string combogend = gend.Text;
            string comboct = ct.Text;
            string combobdgroup = bdgroup.Text;

            StreamWriter sw = new StreamWriter(@"C:\Users\burha\OneDrive\Desktop\Blood Project\Blood_Bank\Blood_Bank\bin\Debug\donorinfo\" + "Recieverinfo" + ".txt", true);
            sw.WriteLine(name.Text+","+phone.Text+","+gend.SelectedItem+"," + bdgroup.SelectedItem+"," + ct.SelectedItem);
            sw.Close();

           // sw.WriteLine(a.Text+","+b.Text+","+e.Text + ","+f.Text+","+d.Text+","+g.Text);
            //
            //gender city bdgroup
        }
    }
}
