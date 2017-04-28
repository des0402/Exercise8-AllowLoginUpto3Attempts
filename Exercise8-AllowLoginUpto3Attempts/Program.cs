using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8_AllowLoginUpto3Attempts
{
    //Write a C# Sharp program that takes userid and password as input (type string). After 3 wrong attempts, user will be rejected.

    class Program
    {
        static void Main(string[] args)
        {
            string userId, password;
            int attempt = 0;
            bool login;
            string correctPassword = "password";

            
            do
            {
                Console.Write("Enter your userId: ");
                userId = Console.ReadLine();
                Console.Write("Enter your password: ");
                password = Console.ReadLine();

                if (password == correctPassword)
                {
                    login = true;
                    attempt = 3;
                }
                else
                {
                    if(attempt == 0 || attempt == 1)
                    Console.WriteLine("\nWrong password!!! Enter again");

                    login = false;
                    attempt++;
                }


            } while ((password != correctPassword) && attempt != 3);
        
            if(login == false)
            {
                Console.WriteLine("\nYou have attempt 3 times! Please try again later");
            }
            else if(login == true)
            {
                Console.WriteLine("\nYou have successfully logged in!");
            }

            Console.ReadLine();
        }
    }
}
