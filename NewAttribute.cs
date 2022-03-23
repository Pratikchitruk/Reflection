using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace REflections
{
    public class NewAttribute:Attribute
    {
        private string tital;
        private string description;
        

        public NewAttribute(string t, string d)
        {
            tital = t;
            description = d;
            
        
        }

        public static void AttributeDisplay(Type classType)
        {

            Console.WriteLine("Methods of class {0}", classType.Name);

            MethodInfo[] methods = classType.GetMethods();

            for (int i = 0; i < methods.GetLength(0); i++)
            { 
            object[] attributeArray = methods[i].GetCustomAttributes(true);
               

                foreach (Attribute item in attributeArray)
                {
                    if (item is NewAttribute)
                    {
                        NewAttribute attributeobject = (NewAttribute)item;
                        Console.WriteLine("{0} - {1}", methods[i].Name, attributeobject.description);


                    
                    }
                }
            
            }
        
        }
    }
}
