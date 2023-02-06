using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static int age = 20;
        static string fullName = "Younis Yousaf";
        static void Main(string[] args)
        {
            /*
             Variables:
                Variables are containers to store the data.
            Syntax
                type variableName = value;
             * */
            string myName = "Younis Yousaf";
            Console.WriteLine($"My Name is {myName}");
            /* 
             Constants:
                    If you don't want to overwrite the existing values, you can add the const keyword in front of the variable type. 
             This will declare the variable as constant which means "unchangeable" and read-only.

             */
            const int myAge = 22;
            //myAge = 20; Here IDE will point out an error because age is constant and cannot be changed.
            Console.WriteLine($"My Age is {myAge}");
            //Modifying and displaying the static variables we have defined
            age = 22;
            Console.WriteLine($"Hello, {fullName}, and your age is: {age}");
            Console.ReadKey();
        }
    }
}
