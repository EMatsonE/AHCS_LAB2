using System;

namespace AHCS_LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            do
            {

                string userInput = "";
                Console.WriteLine("Greetings Human! Please tell me the length of a room!");

                userInput = Console.ReadLine();

                float roomLength = float.Parse(userInput);

                Console.WriteLine("Awesome! Now tell me the width of a room!");

                userInput = Console.ReadLine();

                float roomWidth = float.Parse(userInput);

                float perimeter = (roomWidth * 2) + (roomLength * 2);

                float area = roomWidth * roomLength;

                Console.WriteLine($"Well now! Looks like your area is {area} and your perimeter is" +
                    $" {perimeter}!");

               

                bool isValid = false;

                do
                {
                    Console.WriteLine("Would you like to try another calculation?");
                    userInput = Console.ReadLine();
                    if (userInput.Trim().ToLower() == "no")
                    {
                        playAgain = false;
                        isValid = true;
                    }
                    else if (userInput.Trim().ToLower() == "yes")
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine("I...did not think that was such a hard question." +
                            "you need to say 'yes' or 'no' human.");
                    }
                }
                while (isValid == false);
                
            }
            while (playAgain == true);

            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();

            //calculate area and per
            //continue loop
            //ends properly in do while
            //can handle decibles, double
        }
    }
}
