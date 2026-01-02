using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_If_Else_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //datatype variable name  //we called variable declaration
            int score;// variable declaration
            Console.WriteLine("enter score number");  //this statement is used to print the data
            score = int.Parse(Console.ReadLine());//this statement is used to read the data from the commandprompt and assign to score variable
            if (score >= 90)
            {
                Console.WriteLine("You got an A.");
            }
            else if (score >= 80)
            {
                Console.WriteLine("You got a B.");
            }
            else if (score >= 70)
            {
                Console.WriteLine("You got a C.");
            }
            else if (score < 60)
            {
                Console.WriteLine("You are failed.");
            }
            else
            {
                Console.WriteLine("You need to improve your score");
            }
            Console.ReadLine();
        }
    }
}
