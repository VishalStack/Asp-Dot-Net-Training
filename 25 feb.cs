// interface,Namespaces, Preprocessor Directives, Regular Expressions, Exception Handling, File I/O
//interface

using System;
  interface a 
  {
    void name(); 
  }  
  class b : a 
  {
    public void name() 
    {
      
      Console.WriteLine("My name is dhwani patel");
    }
  }
  class c
  {
    static void Main(string[] args) 
    {
      basic fullname = new basic();  
      fullname.name();
    }
  }
 
//namespace

using System;  
using a;  
using b;  
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
public class Test  
{  
    public static void Main()  
    {  
        abc h1 = new abc();  
        xyz w1 = new xyz();  
        h1.sayabc();  
        w1.sayxyz();  
    }  
}  

// Preprocessor Directives

#define R
using System;
    class Program
    {
        static void Main(string[] args)
        {
            #if (R)         
                Console.WriteLine("a is less than 20");          
            #else           
                Console.WriteLine("a is not less than 20");           
            #endif
        }
    }

//Regular Expressions
using System;
using System.Text.RegularExpressions;

namespace RegExApplication
{
    class Program
    {
        private static void showMatch(string text, string expr)
        {
            //Console.WriteLine("The Expression: " + expr);
            MatchCollection mc = Regex.Matches(text, expr);

            foreach (Match m in mc)
            {
                Console.WriteLine(m);
            }
        }
        static void Main(string[] args)
        {
            string str = "A Thousand Splendid Suns";

            Console.WriteLine("Matching words that start with 'S' and end with 'd' = "  );
            showMatch(str, @"\bS\S*d");
            Console.ReadKey();
        }
    }
}	

// Exception handling 

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
                Console.WriteLine("error : {0}", e.Message);
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
            throw (new StringIsEmpty ("String is empty"));
        }
        else
        {
            Console.WriteLine("string: {0}", checkstring);
        }
    }
}

// File I/O

using System;
namespace fileio
{
    class abc
    {
        public static void Main(String[] args)
        {
            StreamWriter writer = new StreamWriter("C:/xampp/htdocs/stack/abc.txt");
            writer.WriteLine("hello ");
            writer.Close();

            StreamReader reader = new StreamReader("C:/xampp/htdocs/stack/abc.txt");
            string text1 = System.IO.File.ReadAllText("C:/xampp/htdocs/stack/abc.txt");


            System.Console.WriteLine("Contents of abc.txt = {0}", text1);
        }
    }
}

  