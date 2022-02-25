// interface,Namespaces, Preprocessor Directives, Regular Expressions, Exception Handling, File I/O

using System;
using System.Text.RegularExpressions;
using a;
using b;

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


namespace a
{
	public class abc
	{
		public void sayabc()
		{
			Console.WriteLine("abc Namespace");
		}
	}
}
namespace b
{
	public class xyz
	{
		public void sayxyz()
		{
			Console.WriteLine("xyz Namespace");
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
		Console.WriteLine(" press 1 for interface");
		Console.WriteLine(" press 2 for Namespaces ");
		Console.WriteLine(" press 3 for Preprocessor Directives ");
		Console.WriteLine(" press 4 for  Regular Expressions ");
		Console.WriteLine(" press 5 for Exception Handling ");
		Console.WriteLine(" press 6 for File I/O ");
		Console.WriteLine(" Enter the number between 1 to 6");


		 int number = Convert.ToInt32(Console.ReadLine());

		switch (number)
		{
			case 1://interface
				Rectangle r1 = new Rectangle();
				r1.calculateArea(10, 20);
				break;

			case 2://namespace


				abc h1 = new abc();
				xyz w1 = new xyz();
				h1.sayabc();
				w1.sayxyz();
				break;

			case 3:// Preprocessor Directives
           // #define R


           #if (R)
				Console.WriteLine("a is less than 20");
           #else
						Console.WriteLine("a is not less than 20");           
          #endif

				break;

			case 4://Regular Expressions
				 static void showMatch(string text, string expr)
				{
					//Console.WriteLine("The Expression: " + expr);
					MatchCollection mc = Regex.Matches(text, expr);

					foreach (Match m in mc)
					{
						Console.WriteLine(m);
					}
				}
				string str = "A Thousand Splendid Suns";

				Console.WriteLine("Matching words that start with 'S' and end with 'd' = ");
				showMatch(str, @"\bS\S*d");
				
				break;

			case 5:// Exception handling 
				//string str = "A Thousand Splendid Suns";
				str abc = new str();
				try
				{
					abc.showstring();
				}
				catch (StringIsEmpty e)
				{
					Console.WriteLine("error : {0}", e.Message);
				}
				Console.ReadKey();


				break;

			case 6:// File I/O

				StreamWriter writer = new StreamWriter("C:/xampp/htdocs/stack/abc.txt");
				writer.WriteLine("hello ");
				writer.Close();

				StreamReader reader = new StreamReader("C:/xampp/htdocs/stack/abc.txt");
				string text1 = System.IO.File.ReadAllText("C:/xampp/htdocs/stack/abc.txt");


				System.Console.WriteLine("Contents of abc.txt = {0}", text1);

				break;

			default:
				Console.WriteLine("please enter right choice");
				break;
		}
	}
}




  