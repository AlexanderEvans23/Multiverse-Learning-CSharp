using System;

namespace NameBadgeGen
{
    class Program
    {
        static void Main(string[] args)
        {
            static void BadgeGen(){
                string name;
                string number;
                string email;
                string response;
                int finished = 0;

                while (finished == 0)
                {
                    Console.WriteLine("It has been a pleasure, All we need is your contact info! \nName: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Phone Number: ");
                    number = Console.ReadLine();
                    Console.WriteLine("Email: ");
                    email = Console.ReadLine();
                    Console.WriteLine($"Is the following correct? \nYour name is {name}, with a phone number of {number} and your email being {email}");
                    response = Console.ReadLine();

                    if (response == "yes")
                    {
                        Console.WriteLine("Glad to speak with you!");
                        finished = 1;
                    }
                }

            }
            BadgeGen();
        }
    }
}