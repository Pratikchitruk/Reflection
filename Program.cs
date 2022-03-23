using System;

namespace REflections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to reflections");

            NewAttribute.AttributeDisplay(typeof(FirsttName));
            Console.WriteLine("\n");
            NewAttribute.AttributeDisplay(typeof(LastName));
            Console.WriteLine("\n");
            NewAttribute.AttributeDisplay(typeof(PhoneNo));
            Console.WriteLine("\n");
            NewAttribute.AttributeDisplay(typeof(Email));
            Console.WriteLine("\n");
            NewAttribute.AttributeDisplay(typeof(Password));
            Console.WriteLine("\n");
            NewAttribute.AttributeDisplay(typeof(PasswordUpperCase));
            Console.WriteLine("\n");
            NewAttribute.AttributeDisplay(typeof(PasswordNumaricNumber));
            Console.WriteLine("\n");
            NewAttribute.AttributeDisplay(typeof(PasswordSpecialCharacter));
            Console.WriteLine("\n");
        }
    }
}