using System;
using System.Collections.Generic;
using System.Xml;

namespace PasswordGen
{
    internal class Program
    {
        public static Random random = new Random();
        
        private static string karkaters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*()_+=-;:?/><.,~`'|1234567890";
        public static string password;

        public static void Main(string[] args)
        {
            Console.WriteLine("Please submit the length of your password.");
            string input = Console.ReadLine();
            
            // checks if amount is a interger
            if (int.TryParse(input, out int amount))
            {
                // selects a random charactar and puts it in the password string;
                for (int i = 0; i < amount; i++)
                {
                    string selectedCaractar = karkaters.Substring(random.Next(0, karkaters.Length),1);
                    password += selectedCaractar;
                }
            
                Console.WriteLine(password);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("This is not a number!");
            }
        }
    }
}