using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace StarPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            //for (i = 0; i <= norow; i++)
            //{
            //    for (j = 0; j <= norow; j++)
            //    {
            //        if((j == norow) || (j == norow) || (i == norow) || (i == norow) || (i == norow) || (i+j) == (norow + 1))
            //        {
            //            Console.WriteLine("*");
            //        }
            //       else
            //        {
            //            Console.WriteLine(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            for (i = 0; i < 5; i++) 
            {
                for (j = 0; j < 5; j++) 
                {
                    if (i >= 2 && j >= 2 && i <= 4 && i <= 4)
                    {
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine("*");
                    }
                }
                Console.WriteLine();
            }
           
        }
    }
}