using System;
namespace pettern
{ 
    public class a
    {    static void pattern(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || i == n - 1   ||   j == 0 || j == n - 1    ||    i == j || i == n - 1 - j) 
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        public static void Main()
        {
            int n = 9;
            pattern(n);
        }
    }
}
