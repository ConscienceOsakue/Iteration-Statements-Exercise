using System.ComponentModel;
using System;
using System.ComponentModel.Design;

namespace IterationStatements
{
    public class Program
    {

        //DONE - Write a method to display the multiplication table(from 1 to 12) of a given integer
        static void DisplayMultiplicationTable(int number)
        {

            
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {

            //Write a method that will print to the console all numbers 1000 through - 1000
            Console.WriteLine("Welcom, you are assigne 1000 Orangies. Type in the number of Orangies assign to you below! ");
            var userInput = Console.ReadLine();
            var myOrangies = int.Parse(userInput);
            var listOfMyOrangies = new List<double>();

            //A do-while loop that will decrease the number of oragies till -1000:
            do
            {

                myOrangies--;
                listOfMyOrangies.Add(myOrangies);

            } while (myOrangies >= -999);

            foreach (var orange in listOfMyOrangies)
            {
                Console.WriteLine($"{orange} orangies");
            }
            Console.WriteLine();

            //Write a method that will print to the console numbers 3 through 999 by 3 each time
            Console.WriteLine($"Hello, what is you name?");
            var playerName = Console.ReadLine();

            Console.WriteLine($"{playerName} your play time starts from 3 and MAX at 999.");

            Console.WriteLine($"{playerName}, type in the MAX play number to view your play list");

            var maxPlayTime = int.Parse(Console.ReadLine());
            var numOfVideoPlay = 3;
            var VideoPlayTimes = new List<double>();

            for (numOfVideoPlay = 3; numOfVideoPlay <= maxPlayTime; numOfVideoPlay += 3)
            {
                Console.WriteLine($"{numOfVideoPlay}");
            }
            Console.WriteLine();

            //Write a method to accept two integers as parameterss and check whether they are equal or not
            Console.Write("Enter the price of the cake: ");
            if (int.TryParse(Console.ReadLine(), out int cakePrice))
            {
                Console.Write("Enter the price of the cookie: ");
                if (int.TryParse(Console.ReadLine(), out int cookiePrice))
                {
                    if (AreEqual(cakePrice, cookiePrice))
                    {
                        Console.WriteLine("The two price are equal.");
                    }
                    else
                    {
                        Console.WriteLine("The two price are not equal.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for the cookie price.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for the cake price.");
            }

            static bool AreEqual(int cakePrice, int cookiePrice)
            {
                return cakePrice == cookiePrice;
            }
            Console.WriteLine();

            //Write a method to check whether a given number is even or odd.
            var x = 2;

            Console.WriteLine("Type in any number and i will guess if it's an even or odd number.");

            Console.WriteLine("Enter a number:");

            var userInputNumber = int.Parse(Console.ReadLine());

            if (userInputNumber % x == 0)
            {

                Console.WriteLine("Guessed it! It's an Even number.");
            }

            else
            {
                Console.WriteLine("Got you, is am Odd number!");

            }

            Console.WriteLine();
            //Write a method to check whether a given number is positive or negative.
            {
                Console.WriteLine("Hello, type in your favorite number, lets check if it's positive or negative?");
                var favoriteNum = double.Parse(Console.ReadLine());
                var result = CheckNumber(favoriteNum);
                Console.WriteLine($"The number {favoriteNum} is {result}.");

                static string CheckNumber(double favoriteNum)
                {

                    if (favoriteNum > 0)
                    {
                        return "Positive";
                    }
                    else if (favoriteNum <= 0)
                    {
                        return "Negative";
                    }
                    else
                    {
                        return "Time OUT!";
                    }

                }
                Console.WriteLine();
                //DONE - Write a method to read the age of a candidate and determine whether they can vote.
                //Hint: Use Parse or the safer TryParse() for an extra challenge
                //Parse()
                //TryParse()

                Console.WriteLine("Type your name?");
                var candidateName = Console.ReadLine();

                Console.WriteLine($"How old are you {candidateName}");
                var candidateAge = int.Parse(Console.ReadLine());

                if (candidateAge >= 18)
                {
                    Console.WriteLine($"{candidateName} You can vote!");

                }
                else
                {
                    Console.WriteLine($"Sorry {candidateName} you are not 18 or older hence you can't vote!");

                }
                Console.WriteLine();
                //Write a method to check if an integer(from the user) is in the range -10 to 10.
                var listOfNumber = new List<int>();
                for (var num = -10; num <= 10; num++)
                {
                    listOfNumber.Add(num);

                }
                Console.WriteLine();
                Console.WriteLine("Type A number");
                var userNumber = int.Parse(Console.ReadLine());

                if (listOfNumber.Contains(userNumber))
                {
                    Console.WriteLine($"{userNumber} is in range of -10 to 10.");
                }
                else
                {
                    Console.WriteLine($"{userNumber} is not found in the range of -10 to 10.");
                }
                Console.WriteLine();
                Console.WriteLine("Enter a number to display its multiplication table:");

                int number = Convert.ToInt32(Console.ReadLine());
                DisplayMultiplicationTable(number);
               



            }
        }
    }
}

