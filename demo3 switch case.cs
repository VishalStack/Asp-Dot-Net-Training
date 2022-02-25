//Interfaces, Namespaces, Preprocessor Directives, Regular Expressions, Exception Handling, File I/O
using System;
using firstspace;
using secondspace;
using System.Text.RegularExpressions;

interface IPolygon
{
	void calculateArea(int l, int b);
}

class Rectangle : IPolygon
{
	public void calculateArea(int l, int b)
	{
		int area = l * b;
		Console.WriteLine("Area of Rectangle: " + area);
	}
}


namespace firstspace
{
	class first
	{
		public void func1()
		{
			Console.WriteLine("This is firstspace");
		}
	}
}
namespace secondspace
{
	class second
	{
		public void func()
		{
			Console.WriteLine("This is secondspace");
		}
	}
}

public class StringIsEmpty : Exception
{
	public StringIsEmpty(string message) : base(message)
	{
	}
}

public class str
{
	string checkstring = " ";
	public void showstring()
	{
		if (checkstring == " ")
		{
			throw (new StringIsEmpty("String is empty"));
		}
		else
		{
			Console.WriteLine("string: {0}", checkstring);
		}
	}
}

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Select the number of operations which you want to see the example");
		Console.WriteLine("1. Interface");
		Console.WriteLine("2. namespace");
		Console.WriteLine("3. preprocessor");
		Console.WriteLine("4. Regular Expression");
		Console.WriteLine("5. Exception Handling");
		Console.WriteLine("6. File I/O");
		Console.WriteLine("Enter any number between 1 to 6 : ");
		int num = Convert.ToInt32(Console.ReadLine());

		switch (num)
		{
			case 1:
				//interface

				Rectangle r1 = new Rectangle();
				r1.calculateArea(10, 20);

				break;


			case 2:
				//namespace

				first fc = new first();
				second sc = new second();
				fc.func1();
				sc.func();

				break;


			case 3:
				//preprocessor #define PI

				#if (PI)
					 Console.WriteLine("PI is defined");
				#else
		       		Console.WriteLine("PI is not defined");
				#endif
				    Console.ReadKey();

				break;


			case 4:
				//regular expression

				 static void showMatch(string text, string expr)
					{
						Console.WriteLine("The Expression: " + expr);
						MatchCollection mc = Regex.Matches(text, expr);
						foreach (Match m in mc)
						{
						Console.WriteLine(m);
						}
					}
				
					string str = "abbc axz bak lia apqkc well opa ayzc ac";
					Console.WriteLine("Matching words start with 'a' and ends with 'c':");
					showMatch(str, @"\ba\S*c\b");

				break;

			case 5:
				//exception handling

				str abc = new str();
				try
				{
					abc.showstring();
				}
				catch (StringIsEmpty e)
				{
					Console.WriteLine("Error caught : {0}", e.Message);
				}

				break;

			case 6:
				//file i/o

				StreamWriter writer = new StreamWriter("C:/xampp/htdocs/stack summation/ekta.txt");
				writer.WriteLine("File created using StreamWriter class. Hello Ekta");
				writer.Close();

				StreamReader reader = new StreamReader("C:/xampp/htdocs/stack summation/ekta.txt");
				string text1 = System.IO.File.ReadAllText("C:/xampp/htdocs/stack summation/ekta.txt");

				System.Console.WriteLine("Contents of names.txt = {0}", text1);

				break;

			default:
				Console.WriteLine("Please enter a valid number");
				break;
		}
	}
}