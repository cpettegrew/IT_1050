using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //part 1
            Console.Write("What is your first name?");
            string firstName = Console.ReadLine();
            Console.Write("What is your middle initial?");
            char middleInitial = char.Parse(Console.ReadLine());
            Console.Write("What is your last name?");
            string lastName = Console.ReadLine();
            string fullName = firstName + " " + middleInitial + " " + lastName;

            //part 2
            Console.Write("What is your height in feet?");
            int heightFeet = int.Parse(Console.ReadLine());
            Console.Write("What is your additional height in inches?");
            double heightInches = double.Parse(Console.ReadLine()); 
            double totalHeightIn = (heightFeet * 12) + heightInches);
            double totalHeightCM = totalHeightIn * 2.54

            //part 3
            Console.Write("Are you a US citizen? Type 1 for yes and 0 for no");
            bool isCitizen = bool.Parse(Console.ReadLine());
            Console.Write("How old are you?");
            int age = int.Parse(Console.ReadLine());
            bool canVote = (age >= 18) && isCitizen;
            Console.WriteLine("Your full name:" + fullName);
            Console.WriteLine("Your Height is centimeters:" + totalHeightCM);
            Console.WriteLine("Are you able to vote:" + canVote);
            Console.WriteLine("Press Any Key to Continue...");
            Console.ReadKey();


        }
    }
}
