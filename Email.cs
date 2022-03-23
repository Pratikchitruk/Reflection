using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REflections
{
    public class Email
    {
        string mail;
        string mailid;


        public Email(string e,string i)
        {

            mail = e;
            mailid = i;

        }
        [NewAttribute("Accesosr", "give Email")]
        public string getEmail()
        {
            return mail;
        }
        [NewAttribute("Accesosr", "Pratik.chitruk@gmail.com")]
        public string getMailId()
        {
            return mailid;
        }
    }
}
