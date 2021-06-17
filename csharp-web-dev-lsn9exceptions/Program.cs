using System;
using System.Collections.Generic;
using System.Linq;

//Exercises for the Exceptions Chapter

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        
        static void Divide(double x, double y)
        {
            int zero = 0;
            try
            {
                if(y == zero)
                {
                    throw new DivideByZeroException("You cannot divide by zero");
                }
                else
                {
                    double score = (x / y) * 100;
                    Console.WriteLine(score);
                }
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
        }

        static void CheckFileExtension(string fileName)
        {
            int point = 0;
            try
            {
                
                if (fileName.Contains(".cs"))
                {
                    point++;
                    Console.WriteLine($"Correct extension {point} point awarded.");
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"YOU FORGOT TO SUBMIT IT AS A .cs FILE...{point} for you!!!");
                }
            }
            catch(ArgumentOutOfRangeException e) 
            {
                
                Console.WriteLine($"Your file is not in the correct format. {point} for YOU!!!");
                
            }

            

        }
        

        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            Console.WriteLine("Please enter possible points: ");
            double possiblePoints = Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine("Please enter points achieved by student: ");
            double studentPoints = Convert.ToDouble(Console.ReadLine());
            

            Divide(studentPoints,possiblePoints);

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            foreach(KeyValuePair <string,string> val in students)
            {
                
                string stuFile = val.Value.ToString();

                CheckFileExtension(stuFile);
            }
            
        }
    }
} 
