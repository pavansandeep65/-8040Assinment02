using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seng8040_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            bool validMenuSelect = false;
            while (validMenuSelect == false)
            {

                Console.WriteLine("1 = Enter Triangle Dimensions");
                Console.WriteLine("2 = Exit\n");
                userInput = Console.ReadLine();


                if (userInput != "1" && userInput != "2")
                {
                    Console.WriteLine("Incorrect input given please try again\n ");
                }
                if (userInput == "2")
                {
                    validMenuSelect = true;
                    break;
                }
                String len1;
                String len2;
                String len3;
                int l1;
                int l2;
                int l3;
                

                do
                {
                    Console.WriteLine("Enter 1 Dimension \n");
                    len1 = Console.ReadLine();

                } while (!(int.TryParse(len1, out l1)));


                do
                {
                    Console.WriteLine("Enter 2 Dimension \n ");
                    len2 = Console.ReadLine();
                } while (!(int.TryParse(len2, out l2)));

                do
                {
                    Console.WriteLine("Enter 3 Dimension \n");
                    len3 = Console.ReadLine();
                } while (!(int.TryParse(len3, out l3)));


                if ((l1 + l2) > l3 && (l2 + l3) > l1 && (l3 + l1) > l2)
                {
                    Console.WriteLine("The Given Inputs forms a Triangle");
                    
                    Console.WriteLine(TriangleSolver.Analyze(l1, l2, l3));
                }
                else
                {
                    Console.WriteLine("The Given Inputs DoNot form a triangle\n");
                }


            }
        }
    }
}
