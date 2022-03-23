using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REflections
{
    public class LastName
    {
        string name;
        string nameis;


        public LastName(string n,string i)
        {

            name = n;
            nameis = i;

        }
        [NewAttribute("Accesosr", "give Last name")]
        public string getname()
        {
            return name;
        }
        [NewAttribute("Accesosr", "Chitruk")]
        public string getNameId()
        {
            return nameis;
        }
    }
}
