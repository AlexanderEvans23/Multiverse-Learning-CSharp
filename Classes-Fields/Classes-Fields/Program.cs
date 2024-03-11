using System;
using static System.Net.Mime.MediaTypeNames;

namespace Fields
{
    class Program
    {
        public class Bio
        {
            public string name;
            public int age;
            public string hometown;

            public Bio(string bioName, int bioAge, string bioHometown)
            {
                name = bioName; 
                age = bioAge;
                hometown = bioHometown;
            }
            
            public void biography()
            {
                Console.WriteLine($"{name}: {age}: {hometown}");
            }
            
        }
        
        static void Main(string[] args)
        {
            Bio test1 = new Bio("Alex", 23, "Springfield");
            test1.biography();
        }
    }

       
}
