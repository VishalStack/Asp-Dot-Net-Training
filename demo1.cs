//datatypes, typeconversion, variable, constant, opeartor, decision making, loops, methods 
//basic syntax
using System;

namespace HelloWorldApplication {
   
   class HelloWorld {

      static void Main(string[] args) {
        
         Console.WriteLine("Hello World");
         Console.ReadKey();
      }
   }
}

using System;

namespace RectangleApplication {
   
   class Rectangle {
      // member variables
      double length;
      double width;
      
      public void Acceptdetails() {
         length = 5;    
         width = 4;
      }
      
      public double GetArea() {
         return length * width; 
      }
      
      public void Display() {
         Console.WriteLine("Length: {0}", length);
         Console.WriteLine("Width: {0}", width);
         Console.WriteLine("Area: {0}", GetArea());
		 Console.WriteLine("Length:{0}, Width:{1}, Area:{2}", length,width,GetArea());
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

//data types
using System;

namespace DataTypeApplication {
   
   class Program {

      static void Main(string[] args) {
         Console.WriteLine("Size of int: {0}", sizeof(int));
         Console.WriteLine("Size of float: {0}", sizeof(float));
         Console.WriteLine("Size of double: {0}", sizeof(double));
         Console.ReadLine();
      }
   }
}

//object
using System;
class a{
    public void Main(string[] args){
        int d = 10;
        Console.WriteLine("d = {0}" ,d);
    }
}

//type conversion
using System;

namespace TypeConversionApplication {
   
   class StringConversion {
      
      static void Main(string[] args) {
         int i = 75;
         float f = 53.005f;
         double d = 2345.7652;
         bool b = true;

         Console.WriteLine(i.ToString());
         Console.WriteLine(f.ToString());
         Console.WriteLine(d.ToString());
         Console.WriteLine(b.ToString());
         Console.ReadKey();
         
         Console.WriteLine((int)(f));
         Console.WriteLine((int)(d));
         Console.WriteLine((float)(i));
         Console.WriteLine((float)(d));
         Console.WriteLine((double)(i));
         Console.WriteLine((double)(f));
            
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
         double c, d, e, f;

         /* actual initialization */
         a = 50;
         b = 20;
         c = a + b;
         d = a - b;
         e = a * b;
         f = a / b;
         Console.WriteLine("a = {0}, b = {1}, c = {2}, d = {3}, e = {4}, f = {5}", a, b, c, d, e, f);
         Console.ReadLine();
      }
  }
}

//literals
using System;

namespace EscapeChar {

   class Program {
   
      static void Main(string[] args) {
         Console.WriteLine("Hello World\n\n");
         Console.ReadLine();
      }
   }
}

//constants
using System;

namespace DeclaringConstants
{

    class Program
    {

        static void Main(string[] args)
        {
            const double pi = 3.14159;

            // constant declaration 
            double r = 2;
            Console.WriteLine("Enter Radius: ");
            r = Convert.ToDouble(Console.ReadLine());
            double areaCircle = pi * r * r;
            Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
            Console.ReadLine();
        }
    }
}

//operator
//Arithmetic operator
using System;

namespace Arithmetic
{
    class Operator{

        static void Main(string[] args)
        {

            int x = 10, y = 10, z;

            z = (x + y);
            Console.WriteLine("Addition Operator: " + z);

            z = (x - y);
            Console.WriteLine("Subtraction Operator: " + z);

            z = (x * y);
            Console.WriteLine("Multiplication Operator: " + z);

            z = (x / y);
            Console.WriteLine("Division Operator: " + z);

            z = (x % y);
            Console.WriteLine("Modulo Operator: " + z);
        }
    }
}

//Unary operator
using System;
namespace Arithmetic
{

    class Opreator
    {

        static void Main(string[] args)
        {

            int a = 20, b;
            b = a++;
            Console.WriteLine("a is {0} and b is {1}", a, b);

            b = a--;
            Console.WriteLine("a is {0} and b is {1}", a, b);

            b = ++a;
            Console.WriteLine("a is {0} and b is {1}", a, b);

            b = --a;
            Console.WriteLine("a is {0} and b is {1}", a, b);


        }
    }
}

//Relational operator
using System;
namespace Relational {
     
class Operator {
     
    static void Main(string[] args)
    {
        bool result;
        int x = 5, y = 10;
         
        result = (x == y);
        Console.WriteLine("Equal to Operator: " + result);
         
        result = (x > y);
        Console.WriteLine("Greater than Operator: " + result);
  
        result = (x < y);
        Console.WriteLine("Less than Operator: " + result);
         
        result = (x >= y);
        Console.WriteLine("Greater than or Equal to: "+ result);
  
        result = (x <= y);
        Console.WriteLine("Lesser than or Equal to: "+ result);
  
        result = (x != y);
        Console.WriteLine("Not Equal to Operator: " + result);
    }
}
}

//Logical operator
using System;

namespace Logical
{
    class Operator
    {
        static void Main(string[] args)
        {
            int x = 15, y = 10;
            bool a = true, result;
            
            result = (x <= y) && (x > 10);
            Console.WriteLine("AND Operator: " + result);
            
            result = (x >= y) || (x < 5);
            Console.WriteLine("OR Operator: " + result);
         
            result = !a;
            Console.WriteLine("NOT Operator: " + result);
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}

//Bitwise opeartor
using System;
namespace Bitwise {
     
class Operator {
     
    static void Main(string[] args)
    {
         int x = 5, y = 10, result;
          
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

//Conditional operator
using System;
namespace Conditional
{

    class Operator
    {

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

//DecisionMaking
//if..else
using System;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;

            if (a < 10)
            {
                Console.WriteLine("a is less than 10");
            }
            else
            {
                Console.WriteLine("a is not less than 10");
            }
            Console.WriteLine("value of a is : {0}", a);
            Console.ReadLine();
        }
    }
}

//if..elseif
using System;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            if (a == 100)
            {
                Console.WriteLine("Value of a is 100");
            }
            else if (a == 200)
            {
                Console.WriteLine("Value of a is 200");
            }
            else if (a == 300)
            {
                Console.WriteLine("Value of a is 300");
            }
            else
            {
                Console.WriteLine("None of the values is matching");
            }
            Console.WriteLine("Exact value of a is: {0}", a);
            Console.ReadLine();
        }
    }
}

//nested if
using System;

namespace DecisionMaking {
   class Program {
      static void Main(string[] args) {
   
         int a = 100;
         int b = 200;
   
         if (a == 100) {
            if (b == 200) {
               Console.WriteLine("Value of a is 100 and b is 200");
            }
         }
         Console.WriteLine("Exact value of a is : {0}", a);
         Console.WriteLine("Exact value of b is : {0}", b);
         Console.ReadLine();
      }
   }
}

//switch statement
using System;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            /* local variable definition */
            int grade = 2;

            switch (grade)
            {
                case 1:
                    Console.WriteLine("Excellent!");
                    break;
                case 2:
                    Console.WriteLine("Good");
                    break;
                case 3:
                    Console.WriteLine("Well done");
                    break;
                case 4:
                    Console.WriteLine("You passed");
                    break;
                case 5:
                    Console.WriteLine("Better try again");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }
            Console.WriteLine("Your grade is  {0}", grade);
            Console.ReadLine();
        }
    }
}

//nested switch
using System;

namespace DecisionMaking {
   class Program {
      static void Main(string[] args) {
         int a = 100;
         int b = 200;
         
         switch (a) {
            case 100: 
            Console.WriteLine("This is part of outer switch ");
            
            switch (b) {
               case 200:
               Console.WriteLine("This is part of inner switch ");
               break;
            }
            break;
         }
         Console.WriteLine("Exact value of a is : {0}", a);
         Console.WriteLine("Exact value of b is : {0}", b);
         Console.ReadLine();
      }
   }
}

//loop
//while
using System;

namespace Loops {
   class Program {
      static void Main(string[] args) {
    
         int a = 5;

         while (a < 10) {
            Console.WriteLine("value of a: {0}", a);
            a++;
         }
         Console.ReadLine();
      }
   }
}

//forloop
using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a < 5; a = a + 1)
            {
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
         int a = 10;
         
         do {
            Console.WriteLine("value of a: {0}", a);
            a = a + 1;
         } 
         while (a < 20);
         Console.ReadLine();
      }
   }
} 

//break
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

//continue
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int i = 0;
      while (i < 10) 
      {
        if (i == 6) 
        {
          i++;
          continue;
        }
        Console.WriteLine(i);
        i++;
      }    
    }
  }
}

//methods
using System;

namespace CalculatorApplication {

   class NumberManipulator {
   
      public int FindMin(int num1, int num2) {
 
         int result;
         
         if (num1 < num2)
            result = num1;
         else
            result = num2;
         return result;
      }
      
      static void Main(string[] args) {
         int a = 100;
         int b = 200;
         int value;
         NumberManipulator n = new NumberManipulator();

         value = n.FindMin(a, b);
         Console.WriteLine("Min value is : {0}", value );
         Console.ReadLine();
      }
   }
}

//pass by value
using System;

namespace Passbyvalue
{
    class Program
    {
        public static void Area(int a)
        {
            Console.WriteLine("Adding 2 to the value of a");
            a = a + 2;
            Console.WriteLine("New value of a: " + a);
            Console.WriteLine("Calculating the area of geometric shapes");
            int result = a * a;
            Console.WriteLine("Area of Square is " + result);
        }

        static void Main(string[] args)
        {
            int s = 18;
            Area(s);
            Console.WriteLine("Side Value is " + s);
            Console.ReadKey();
        }
    }
}

//pass by reference
using System;

namespace Passbyreference
{
    public class Program
    {
        public static void Area(ref int a)
        {
            Console.WriteLine("Calculating Area of Geometric Shapes");
            a = a * a;
            Console.WriteLine("Area of Square is " + a);
        }

        public static void Main()
        {
            int s = 20;
            Area(ref s);
            Console.WriteLine("Side Value is " + s);
        }
    }
}

//pass by output
using System;

namespace Passbyoutput
{
    public class Program
    {
        public static void Area(out int a)
        {
            a = 50;
            Console.WriteLine("Calculating Area of Geometric Shapes");
            a = a * a;
            Console.WriteLine("Area of Square is " + a);
        }
        public static void Main()
        {
            int s;
            Area(out s);
            Console.WriteLine("Side Value is " + s);
            Console.ReadKey();
        }
    }
}

