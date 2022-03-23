using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REflections
{
    public class PhoneNo
    {
        string number;
        int numberis;



        public PhoneNo(string n,int i)
        {

            number = n;
            numberis = i;

        }
        [NewAttribute("Accesosr", "give Phone Number")]
        public string getnumber()
        {
            return number;
        }
        [NewAttribute("Accesosr","8208508814")]
        public int getNumberId()
        {
            return numberis;
        }
    }
}
