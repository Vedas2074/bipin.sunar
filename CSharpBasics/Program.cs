using System;
using LearningClasses;
using static Shape;

class Program
    {
        // static void Main(string[] args)
        // {
        //     // // Console.WriteLine("Hello World!");
        //     // // Console.WriteLine("Bipn is very good person.");
        //     // Console.WriteLine("What is Your name:");
        //     // string name = Console.ReadLine();

        //     // Console.WriteLine("Hello " + name);


        //     SelectionStatement selectionstatement = new SelectionStatement();
        //     selectionstatement.LearnIfElse();
        // }

        static void Main()
        {
            // var person = new Person("Bipin", "Dang", 22);
            // person.
            // person.Age = 22;

            var x = Calculator.Sum<int>(25 , 30);



            Rectangle rectangle = new Rectangle();
            rectangle.Length = 23.6;
            rectangle.Breadth = 6.32;
            var result = rectangle.GetArea();
        }
    }

