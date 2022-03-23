using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REflections
{
    public class FirsttName
    {
        string name;
        string nameis;
        

        public FirsttName(string n,string i)
        {
            
        name = n;
            nameis = i;
            
        }
        [NewAttribute("Accesosr","give first name")]
        public string getname()
        { 
            return name;
        }
        [NewAttribute("Accesosr", "pratik")]
        public string getnameId()
        {
            return nameis;
        }

    }
}
