using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Follow the instructions provided in each comment below to complete the exercise.
            // Use the example given to guide your implementation.

            //Create a List called "numbers" - DONE!
            var numbers = new List<int>(); //DO NOT ERASE THIS! You will use this in the exercise.

            //-----START HERE------------------------------------------

            //TODO - Create a variable of type int and name it "num"
            //TODO - Initialize the variable with a value of 0
            var num = 0;


            //TODO - Create a do-while loop using the existing brackets as a template.
            // The existing brackets are placeholders for your loop code.
            // Inside this loop:

            do
            {
                num++;

                numbers.Add(num);

            } while (num < 100); //TODO - Continue the loop while "num" is less than 100


            while (num < 200)
            {
                num++;

                numbers.Add(num);
            }



            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");


            //TODO - Create a foreach loop using the existing brackets as a template.
            // The existing brackets are placeholders for your loop code.
            // Inside this loop, print each number in "numbers".
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }



            Console.WriteLine("");
            Console.WriteLine("Decrease:");


            //TODO - Create a for loop using the existing brackets as a template.
            // The existing brackets are placeholders for your loop code.
            // This loop will print the numbers in reverse order - from 200 to 1.

            // a) In your initializer, set the value of "i" to 199
            // b) In your conditional, ensure that the loop continues as long as "i" is:
            //    - Less than or equal to the number of items in "numbers" (use "numbers.Count")
            //    - Greater than or equal to 0
            // c) Decrement "i" by 1 in each iteration
            for (int i = 199; i <= numbers.Count && i >= 0; i--)
            {
                //TODO - Inside the loop, place numbers[i] inside of the Console.WriteLine() method
                Console.WriteLine(numbers[i]); // Example placement of numbers[i] inside Console.WriteLine
            }

            //------------End of exercise

        }
    }
}
