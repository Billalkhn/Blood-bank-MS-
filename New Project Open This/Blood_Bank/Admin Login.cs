using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Blood_Bank
{
    class Admin_Login : AdminUP
    {
       public bool value = false;
        public bool Verify(TextBox a, TextBox b)
        {
            if (a.Text == Admin_U)
            {
                if (b.Text == Admin_P)
                {
                    value = true;
                }
            }
            else
            {
                value = false;
            }
            return value;
        }
        
    }
}
