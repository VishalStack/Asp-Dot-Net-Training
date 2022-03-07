using System;

namespace InheritanceApplication
{
    interface addition
    {
        int add(int a, int b);

        void override result();
    }
    interface subtraction
    {
        int sub(int c, int d);
        void override result();
    }
    interface multiplication
    {
        int mul(int e, int f);
        void result();
    }
    interface division
    {
        int div(int g, int h);
        void result();
    }
    class Calculation : addition, subtraction, multiplication, division
    {
        public int result1;
        public int add(int a, int b)
        {
            return result1 = a + b;
        }
        public int result2;
        public int sub(int c, int d)
        {
            return result1 = c - d;
        }
        public int result3;
        public int mul(int e, int f)
        {
            return result1 = e * f;
        }
        public int result4;
        public int div(int g, int h)
        {
            return result1 = g / h;
        }

        void result()
        { 
            Console.WriteLine(result1);
            
        }

        class Program
        {
            static void Main(string[] args)
            {
                Calculation c = new Calculation();
                c.add(10, 20);
                c.result();
                c.sub(50, 10);
                c.result();
                c.mul(4, 5);
                c.result();
                c.div(50, 10);
                c.result();
                //Console.WriteLine("Multiple Inheritance concept Using Interfaces :\n ");
                //Console.WriteLine("Addition: " + c.result1);
                //Console.WriteLine("Substraction: " + c.result2);
                //Console.WriteLine("Multiplication :" + c.result3);
                //Console.WriteLine("Division: " + c.result4);

            }
        }
    }
}
