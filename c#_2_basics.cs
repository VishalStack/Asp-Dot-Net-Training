using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1

{
    class Animal
    {
        public virtual void eat()
        {

            Console.WriteLine("I eat food");
        }
    }
    class Dog : Animal
    {
        public override void eat()
        {
            base.eat();
            Console.WriteLine("I eat Dog food");
        }
    }

    public class Calculate
    {
        public void AddNumbers(int a, int b)
        {
            Console.WriteLine("a + b = {0}", a + b);
        }
        public void AddNumbers(int a, int b, int c)
        {
            Console.WriteLine("a + b + c = {0}", a + b + c);
        }
    }
    public enum Days
    {
        None = 0,
        Monday =1,  
        Tuesday = 2, 
        Wednesday = 3,  
        Thursday = 4,  
        Friday = 5,  
        Saturday = 6,  
        Sunday = 7, 
        Weekend = Saturday | Sunday
    }
    class MyArr
    {
        double getAverage(int[] arr, int size)
        {
            int i;
            double avg;
            int sum = 0;

            for (i = 0; i < size; ++i)
            {
                sum += arr[i];
            }
            avg = (double)sum / size;
            return avg;
        }
    }

    class Program
    {
        public readonly struct Coords
        {
            public Coords(double x, double y)
            {
                X = x;
                Y = y;
            }

            public double X { get; init; }
            public double Y { get; init; }

            public override string ToString() => $"({X}, {Y})";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Select the number of operations which you want to see the example");
            Console.WriteLine("1. Nullable");
            Console.WriteLine("2. Arrays");
            Console.WriteLine("3. Strings");
            Console.WriteLine("4. Structure");
            Console.WriteLine("5. Enums");
            Console.WriteLine("6. Inheritance");
            Console.WriteLine("7. Polymorphism");
            int num = Convert.ToInt32(Console.ReadLine());



            switch (num)
            {
                case 1: //Nullable
                    int? d2 = null;

                    double? x;
                    x = 25;
                    x = null;

                    bool? b;
                    b = true;
                    b = null;

                    float? f;
                    f = null;

                    Console.WriteLine("");

                    Console.WriteLine("integer variable value converts into .. = {0}", d2);
                    Console.WriteLine("double variable value 25 converts into ..= {0}", x);
                    Console.WriteLine("bool variable value true converts into ..= {0}", b);
                    Console.WriteLine("float variablevalue converts into .. = {0}", f);
                    Console.WriteLine("");

                    Console.WriteLine("Conclusion:");
                    Console.WriteLine("we cant convert int-float-double-bool direct into null value.");
                    Console.WriteLine("But we can do it by placing ? after data types.");

                    int? t = null;
                    Console.WriteLine("t= {0}", t);
                    if (t.HasValue)
                        Console.WriteLine("We can say  that =>  t != null");
                    else
                        Console.WriteLine("We can say  that => t == null");

                    break;
                case 2: //Arrays


                    Console.WriteLine("");
                    Console.WriteLine("How many numbers you want to enter in array:");
                    int n = Convert.ToInt32(Console.ReadLine());

                    int[] arr = new int[n];

                    for (int k = 0; k < n; k++)
                    {
                        Console.WriteLine("enter {0} element:", k + 1);
                        int numb = Convert.ToInt32(Console.ReadLine());
                        ;
                        // Console.WriteLine(arr[k]);
                    };

                    Console.WriteLine("array is : {0}", arr);

                    System.Console.WriteLine();

                    // Jagged array

                    Console.WriteLine("aray = 1   2   6   8");
                    Console.WriteLine("     = 72  51  47  23");

                    int[][] array = new int[2][];
                    array[0] = new int[] { 1, 2, 6, 8 };
                    array[1] = new int[] { 72, 51, 47, 23 };

                    for (int i = 0; i < array.Length; i++)
                    {
                        for (int j = 0; j < array[i].Length; j++)
                        {
                            System.Console.Write(" at row = {0} col = {1} : element is {2}", i + 1, j + 1, array[i][j] + " ");
                            System.Console.WriteLine();
                        }
                        System.Console.WriteLine();
                    }

                    /*MyArr app = new MyArr();


                    int[] balance = new int[] { 1000, 2, 3, 17, 50 };
                    double avg;
                    avg = app.getAverage(balance, 5);
                    */

                    //Console.WriteLine("Average value is: {0} ", avg);
                    //Console.ReadKey();

                    //params

                    ParamsMethod(1, 2, "suresh", "rohini", "trishika", 10.26);



                    break;
                case 3://Strings
                    string firstname = "Naxi";
                    string lastname = "Shah";
                    string location = "Ahmedabad";
                    string name = firstname + " " + lastname;
                    Console.WriteLine("firstname : {0}", firstname);
                    Console.WriteLine("lasttname : {0}", lastname);
                    Console.WriteLine("location : {0}", location);
                    Console.WriteLine("fullname : {0}", name);
                    string userInfo = string.Format("Name: {0}, Location: {1}", name, location);

                    string msg1 = "Welcome";
                    string msg2 = " " + "Naxi";
                    Console.WriteLine("msg1 : {0}", msg1);
                    Console.WriteLine("msg2 : {0}", msg2);
                    Console.WriteLine("msg1 length : {0}", msg1.Length);
                    Console.WriteLine("Message: {0}", string.Concat(msg1, msg2));


                    string msg = "hey there";
                    string subtxt = "hey";
                    Console.WriteLine("Does {0} String Contains {1}?: {2}", msg, subtxt, msg.Contains(subtxt));
                    string subtxt1 = "heya";
                    Console.WriteLine("Does {0} String Contains {1}?: {2}", msg, subtxt1, msg.Contains(subtxt1));

                    Console.ReadLine();
                    break;
                case 4: //structure
                    var p1 = new Coords(0, 0);
                    Console.WriteLine(p1);

                    var p2 = new Coords { X = 3, Y = 0 };
                    Console.WriteLine(p2);

                    var p3 = new Coords { X = 1, Y = 4 };
                    Console.WriteLine(p3);

                    break;
                case 5: //enums


                    Days[] meetingDays = { Days.Monday, Days.Wednesday, Days.Friday };
                    Console.WriteLine("meetingsDays = {0}", meetingDays);
                    Days value = Days.Tuesday;
                    int index = Array.IndexOf(meetingDays, value);
                    if (index > -1)
                    {
                        Console.WriteLine("there is a meeting on Tuesday");
                    }
                    else
                    {
                        Console.WriteLine("No meetings on Tuesday");
                    }

                    break;

                case 6://Inheritance

                    Dog labrador = new Dog();
                    labrador.eat();
                    break;

                case 7://polymorphism

                    Calculate c = new Calculate();
                    c.AddNumbers(1, 2);
                    c.AddNumbers(1, 2, 3);
                    Console.WriteLine("\nPress Enter Key to Exit..");
                    Console.ReadLine();
                    break;
                default:
                    break;

            }
        }

        public static void ParamsMethod(params object[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + (i < arr.Length - 1 ? ", " : ""));
            }
            Console.WriteLine();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }

    

}
