//Nullables, Arrays, Strings, Structures, Enums, Class, Constructors, Destructors, Inheritance, Polymorphism, Operator Overloading, Function Overloading

//nullables
//< data_type> ? <variable_name> = null;
// string is not nullables value
using System;

namespace CalculatorApplication {

   class NullablesAtShow {
   
      static void Main(string[] args) {
         int? num1 = null;
         int? num2 = 45;
         float? num3 = 0;
         double? num4 = 3.14157;
         
         
         Console.WriteLine("Nullables value: {0}, {1}, {2}, {3}", num1, num2, num3, num4); //Nullables value: , 45, 0, 3.14157
       
         
      }
   }
}
//null coalescing operator is used  the nullable value types and reference types
using System;

namespace CalculatorApplication {
   class NullablesAtShow {
      static void Main(string[] args) {
         double? num1 = null;
         double? num2 = 3.14157;
         double num3;
         
         num3 = num1 ?? 5.34;      
         Console.WriteLine(" Value of num3: {0}", num3); //Value of num3: 5.34

         
         num3 = num2 ?? 5.34;
         Console.WriteLine(" Value of num3: {0}", num3);//Value of num3: 3.14157
         Console.ReadLine();
      }
   }
}

//Array
// 1d array
using System;

namespace ArrayApplication {
   class MyArray {
      static void Main(string[] args) {
         int i;
         int[] array = new int[5] {1,3,5,7,9};
         for (i=0;i<=5;i++)
         {
             Console.WriteLine(i);
         }

      }
   }
}

//foreach in array

using System;

namespace ArrayApplication {
   class MyArray {
      static void Main(string[] args) {
         int[] n = new int[5] {1,3,5,7,9};
         
         foreach(int j in n)
         {
             Console.WriteLine(j);
         }

      }
   }
}
//multidimentional array 
namespace ArrayApplication {
   class MyArray {
      static void Main(string[] args) {
         int i,j; 
         int[,] n = new int[5,2] {{1,1},{3,2},{5,7},{7,5},{9,57}};
         
         for (i=0 ;i<5;i++)
         {
             for(j=0;j<2;j++)
             {
                 
               Console.WriteLine("n[{0},{1}] = {2}",i,j,n[i,j]);  
             }
         }
      }
   }
}

//jagged array
using System;

namespace Array {
   class MyArray {
      static void Main(string[] args) {
         int i,j; 
         int[][] n = new int[][] {new int[]{1,1},new int[]{3,2},new int[]{5,7},new int[]{7,5},new int[]{9,57}};
         
         for (i=0 ;i<5;i++)
         {
             for(j=0;j<2;j++)
             {
                 
               Console.WriteLine("n[{0}][{1}] = {2}",i,j,n[i][j]);  
             }
         }
      }
   }
}

// passing array as function argument
using System;  
public class Array  
{  
    static void printArray(int[] array)  
    {  
        Console.WriteLine("Printing array value:");  
        for (int i = 0; i < array.Length; i++)  
        {  
              Console.WriteLine(array[i]);  
        }  
    }  
    public static void Main(string[] args)  
    {  
        int[] array = { 25, 10, 20, 15, 40, 50 };  
        printArray(array);  
      
    }  
}

// params array
using System;  
public class Array  
{  
    static void printArray( params int[] array )  
    {  
        Console.WriteLine("Printing array value:");  
        for (int i = 0; i < array.Length; i++)  
        {  
              Console.WriteLine(array[i]);  
        }  
    }  
    public static void Main(string[] args)  
    {  
        int[] array = { 29, 10, 20, 15, 40, 50 }; 
        
        printArray(array); 
        
      
    }  
}  

//string 

using System; 

namespace Stringapp  
{  
    class xyz
   {
            
    static void Main(string[] args)  
    {  
        
             string a= "dhwani" ;
             Console.WriteLine(a);
			 Console.WriteLine(a.Length);
            
    }
      
    }  
}

//string matching
using System;
namespace strings
{
    class str
    {
        static void Main(string[] args)
        {
            string s1 = "dhwani";
            string s2 = "patel";

            if (string.Compare(s1, s2) == 0)
            {
                Console.WriteLine(" strings are same");
            }
            else
            {
                Console.WriteLine("strings are different");
            }

        }
    }
}

//substring
using System;
namespace strings
{
    class str
    {
        static void Main(string[] args)
        {
            string s1 = "dhwani patel";
            string ss = s1.Substring(3 ,8);
            Console.WriteLine(ss);


        }
    }
}

//join 

using System;
public class StringExample
{
    public static void Main(string[] args)
    {
        string[] s1 = { "dhwani", "patel" };
        string s2 = string.Join("-", s1);
        Console.WriteLine(s2);
    }
}

//structure

using System;
namespace ConsoleApplication {
 

public struct Car
{
   
    public string Name;
    public int Model;
    public int Color;
 
}
 
class Geeks {
     
    
    static void Main(string[] args)
    {
 
        
        Car c;
 
        
        c.Name = "Audi";
        c.Model = Q5;
        c.Color = "Black";
 
        
        Console.WriteLine("Car name is" + c.Name + " & Model is" + c.Model+" & color is" + c.Color);
 
    }
}
}

//Enums
using System;
public class Enum 
{
    public enum Seasons { WINTER, SPRING, SUMMER, FALL }

    public static void Main()
    {
        int x = (int)Seasons.WINTER;
        int y = (int)Seasons.FALL;
        Console.WriteLine("WINTER = {0}", x);
        Console.WriteLine("FALL = {0}", y);
    }
}

//class 
// constructor

using System;
 class constructor
{
    public constructor()
    {
        Console.WriteLine("Constructor ");
    }
    public static void Main(string[] args)
    {
        constructor c = new constructor();
        
    }
}

//destructor
using System;
 class destructor
{
    ~destructor()
    {
        Console.WriteLine("destructor");
    }
    public static void Main(string[] args)
    {
        destructor d = new cdestructor();
        
    }
}

//inheritance

using System;
namespace Inheritance
{
    public class parent
    {
          public string name = "dhwani";
    }
    public class child : parent
    {
       
    }
    class TestInheritance
    {
        public static void Main(string[] args)
        {
            child c1 = new child();
            Console.WriteLine("My name is " + c1.name);
            
        }
    }
}

// function overloading 


using System;
public class overloading 
{
   public static int add(int one, int two) 
   {
      return one + two;
   }

   public static int add(int one, int two, int three) 
   {
      return one + two + three;
   }
   
   
}

public class Program 
{
   public static void Main() 
   {
      Console.WriteLine("addition of two numbers: "+overloading.add(10, 20));
      Console.WriteLine("addition of three numbers: "+overloading.add(10, 30, 20));
     
   }
}

// operator overloading

using System;
namespace Calculator
{

    class Calculator
    {

        public int number1, number2;
        public Calculator(int num1, int num2)
        {
            number1 = num1;
            number2 = num2;
        }


        public static Calculator operator -(Calculator c1)
        {
            c1.number1 = -c1.number1;
            c1.number2 = -c1.number2;
            return c1;
        }


        public void Print()
        {
            Console.WriteLine("Number1 = " + number1);
            Console.WriteLine("Number2 = " + number2);
        }
    }

    class EntryPoint
    {

        static void Main(string[] args)
        {


            Calculator calc = new Calculator(50, -5);

            calc = -calc;


            calc.Print();
        }
    }
}





