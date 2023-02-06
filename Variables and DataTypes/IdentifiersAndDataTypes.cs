using System;

namespace IdentifiersAndDataTypes

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C# Identifiers
            //All the variables must be identified with the unique names.
            //These unique names are called identifiers.
            //These can be of short names (a, b, c) or more descriptive names (myNum, age, salary).
            //It is recommended to use the descriptive names in order to creare the understandable and maintainable code.
            //e.g.,
            //int a = 22; //variable for age
            //Instead of using a for age, it's better to use myAge
            //int Age = 22; //remember that names are case sensitive, So, myage and myAge are different variables

            //DataTypes
            //A Datatype specifies the type and size of a variable
            //It is important to use the correct data type to save the time; to avoid errors; to save memory
            //Datatypes can be primitive or non-primitive
            //Primtive includes: int, long, double, float, char, bool
            //Non_primtive includes: String, Arrays, Classes

            int myAge = 22;
            string myName = "Younis Yousaf";
            double mySalary = 20.4;
            char myLetter = 'Y';
            bool myBool = true;

            Console.WriteLine($"My Name is {myName}, \n" +
                              $"myAge is {myAge}, \n" +
                              $"mySalary is {mySalary}, \n" +
                              $"my Name starts with the letter {myLetter}, \n" +
                              $"all this information is {myBool}\n");
            //Now printing the size of every variable, which datatype have how much memory
            Console.WriteLine($"Size of Integer: {sizeof(int)}");
            Console.WriteLine($"Size of Double: {sizeof(double)}");
            Console.WriteLine($"Size of char: {sizeof(char)}");
            Console.WriteLine($"Size of bool: {sizeof(bool)}");
            Console.WriteLine($"Size of long: {sizeof(long)}");
            Console.WriteLine($"Size of float: {sizeof(float)}");
            //Size of String can not be printed by method sizeof()
            Console.ReadKey();
        }
    }
}
