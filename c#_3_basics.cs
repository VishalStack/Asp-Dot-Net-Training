using System;
using First;
using Second;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace First
{
    public class Hello
    {
        public void sayHello() { Console.WriteLine("Hello Namespace"); }
    }
}
namespace Second
{
    public class Welcome
    {
        public void sayWelcome() { Console.WriteLine("Welcome Namespace"); }
    }
}
namespace ConsoleApp1

{
    interface IPolygon
    {
        void calculateArea();
    }
    class Rectangle : IPolygon
    {
        public void calculateArea()
        {

            int l = 30;
            int b = 90;
            int area = l * b;
            Console.WriteLine("Area of Rectangle: " + area);
        }
    }

    class Square : IPolygon
    {
        public void calculateArea()
        {

            int l = 30;
            int area = l * l;
            Console.WriteLine("Area of Square: " + area);
        }
    }
    public class stringIsEmpty : Exception
    {
        public stringIsEmpty(string message) : base(message)
        {
        }
    }
    public class Empty
    {
        string str1 = "Naxi here!!!";

        public void showEmpty()
        {

            if (str1 == " ")
            {
                throw (new stringIsEmpty("Empty String Found "));
            }
            else
            {
                Console.WriteLine("String: {0}", str1);
            }
        }
    }

    class Program
    {
        

        static void Main(string[] args)
        {
         
            string winDir = System.Environment.GetEnvironmentVariable("windir");

            Console.WriteLine("Select the number of operations which you want to see the example");
            Console.WriteLine("1. Interface");
            Console.WriteLine("2. namespace");
            Console.WriteLine("3. Regular Expression");
            Console.WriteLine("4. Exception Handling");
            Console.WriteLine("5. File I/O");
            int num = Convert.ToInt32(Console.ReadLine());



            switch (num)
            {
                case 1: //Interface
                    Rectangle r1 = new Rectangle();
                    r1.calculateArea();

                    Square s1 = new Square();
                    s1.calculateArea();


                    break;
                case 2: //Arrays
                    Hello h1 = new Hello();
                    Welcome w1 = new Welcome();
                    h1.sayHello();
                    w1.sayWelcome();

                    Console.ReadLine();

                    break;


                case 3://Regular Expression

                    Regex rx = new Regex(@"\b(?<word>\w+)\s+(\k<word>)\b");

                    string str = "the the quick brown fox  fox jumps over the lazy dog dog.";

                    MatchCollection matches = rx.Matches(str);


                    Console.WriteLine("{0} matches found in:  {1}", matches.Count, str);


                    foreach (Match match in matches)
                    {
                        GroupCollection groups = match.Groups;
                        Console.WriteLine("'{0}' repeated at positions {1} and {2}",
                                          groups["word"].Value,
                                          groups[0].Index,
                                          groups[1].Index);
                    }
    

                   Console.ReadLine();
                    break;
                case 4: //Exception Handling
                    
    
                    int a, b, c;
                    Console.WriteLine("ENTER ANY TWO NUBERS");
                    try
                    {
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        c = a / b;
                        Console.WriteLine("C VALUE = " + c);
                    }
                    catch
                    {
                        Console.WriteLine("error occured....");
                    }
                    Console.ReadKey();


                    Empty str1 = new Empty();
                    try
                    {
                        str1.showEmpty();
                    }
                    catch (stringIsEmpty e)
                    {
                        Console.WriteLine("stringIsEmptyException: {0}", e.Message);
                    }
                    Console.ReadKey();



                    break;
                case 5: //File I/O
                    StreamWriter writer = new StreamWriter("C:/Users/naxis/names.txt");
                    writer.WriteLine("File created using StreamWriter class.");
                    writer.Close();

                    StreamReader reader = new StreamReader("C:/Users/naxis/names.txt");
                    string text1 = System.IO.File.ReadAllText("C:/Users/naxis/names.txt");

                    
                    System.Console.WriteLine("Contents of names.txt = {0}", text1);


                    break;

                
                default:
                    break;

            }
        }

        
    }

    

}