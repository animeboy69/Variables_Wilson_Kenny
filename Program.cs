using System;

namespace Variables_Wilson_Kenny
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declares an integer to store a favorite number.
            int favoriteNumber;
            // Booleans initalized to false for jumping and running.
            bool isJumping = false, isRunning = false;
            // Declared random float varible
            float myFloat;
            // Assigning the favorite to 6 
            favoriteNumber = 1;
            // Assigning myFloat to 24.21
            myFloat = 24.21f;
            // Initializing constant finalGrade to 90
            const double finalGrade = 90.0;

            // Prints all variables to console 
            Console.WriteLine("Favorite #:" + favoriteNumber);
            Console.WriteLine("Jumping: " + isJumping);
            Console.WriteLine("Running: " + isRunning);
            Console.WriteLine("Random Floating #:"+ myFloat);
            Console.WriteLine("Final Grade: "+ finalGrade);
        }
    }
}
