using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REflections
{
   public class PasswordUpperCase
    {
        string password;
        string passwordis;


        public PasswordUpperCase(string e, string i)
        {

            password = e;
            passwordis = i;

        }
        [NewAttribute("Accesosr", "give Password")]
        public string getPassword()
        {
            return password;
        }
        [NewAttribute("Accesosr", "Pratik@123")]
        public string getPasswordId()
        {
            return passwordis;
        }
    }
}
