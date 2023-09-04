using System;

namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Ralph";
            int dogAge = 10;
            char arrayNumber = 'a';
            bool isName = true;
            double doubleNum = 1.33;
            decimal decNum = 13.990m;

            Console.WriteLine($"its {isName} that {dogName}  is {arrayNumber} {dogAge} year old  dog");
            Console.WriteLine($"My dogs name is {dogName}, He is {dogAge} years old" );
            Console.WriteLine($"double number is {doubleNum} while decimal number is {decNum}");
            
        }
    }
}
