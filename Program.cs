using System;
// Please let this code appear on GitHub 
namespace AssignmentFour
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Please enter text to count");
          //  string outPut = Console.ReadLine();
            //The above allows you it add your sentence manually if you want also (This is my favourite :) ) 

            string charCounts = Words.CountCharactersInSentence("Hello World");
            //created a string variable and I named it charCounts - charCounts equals to Words, which is a class on my Words.cs file
            //inside the class words there is a method called public static string CountCharactersInSentence which is where the code has been created
            //the has been a value added called "Hello world"

            Console.WriteLine(charCounts);
            //this is going to print out the string class method 
        }
    }
}
