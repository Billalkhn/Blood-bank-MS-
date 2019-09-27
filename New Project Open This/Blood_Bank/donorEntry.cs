using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Blood_Bank
{
    class donorEntry
    {
        private int age;
        public void DonorEntry(TextBox a, TextBox b, TextBox d, ComboBox e, ComboBox f, ComboBox g)
        {
            if (int.Parse(d.Text) >= 18)
            {
                age = int.Parse(d.Text);
            }
            else
            {
                MessageBox.Show("Invalide age");
            }
            string combocity = e.Text;
            string combobloodgroup = f.Text;
            string combogender = g.Text;
           
            StreamWriter sw = new StreamWriter(@"C:\Users\burha\OneDrive\Desktop\Blood Project\Blood_Bank\Blood_Bank\bin\Debug\donorinfo\" + "info" + ".txt", true);
            sw.WriteLine(a.Text
                + "," + b.Text + "," + e.Text + "," + f.Text + "," + age + "," + g.Text);
            //sw.WriteLine("Name: " + a.Text);
            //sw.WriteLine("Phone Number: "+ b.Text);
            //sw.WriteLine("City: " + e.Text);
            //sw.WriteLine("Blood Group: " + f.Text);
            //sw.WriteLine("Gender: " + g.Text);


            //bloodgroup gender age
            sw.Close();
                        
            
        }
        public bool textcomboCheck(TextBox a, TextBox b, TextBox d, ComboBox e, ComboBox f, ComboBox g)
        {
            if (a.Text == " " || b.Text == " " || d.Text == " " || e.Text == "" || f.Text == " " || g.Text == " ")
            {
                MessageBox.Show("Please Fill All Forms");

            }
            else if (a.Text != "" && b.Text == "" && d.Text == "" && e.Text == "" && f.Text == "" && g.Text == "")
            {
                MessageBox.Show("baqi info batao !!!!");
            }
            else if (a.Text == "" && b.Text != "" && d.Text == "" && e.Text == "" && f.Text == "" && g.Text == "")
            {
                MessageBox.Show("baqi info batao !!!!");
            }
            else if (a.Text == "" && b.Text == "" && d.Text != "" && e.Text == "" && f.Text == "" && g.Text == "")
            {
                MessageBox.Show("baqi info batao !!!!");
            }
            else if (a.Text == "" && b.Text == "" && d.Text == "" && e.Text != "" && f.Text == "" && g.Text == "")
            {
                MessageBox.Show("baqi info batao !!!!");
            }
            else if (a.Text == "" && b.Text == "" && d.Text == "" && e.Text == "" && f.Text != "" && g.Text == "")
            {
                MessageBox.Show("baqi info batao !!!!");
            }
            else if (a.Text == "" && b.Text == "" && d.Text == "" && e.Text == "" && f.Text == "" && g.Text != "")
            {
                MessageBox.Show("baqi info batao !!!!");
            }
            else if (a.Text != "" && b.Text != "" && d.Text == "" && e.Text == "" && f.Text == "" && g.Text == "")
            {
                MessageBox.Show("baqi info batao !!!!");
            }

            else
            {
                MessageBox.Show("Donor Info Added!");
                return true;
            }
            return false;
        }
      
    }
}
