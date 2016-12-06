using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeToMyGitHub1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter your name: ");
            string FirstName = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            string LastName = Console.ReadLine();
           
            //place holder syntax {0} = FirstName {1} = LastName
            Console.WriteLine("Hello {0} {1}! Welcome to my GitHub!" , FirstName, LastName);
            
            Console.ReadLine();
        }
          
    }
}
