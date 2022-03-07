using System;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            for(int i = 0; i < 9; i++)
            {
                for(int j=0;j< 9; j++)
                {
                    if(i==j || i + j == 8)
                    {
                        Console.Write(" * ");
                    }
                    else if(i==0 || i == 8 || j==0 || j==8)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine("\n");
            }
            
        }
    }
}
