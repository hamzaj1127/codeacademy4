using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeacademy4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string username, password;
            int ctr = 0;
            Console.Write("\n\nCheck username and password :\n");
            Console.Write("N.B. : Default username and password is :abc and efg\n");
            Console.Write("------------------------------------------------------\n");

            do
            {
                Console.Write("Input a username: ");
                username = Console.ReadLine();

                Console.Write("Input a password: ");
                password = Console.ReadLine();

                if (username != "abc" || password != "efg")
                    ctr++;
                else
                    ctr = 1;

            }
            while ((username != "abc" || password != "efg") && (ctr != 3));

            if (ctr == 3)
                Console.Write("\nLogin attempted three or more times. You have been locked out" +
                    "!\n\n");
            else
                Console.Write("\nThe password was entered successfully!\n\n");
        }
    }
}
