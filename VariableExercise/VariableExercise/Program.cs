using System;

namespace VariableExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string dog = "Clyde";
            int age = 4;
            char firstLetterOfName = 'C';
            bool isDog = true;
            double ageInDogYears = age * 7;
            decimal HumanYearsDivedByDogYears = age / 7;

            Console.WriteLine($"My dog's name is {dog} he is {age} years old. In Dog Years he is {ageInDogYears} years old. {firstLetterOfName}, {HumanYearsDivedByDogYears}, {(isDog ? "yes" : "no")}");
        }
    }
}
