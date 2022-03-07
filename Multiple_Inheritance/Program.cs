using System;

namespace Multiple_Inheritance
{
    interface Join
    {
        void Display();
    }
    class First : Join
    {
        public void Display()
        {
            Console.WriteLine("First method is called");
        }
    }
    class Second : Join
    {
        public void Display()
        {
            Console.WriteLine("Second method is called");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Join u = new First();
            u.Display();
            Join u1 = new Second();
            u1.Display();
           
            Console.ReadLine();
        }
    }


}
