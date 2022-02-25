//Interfaces, Namespaces, Preprocessor Directives, Regular Expressions, Exception Handling, File I/O
//interfaces
using System;
namespace Csharp
{
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

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.calculateArea(10, 20);
        }
    }
}

//namespace
using System;
namespace firstspace
{
   class first
    {
        public void func()
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
class TestClass
{
static void Main(string[] args)
{
    first fc = new first();
    second sc = new second();
    fc.func();
    sc.func();
}
}

//preprocessor #define PI
using System;
namespace PreprocessorDAppl
{
    class Program
    {
        static void Main(string[] args)
        {
            #if (PI)
             Console.WriteLine("PI is defined");
            #else
             Console.WriteLine("PI is not defined");
            #endif
             Console.ReadKey();
        }
    }
}

//regular expression
using System;
using System.Text.RegularExpressions;
namespace RegExApplication
{
    class Program
    {
        private static void showMatch(string text, string expr)
        {
            Console.WriteLine("The Expression: " + expr);
            MatchCollection mc = Regex.Matches(text, expr);
            foreach (Match m in mc)
            {
                Console.WriteLine(m);
            }
        }
        static void Main(string[] args)
        {
            string str = "abbc axz bak lia apqkc well opa ayzc ac";
            Console.WriteLine("Matching words start with 'a' and ends with 'c':");
            showMatch(str, @"\ba\S*c\b");
            
        }
    }
}

//exception handling
using System;
namespace UserDefinedException
{
    class Teststring
    {
        static void Main(string[] args)
        {
            str abc = new str();
            try
            {
                abc.showstring();
            }
            catch (StringIsEmpty e)
            {
                Console.WriteLine("Error caught : {0}", e.Message);
            }
            Console.ReadKey();
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

//file i/o
using System;
namespace filestream
{
    class stream {

        public static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter("C:/xampp/htdocs/stack summation/ekta.txt");
            writer.WriteLine("File created using StreamWriter class. Hello Ekta");
            writer.Close();

            StreamReader reader = new StreamReader("C:/xampp/htdocs/stack summation/ekta.txt");
            string text1 = System.IO.File.ReadAllText("C:/xampp/htdocs/stack summation/ekta.txt");

            System.Console.WriteLine("Contents of names.txt = {0}", text1);
        }

       
    }
}