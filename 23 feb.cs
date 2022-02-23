// In file datatype, object , type conversion , variable , operators , loop , condition , methods
// no need to write namespace
// HelloWorld

using System;

namespace HelloWorldApplication {
   
   class HelloWorld {
      
      static void Main(string[] args) {
         /* my first program in C# */
         Console.WriteLine("Hello World");
         Console.ReadKey();
      }
   }
}

// RectangleApplication 
using System;

namespace RectangleApplication {
   
   class Rectangle {
      // member variables
      double length;
      double width;
      
      public void Acceptdetails() {
         length = 4.5;    
         width = 3.5;
      }
      
      public double GetArea() {
         return length * width; 
      }
      
      public void Display() {
         Console.WriteLine("Length: {0}", length);
         Console.WriteLine("Width: {0}", width);
         Console.WriteLine("Area: {0}", GetArea());
         Console.WriteLine("Length{0},Width{1},Area{2}",length,width,GetArea());
      }
   }
   
   class ExecuteRectangle {
   
      static void Main(string[] args) {
         Rectangle r = new Rectangle();
         r.Acceptdetails();
         r.Display();
         Console.ReadLine(); 
      }
   }
}

// code of sizeof 
using System;

namespace DataTypeApplication {
   
   class Program {

      static void Main(string[] args) {
         Console.WriteLine("Size of int: {0}", sizeof(int));
         Console.WriteLine("Size of double: {0}", sizeof(double));
         Console.WriteLine("Size of int: {0},Size of double:{1}",sizeof(int),sizeof(double));
         Console.ReadLine();
      }
   }
}

// object

using System;
class a{
    static void Main(string[] args){
      int d = 20;
      Console.WriteLine("d = {0}",d);    
    }  
}

//type conversion

using System;

namespace TypeConversionApplication {

   class ExplicitConversion {
   
      static void Main(string[] args) {
         double d = 5673.74; 
         int i;
         
         // cast double to int.
         i = (int)d;
         Console.WriteLine(i);
         Console.ReadKey();
      }
   }
}

//or 

using System;

namespace TypeConversionApplication {

   class ExplicitConversion {
   
      static void Main(string[] args) {
         int d = 5673; 
         
         Console.WriteLine(d.ToString());
        
         Console.ReadKey();
      }
   }
}


//variables

using System;

namespace VariableDefinition {

   class Program {
   
      static void Main(string[] args) {
         short a;
         int b ;
         double c;

         /* actual initialization */
         a = 10;
         b = 20;
         c = a + b;
         Console.WriteLine("a:{0},b:{0},c:{0}", a, b, c);//a:10,b:10,c:10
         Console.WriteLine("a:{0},b:{1},c:{1}", a, b, c);//a:10,b:20,c:20
         Console.WriteLine("a:{0},b:{1},c:{2}", a, b, c);//a:10,b:20,c:30
         Console.ReadLine();
      }
   }
}

//user side input

using System;

namespace VariableDefinition {

   class Program {
   
     public static void Main(string[] args) {
         string num;--
         Console.WriteLine("enter the number :");
         num = Console.ReadLine();
         Console.WriteLine("enterd '{0}'", num);
      }
   }
}

// Escape symbole

using System;

namespace EscapeChar {

   class Program {
   
      static void Main(string[] args) {
         Console.WriteLine("Hello\nWorld");
         Console.ReadLine();
      }
   }
}

// declare constant

using System;

namespace DeclaringConstants
{

    class Program
    {

        static void Main(string[] args)
        {
            const double pi = 3.14159;

            // constant declaration 
            double r;
            Console.WriteLine("Enter Radius: ");
            r = Convert.ToDouble(Console.ReadLine());
            double areaCircle = pi * r * r;
            Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
            Console.ReadLine();
        }
    }
}

//operator 
  //arithmetic operator(+,-,*,%,/)
  
  using System;
namespace Arithmetic
{
    class GFG
    {
         
        // Main Function
        static void Main(string[] args)
        {
             
            int result;
            int x = 7, y = 17;
             
            // Addition
            result = (x + y);
            Console.WriteLine("Addition Operator: " + result);
             
            // Subtraction
            result = (x - y);
            Console.WriteLine("Subtraction Operator: " + result);
             
            // Multiplication
            result = (x * y);
            Console.WriteLine("Multiplication Operator: "+ result);
             
            // Division
            result = (x / y);
            Console.WriteLine("Division Operator: " + result);
             
            // Modulo
            result = (x % y);
            Console.WriteLine("Modulo Operator: " + result);
        }
    }
}

//relational(==,<,>,>=,<=,!=)

using System;
namespace Relational {
     
class GFG {
     
    // Main Function
    static void Main(string[] args)
    {
        int x = 5, y = 10;
         
    
        Console.WriteLine("Equal to Operator: {0}" , x==y);

        Console.WriteLine("Greater than Operator:  {0}" ,x > y);
 
        Console.WriteLine("Less than Operator: {0} " , x < y);

        Console.WriteLine("Greater than or Equal to: {0} ", x >=y);
        
        Console.WriteLine("Lesser than or Equal to: {0} ", x <= y);

        Console.WriteLine("Not Equal to Operator:  {0}" , x != y);
    }
}
}
  
 //logical (&&,||,!) 
 
 using System;

namespace Tutlane
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 15, y = 10;
            bool a = true, result;
            // AND operator
            result = (x <= y) && (x > 10);
            Console.WriteLine("AND Operator: " + result);
            // OR operator
            result = (x >= y) || (x < 5);
            Console.WriteLine("OR Operator: " + result);
            //NOT operator
            result = !a;
            Console.WriteLine("NOT Operator: " + result);
         
           
        }
    }
}

// Bitwise

using System;
namespace Bitwise {
     
class GFG {
     
    // Main Function
    static void Main(string[] args)
    {
         int x = 5 , y = 10, result;
          
            // Bitwise AND Operator
            // 0101 binary of 5
            // 1010 binary of 10
            //________
            // 1111 binary of 15
            result = x & y;
            Console.WriteLine("Bitwise AND: " + result);

            result = x | y;
            Console.WriteLine("Bitwise OR: " + result);

            result = x ^ y;
            Console.WriteLine("Bitwise XOR: " + result);
 
            result = ~x;
            Console.WriteLine("Bitwise Complement: " + result);

            result = x << 2;
            Console.WriteLine("Bitwise Left Shift: " + result);

            result = x >> 2;
            Console.WriteLine("Bitwise Right Shift: " + result);
         
    }
}
}

//ternary 

using System;
namespace Conditional {
     
class a {
     
    static void Main(string[] args)
    {
            int x = 5, y = 10, result;
             
            
            result = x > y ? x : y;
            Console.WriteLine("Result: " + result);
            
            result = x < y ? x : y;
            Console.WriteLine("Result: " + result);
    }
}
}
 // if else 
	 
using System;


    class Program
    {
        static void Main(string[] args)
        {

            int a = 100;

        if (a < 20)
        {
            Console.WriteLine("a is less than 20");
        }
        else if (a == 20)
        {

            Console.WriteLine("Value of a is 20");
        }
        else
        {
            Console.WriteLine("a is not less than 20");
        }

        }
    }

//	swich case 
// if the any case statement is not there then show next statement
	
	
	using System;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int car = 2;

            switch (car)
            {
                case 1:
                    Console.WriteLine("swift");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("audi");
                    break;
                case 4:
                    Console.WriteLine("bmw");
                    break;
                case 5:
                    Console.WriteLine("harrier");
                    break;
                default:
                    Console.WriteLine("ferari");
                    break;
            }
            
            
        }
    }
}

//Loops
// while loop

using System;

namespace Loops {
   class Program {
      static void Main(string[] args) {
         int a = 1;

         while (a < 5) {
            Console.WriteLine("value of a: {0}", a);
            a++;
         }
         Console.ReadLine();
      }
   }
} 

//for loop 

using System;

namespace Loops {
   class Program {
      static void Main(string[] args) {

         for (int a = 1; a < 5; a = a + 1 /*a++*/) {
            Console.WriteLine("value of a: {0}", a);
         }
         Console.ReadLine();
      }
   }
}

//do while

using System;

namespace Loops {
   class Program {
      static void Main(string[] args) {
    
         int a = 1;
         do {
            Console.WriteLine("value of a: {0}", a);
            a = a + 1; //a++
         } 
         while (a < 5);
         Console.ReadLine();
      }
   }
}

// break statement

using System;

namespace Loops {
   class Program {
      static void Main(string[] args) {
         /* local variable definition */
         int a = 10;
         
         /* while loop execution */
         while (a < 20) {
            Console.WriteLine("value of a: {0}", a);
            a++;
            
            if (a > 15) {
               /* terminate the loop using break statement */
               break;
            }
         }
         Console.ReadLine();
      }
   }
} 

//continue statement

using System;


  class Program
  {
    static void Main(string[] args)
    {
      int i = 1;
      while (i < 10) 
      {
        if (i == 4) 
        {
          i++;
          continue;
        }
        Console.WriteLine(i);
        i++;
      }    
    }
  } 
  
  // Methods
  // calling 
  using System;

namespace call {
    

   class number 
   {
      public int FindMax(int a, int b) 
      {
        
         int result;
         
         if (a > b)
            result = a;
         else
            result = b;
         return result;
      }
      
      static void Main(string[] args) 
      {
         
         int a = 100;
         int b = 200;
         int ret;
         number n = new number();

         
         ret = n.FindMax(a, b);
         Console.WriteLine("Max value is : {0}", ret );
         Console.ReadLine();
      }
   }
}

// passint parameters by value

using System;

     class Program
     {
         static void Main(string[] args)
         {
             int x = 10;
             Console.WriteLine(" Value Before Calling the Method: {0}", x);
             Addition(x);
             Console.WriteLine("Value After Calling the Method: {0}", x);
             
         }
         public static void Addition(int a)
         {
             a = a + 23;
             Console.WriteLine(" Value Inside the Method: {0}", a);
         }
     }

//Passing Parameters by Reference

using System;

     class Program
     {
         static void Main(string[] args)
         {
             int x = 10;
             Console.WriteLine(" Value Before Calling the Method: {0}", x);
             Addition(ref x);
             Console.WriteLine(" Value After Calling the Method: {0}", x);
             
         }
         public static void Addition(ref int a)
         {
              a = a +23;
              Console.WriteLine(" Value Inside the Method: {0}", a);
         }
     }

//Passing Parameters by output

using System;

     class Program
     {
         static void Main(string[] args)
         {
             int x = 10;
             Console.WriteLine(" Value Before Calling the Method: {0}", x);
             Addition(out x);
             Console.WriteLine(" Value After Calling the Method: {0}", x);
             
         }
         public static void Addition(out int a)
         {
              a = a +23;
              Console.WriteLine(" Value Inside the Method: {0}", a);
         }
     }
  