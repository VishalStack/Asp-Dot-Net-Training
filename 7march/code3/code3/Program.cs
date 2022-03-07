using System;
namespace InheritanceApp
{
    public class parent1
    {
        public string fname = "dhwani";
        public string lname = "patel";
    }
    public interface parent2
    {
        
    }

    public class child : parent1, parent2
    {
        public int i = 10;
    }
    class TestInheritance
    {
        public static void Main(string[] args)
        {
            child c1 = new child();
            Console.WriteLine("My Name is " + c1.fname + " "+ c1.lname + ".");
            Console.WriteLine("I am a" + " "+ c1.i + " Years old.");

        }
    }
}
