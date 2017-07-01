using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecisionMaking;


namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {


            // Excute if statement
            // Grade(); you shoud uncomment taht line
            
            // Excute if and default else
            // GradeIfelse(); you shoud uncomment taht line
            
            // Excute if more conditions and default else
            //  GradeIfelseif(); you shoud uncomment taht line

            Console.ReadKey(); // to stop Console Flashing 
        }

        // There are Many ways to make decision in csharp

        //If Statement for one Condition
        static void Grade()
        {
            Console.WriteLine("Enter your Grade: ");
            string grade = Console.ReadLine();

            if (grade == "A")
            {
                Console.WriteLine("Your Grade Is: Excellent");
            }
        }
        //If Statement for one Condition and make a default case with esle
        static void GradeIfelse()
        {
            Console.WriteLine("Enter your Grade: ");
            string grade = Console.ReadLine();

            if (grade == "A")
            {
                Console.WriteLine("Your Grade Is: Excellent");
            }else
            {
                //Here is the defualt, if condition is false
                Console.WriteLine("Sorry, Enter right Grade");
            }
        }
       
        //If Statement for more Conditions and make a default case with esle
        static void GradeIfelseif()
        {
            Console.WriteLine("Enter your Grade: ");
            string grade = Console.ReadLine();

            if (grade == "A")
            {
                Console.WriteLine("Your Grade Is: Excellent");
            }else if (grade=="B")
            {
                Console.WriteLine("Your Grade Is: Very Good");
            }
            else if (grade == "C")
            {
                Console.WriteLine("Your Grade Is: Good");
            }
            else if (grade == "D")
            {
                Console.WriteLine("Your Grade Is: Sorry");
            }
            else
            {
                //Here is the defualt, if condition is false
                Console.WriteLine("Sorry, Enter right Grade");
            }
        }

    }

}
