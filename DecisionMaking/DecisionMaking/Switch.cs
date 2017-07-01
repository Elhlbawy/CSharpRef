using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking
{
    class Switch
    {
        // making decision with switch statement
       

        public void switchSt()
        {
            Console.WriteLine("Plsm Enter your Degree A, B, C, D ");
            string userDegree = Console.ReadLine(); //to recive user input
            switch (userDegree) //condition
            {
                case "A":
                    Console.WriteLine("Cong, You are Excellent");
                    break;
                case "B":
                    Console.WriteLine("Cong, You are Very Good");
                    break;
                case "C":
                    Console.WriteLine("Cong, You are  Good");
                    break;
                case "D":
                    Console.WriteLine("Cong, You are  Good");
                    break;
                default:
                    Console.WriteLine("Sorry, Have a good luck");
                    break;



            }
        }
    }
}
