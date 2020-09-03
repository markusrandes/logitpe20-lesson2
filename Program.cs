using System;

namespace howoldareyou
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*1 App greets the user
             * App asks the user´s name 
             * App greets the user by their name
             * App asks the user´s age 
             * app calculates the age of the user 
             * the app displays the resuls (the user´s name)
             */
            Console.WriteLine("Good morning!");
            Console.WriteLine("What´s your name?");
            string Name;
            Name = Console.ReadLine();
            Console.WriteLine("Hello," + Name);
            Console.WriteLine("what is your year of birth?");
            string UserInput;
            UserInput = Console.ReadLine();
            int YearOfBirth;
            //parsing staarting to interger (number)
            YearOfBirth = Int32.Parse(UserInput);
            int Age =2020 - YearOfBirth;
            Console.WriteLine("you are" + Age + " old.");




        }
    }
}
