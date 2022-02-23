using System;

namespace TypeConversionApplication {
   
   class StringConversion {
      
      static void Main(string[] args) {
		  
		 //type-conviesion
         
		 int i = 75;
         float f = 53.005f;
         double d = 2345.7652;
         bool b = true;

         Console.WriteLine(i.ToString());
         Console.WriteLine(f.ToString());
         Console.WriteLine(d.ToString());
         Console.WriteLine(b.ToString());
         
         Console.WriteLine((int)(f));
         Console.WriteLine((double)(f));
         Console.WriteLine((float)(i));
        
		 
		 //constants
		 
		 const double pi = 3.14;   
		 double r;
         Console.WriteLine("Enter Radius: ");
         r = Convert.ToDouble(Console.ReadLine());
         double areaCircle = pi * r * r;
         Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
		 
		 //operators
			
            int a, x, c;
            a = 7;
            x = a;
            c = x++;
            x = a + x * c;
            a = (int)Math.Sqrt(x + c);
			Console.WriteLine(a);
            
			string s = "String literal";
            char l = s[s.Length - 1];
            Console.WriteLine(l);
            
			var numbers = new List<int>(new[] { 1, 2, 3 });
            x = numbers.FindLast(n => n > 1);
            Console.WriteLine(x);

			
		 
		 //loops using one guessing game
		 
			int count = 3;
            int guess = 10;
           
            if(count>0)
            {
                for (int j = 0; j < count; j++)
                {
                    Console.Write("guess the number:");
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num > guess)
                    {
                        Console.WriteLine("you have to guess the smaller one");
                    }
                    if (num < guess)
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
			
			//Encapsulation
		 
            showName_public sn = new showName_public();// Public Specifiers
			showName_private sp = new showName_private();// private specifiers
			showName_protected st = new showName_protected();// protected specifiers
            Console.Write("Enter your name:\n");
            
            sn.name = Console.ReadLine();
            sn.print();
			sp.name = Console.ReadLine();
            sp.print();
			st.name = Console.ReadLine();
            st.print();
			
			//Methods overriding
			
			SimpleMath obj = new SimpleMath();
            int result = obj.AddTwoNumbers(1, 2);
            result = obj.SquareANumber(result);
            
            Console.WriteLine(result);
			
			Console.Write("enter 1st number:");
			int num1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("enter 2nd number:");
			int num2 = Convert.ToInt32(Console.ReadLine());
			
			NumberManipulator n = new NumberManipulator();
			int ret = n.FindMax(num1, num2);
			Console.WriteLine(ret);
		
		Console.ReadLine();
            
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
        
			private string name;
			public void print() 
			{
            Console.WriteLine("\nMy name is " + name);
			}
		}
		class showName_protected
		{
        
			protected string name;
			public void print() 
			{
            Console.WriteLine("\nMy name is " + name);
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
}