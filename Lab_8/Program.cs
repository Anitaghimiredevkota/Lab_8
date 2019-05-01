using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //int studentNum = 4;
            string[] studentInfo = new string[] { "Anita", "Richard", "Sam", "Robin", "Ema" };
            string[] home = new string[] { "Novi", "Deerborn", "Canton", "Langsing", "New Hudson" };
            string[] fabFood = new string[] { "Noodles", "Pizza", "Burger", "Pizza", "Hot Dog" };
            string repeat;
            bool doAgain = true;

            while (doAgain)
            {
                int userValue = GetStudentNumber();
                Console.WriteLine($"Student {userValue} is {studentInfo[userValue - 1]}. What would you like to know about {studentInfo[userValue - 1]}?(enter hometown or favrite food)");
                string userChoice = GetFoodHomeTown();
                switch (userChoice)
                {
                    case "hometown":
                        Console.WriteLine($"{studentInfo[userValue - 1]}'s hometown is {home[userValue - 1]}, MI. Would you like to know more?(y/n).");
                        break;
                    case "favorite food":
                        Console.WriteLine($"{studentInfo[userValue - 1]}'s favorit food is {fabFood[userValue - 1]}. Would you like to know more?(y/n)");
                        break;
                    default:
                        break;
                }

                repeat = Console.ReadLine();
                if (repeat == "n")
                {
                    Console.WriteLine("Bye see you again!");
                    doAgain = false;
                }
                else { }
            }              
        }
        public static int GetStudentNumber()
        {

            while (true)
            {
                try
                {
                    Console.WriteLine("Welcome to our C# class. Which student would you like to hear more about?(enter a number 1-20) :");
                    int.TryParse(Console.ReadLine(), out int userValue);
                    if (userValue >= 1 && userValue <= 20)
                    {

                        return userValue;                      
                    }
                }
                catch (IndexOutOfRangeException)

                {
                    Console.WriteLine("That student does not exist. Please try again.(enter a number 1-20) :");
                    return GetStudentNumber();
                }


            }
        }
        public static string GetFoodHomeTown()
        {
            //Console.WriteLine("hometown or favorite food");
            string userChoice = Console.ReadLine();
          
                if (userChoice == "hometown" || userChoice == "favorite food")
                {
                    return userChoice;
                }
            else

            //catch (FormatException myf)
            {
                Console.WriteLine("That data does not exist.Please tru again.(enter hometown or favorite food):");
                return GetFoodHomeTown();
            }

        }
    }
}
        
            
        
    

