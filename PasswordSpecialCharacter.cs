using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REflections
{
   public class PasswordSpecialCharacter
    {
        string password;
        string passwordis;


        public PasswordSpecialCharacter(string e, string i)
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
