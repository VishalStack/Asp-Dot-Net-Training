using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Select the number of operations which you want to see the example");
            Console.WriteLine("1. type-coversion");
            Console.WriteLine("2. constants");
            Console.WriteLine("3. operators");
            Console.WriteLine("4. loops using guessing game");
            Console.WriteLine("5. Encapsulation");
            Console.WriteLine("6. overriding");
            int num = Convert.ToInt32(Console.ReadLine());



            switch (num)
            {
                case 1: //type-conviesion
                    int i = 75;
                    float f = 53.005f;
                    double d = 2345.7652;
                    bool b = true;

                    Console.WriteLine("i={0}", i);
                    Console.WriteLine("f={0}", f);
                    Console.WriteLine("d={0}", d);
                    Console.WriteLine("b={0}", b);

                    Console.WriteLine("i is converted into string : {0}", i.ToString());
                    Console.WriteLine("f is converted into string : {0}", f.ToString());
                    Console.WriteLine("d is converted into string : {0}", d.ToString());
                    Console.WriteLine("b is converted into string : {0}", b.ToString());

                    Console.WriteLine("f is converted into integer : {0}",(int)(f));
                    Console.WriteLine("f is converted into double : {0}",(double)(f));
                    Console.WriteLine("i is converted into float : {0}",(float)(i));
                    break;
                case 2://constants

                        const double pi = 3.14;
                        double r;

                        Console.WriteLine("Enter Radius: ");
                        r = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("pi={0}", pi);
                        Console.WriteLine("r={0}", r);
                   
                        double areaCircle = pi * r * r;
                        Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
                        break;
                case 3://operators

                        int a, x, c;
                        a = 7;
                        x = a;
                        c = x++;
                        Console.WriteLine("a = {0}", a);
                        Console.WriteLine("b = {0}", x);
                        Console.WriteLine("c = {0}", c);
                        x = a + x * c;
                        a = (int)Math.Sqrt(x);
                        
                        Console.WriteLine("square root of a + b * c in integer = {0}", a);

                        string s = "String literal";
                        char l = s[s.Length - 1];
                        Console.WriteLine("string is : {0}",s);
                        Console.WriteLine("last character = {0}",l);

                        var numbers = new List<int>(new[] { 1, 2, 3 });
                        x = numbers.FindLast(n => n > 1);
                        Console.WriteLine("max of 1,2,3 : {0}",x);
                    break;
                case 4:
                    int count = 3;
                    int guess = 10;

                    if (count > 0)
                    {
                        for (int j = 0; j < count; j++)
                        {
                            Console.Write("guess the number:");
                            int numb = Convert.ToInt32(Console.ReadLine());
                            if (numb > guess)
                            {
                                Console.WriteLine("you have to guess the smaller one");
                            }
                            if (numb < guess)
                            {
                                Console.WriteLine("you have to guess the larger one");
                            }
                            else
                            {
                                Console.WriteLine("you win");
                                break;
                            }
                        }
                    }

                    else
                    {
                        Console.WriteLine("you lose");
                    }
                    break;
                case 5://Encapsulation

                    showName_public sn = new showName_public();// Public Specifiers
                    showName_private sd = new showName_private();// private specifiers
                    showName_protected st = new showName_protected();// protected specifiers
                    Console.Write("Enter your name:\n");

                    sn.name = Console.ReadLine();
                    sn.print();
                    sd.print();
                    st.print();
                    
                    break;
                case 6://Methods overriding
                    showName_private sp = new showName_private();
                    SimpleMath obj = new SimpleMath();

                    Console.Write("enter 1st number:");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("enter 2nd number:");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    int result = obj.AddTwoNumbers(num1, num2);
                    int ret = sp.FindMax(num1, num2);
                    result = obj.SquareANumber(result);

                    Console.WriteLine("max of these two numbers : {0}",ret);
                    Console.WriteLine("(addition of these nums)^2 : {0}", result);

                    Console.ReadLine();
                    break;

                default: Console.WriteLine("wrong choice!!!!!!!!!!!");
                        break;
            }

        }
  

    }
    class showName_public
    {

        public string name;
        public void print()
        {
            Console.WriteLine("\nMy name is " + name);
        }
    }
    class showName_private
    {

        private string name1;
        public void print()
        {
            Console.WriteLine("\nMy name is " + name1);
        }
        public int FindMax(int num1, int num2)
        {

            int result;

            if (num1 > num2)
                result = num1;
            else
                result = num2;
            return result;
        }
    }
    class showName_protected
    {

        protected string name2;
        public void print()
        {
            Console.WriteLine("\nMy name is " + name2);
        }
    }
    class SimpleMath
    {
        public int AddTwoNumbers(int number1, int number2)
        {
            return number1 + number2;
        }

        public int SquareANumber(int number)
        {
            return number * number;
        }
    }
    

}