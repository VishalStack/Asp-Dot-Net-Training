//Nullables, Arrays, Strings, Structures, Enums, Class, Constructors, Destructors, Inheritance, Polymorphism, Operator Overloading, Function Overloading
//nullables
using System;
namespace CalculatorApplication
{
    class NullablesAtShow
    {
        static void Main(string[] args)
        {
            double? num1 = null;
            double? num2 = 5;
            double num3;
            num3 = num1 ?? 6;
            Console.WriteLine(" Value of num3: {0}", num3);
            num3 = num2 ?? 6;
            Console.WriteLine(" Value of num3: {0}", num3);
            Console.ReadLine();
        }
    }
}

//arrays
using System;
namespace ArrayApplication
{
    class MyArray
    {
        static void Main(string[] args)
        {
            string[] name = { "Ekta", "Dhwani", "Naxi", "Yukta", "Vaishali" };
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(name[i]);
            }
        }
    }
}

//using foreach loop
using System;
namespace ArrayApplication
{
	class MyArray
	{
		static void Main(string[] args)
		{
			int [] n = new int[5];
			for (int i = 0; i < 5; i++)
			{
				n[i] = i + 1;
			}
			foreach (int j in n)
			{
				int i = j - 1;
				Console.WriteLine("Element[{0}] = {0}", i, j);
			}
		}
	}
}

//multidimensional array
//2d array
using System;

namespace MultiDArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = { { 2, 3 }, { 4, 5 }, { 6, 7 }, { 8, 9 } };
            Console.WriteLine("Element at index [0, 0] : " + numbers[0, 0]);
            Console.WriteLine("Element at index [0, 1] : " + numbers[0, 1]);
            Console.WriteLine("Element at index [1, 0] : " + numbers[1, 0]);
            Console.WriteLine("Element at index [1, 1] : " + numbers[1, 1]);
            Console.WriteLine("Element at index [2, 0] : " + numbers[2, 0]);
            Console.WriteLine("Element at index [2, 1] : " + numbers[2, 1]);
            Console.WriteLine("Element at index [3, 0] : " + numbers[3, 0]);
            Console.WriteLine("Element at index [3, 1] : " + numbers[3, 1]);
        }
    }
}

//3d array
using System;

namespace MultiDArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] n = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < n.GetLength(0); i++)
            {
                Console.Write("Row " + i + ": ");

                for (int j = 0; j < n.GetLength(1); j++)
                {
                    Console.Write(n[i, j] + " ");

                }
                Console.WriteLine();

            }
        }
    }
}

//jagged array
using System;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {

            // create a jagged array
            int[][] jaggedArray = { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 },

            };

            // print elements of jagged array
            Console.WriteLine("jaggedArray[0][0]: " + jaggedArray[0][0]);
            Console.WriteLine("jaggedArray[0][1]: " + jaggedArray[0][1]);
            Console.WriteLine("jaggedArray[0][2]: " + jaggedArray[0][2]);
            Console.WriteLine("jaggedArray[1][0]: " + jaggedArray[1][0]);
            Console.WriteLine("jaggedArray[1][1]: " + jaggedArray[1][1]);
            Console.WriteLine("jaggedArray[1][2]: " + jaggedArray[1][2]);

        }
    };
}

//passing array as argument
using System;

class MyArray
{
    static void Result(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Array Element: " + arr[i]);
        }

    }
    public static void Main()
    {
        int[] arr = { 5, 10, 15, 20, 25 };

        Result(arr);
    }
}

//paramarray
using System;
namespace Paramarray
{
    class Program
    {

        static void Show(params object[] val)
        {
            for (int i = 0; i < val.Length; i++)
            {
                Console.WriteLine(val[i]);
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Show("Ekta", 21 , "Dhwani" );
        }
    }
}

//string
using System;
namespace MyApplication
{
    class String
    {
        static void Main(string[] args)
        {
            string name = "Ekta Parmar";
            Console.WriteLine("string:"+ name);

          
            
        }
    }
}

//getting substring
using System;
class Program
{
    static void Main(string[] args)
    { 
        string bio = "Ekta Parmar.";
   
        string authorName = bio.Substring(0, 5);
        Console.WriteLine(authorName);
        Console.ReadKey();
    }
}

//join string
using System;
namespace ConsoleApplication
{
    class Stringapp
    {
        static void Main(string[] args)
        {
            object[] array = { "Hello", "Everyone" };

            string s1 = string.Join("-- ", array);

            Console.WriteLine("Value of string  s1 is " + s1);
        }
    }
}

//structure
using System;
namespace ConsoleApplication;
public struct Person
{
    public string Name;
    public int Age;
    public int Weight;

}
class Employee
{
    static void Main(string[] args)
    {
        Person P1;

        P1.Name = "Ekta Parmar";
        P1.Age = 20;
        P1.Weight = 45;

        // Displaying the values
        Console.WriteLine("Employee Name is " + P1.Name + ", Age is " + P1.Age + " and Weight is  " + P1.Weight);

    }
}

//constructor
using System;

namespace Constructor
{
    class User
    {
        public string name, location;
        public User()
        {
            name = "Ekta Parmar";
            location = "Ahmedabad";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            User user = new User();
            Console.WriteLine(user.name);
            Console.WriteLine(user.location);
           
        }
    }
}

//destructor
using System;  
namespace CsharpDestructor {
  
  class Person {

    public Person() {
      Console.WriteLine("Constructor called.");
    }
    
    // destructor
    ~Person() {
      Console.WriteLine("Destructor called.");
    }

    public static void Main(string [] args) {

      //creates object of Person
      Person p1 = new Person();
    }
  } 
}

//inheritance
using System;
namespace Inheritance
{
    public class Employee
    {
        public float salary = 25000;
    }
    public class Programmer : Employee
    {
        public float bonus = 5000;
    }
    class TestInheritance
    {
        public static void Main(string[] args)
        {
            Programmer p1 = new Programmer();

            Console.WriteLine("Salary: " + p1.salary);
            Console.WriteLine("Bonus: " + p1.bonus);

        }
    }
}

//polymorphism
//function overloading
using System;
namespace Overloading
{
    public class Demo
    {
        public static int mulDisplay(int one, int two)
        {
            return one * two;
        }

        public static int mulDisplay(int one, int two, int three)
        {
            return one * two * three;
        }

    }

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Multiplication of two numbers: " + Demo.mulDisplay(5, 10));
            Console.WriteLine("Multiplication of three numbers: " + Demo.mulDisplay(2, 3, 4));
        }
    }
}

//operator overloading
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
        static void Main(String[] args)
        {
            Calculator calc = new Calculator(20, -30);

            calc = -calc;

            calc.Print();
        }
    }
}
