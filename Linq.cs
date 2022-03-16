//Aggregate
using System;
using System.Linq;

public class Program
{
	public static void Main()
	{
		var numbers = new[] { 2, 4, 6, 8, 10 };

		var result = numbers.Aggregate((x, y) => x * y);

		Console.WriteLine(result);
	}
}

//Average
using System;
using System.Linq;

public class Program
{
	public static void Main()
	{
		var scores = new[] { 10, 20, 30, 40 };

		var average = scores.Average();

		Console.WriteLine(average);
	}
}

//Count
using System;
using System.Linq;

public class Program
{
	public static void Main()
	{
		var scores = new[] { 10, 20, 30, 40 };

		var scorecount = scores.Count();

		Console.WriteLine(scorecount);
	}
}

//Max
using System;
using System.Linq;

public class Program
{
	public static void Main()
	{
		var people = new[]
		{
			new
			{
				Name = "Ekta",
				Age = 21

			},
				new
			{
				Name = "Dhwani",
				Age = 22
			},
			
		};

		var max = people.Max(arg => arg.Age);

		Console.WriteLine(max);
	}
}

//Min
using System;
using System.Linq;

public class Program
{
	public static void Main()
	{
		var people = new[]
		{
			new
			{
				Name = "Ekta",
				Age = 21

			},
				new
			{
				Name = "Dhwani",
				Age = 22
			},
			
		};

		var min = people.Min(arg => arg.Age);

		Console.WriteLine(min);
	}
}

//ElementAt
using System;
using System.Linq;

public class Program
{
	public static void Main()
	{
		var numbers = new[] { 2, 4, 6, 8, 10 };

		int number = numbers.ElementAt(0);
		Console.WriteLine(number);
	}
}

//First
using System;
using System.Linq;

public class Program
{
	public static void Main()
	{
        var people = new[]
    {
        new
            {
                Id =1, Name = "Vernon", Gender = "Male", CountryCode = "GB",
            },
        new
            {
                Id = 2, Name = "Carrie", Gender = "Female", CountryCode = "CA"
            },
        new
            {
                Id = 3, Name = "Joanna", Gender = "Female", CountryCode = "US"
            },
    };

        var carrie = people.Where(p => p.Id == 1).First();
        Console.WriteLine(carrie);
    }
}

//FirstOrDefault
using System;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
		var numbers = new[] { 5, 7, 9, 10 };

		int firstOrDefault = numbers.FirstOrDefault(n => n < 10);
		
		Console.WriteLine(firstOrDefault);
	}
}

//Last
using System;
using System.Linq;

public class Program
{
	public static void Main()
	{
        var numbers = new[] { 3,4,5,6 };

        int last = numbers.Last();
        Console.WriteLine(last);
    }
}

//LastOrDefault
using System;
using System.Linq;

public class Program
{
	public static void Main()
	{
        var numbers = new[] { 3,4,5,6 };

        int last = numbers.LastOrDefault(n => n < 0);
        Console.WriteLine(last);
    }
}

//Where
using System;
using System.Linq;

public class Program
{
	public static void Main()
	{
        var customers = new[] {
    new{
            Name = "Vernon",
            DateOfBirth = "1994-Jun-25",
            Active = true,
            Card = "MasterCard",
            CardNumer = "*** 1142",
            ExpiryYear = 2022,
            ExpiryMonth = 7
        },
    new {
            Name = "Carrie",
            DateOfBirth = "1986-Feb-01",
            Active = false,
            Card = "Visa",
            CardNumer = "*** 2156",
            ExpiryYear = 2015,
            ExpiryMonth = 7
        },
    new {
            Name = "Joanna",
            DateOfBirth = "1972/10/13",
            Active = true,
            Card = "Visa",
            CardNumer = "*** 7683",
            ExpiryYear = 2014,
            ExpiryMonth = 3
        },
    new {
            Name = "Louis",
            DateOfBirth = "1975/05/10",
            Active = true,
            Card = "Visa",
            CardNumer = "*** 7683",
            ExpiryYear = 2016,
            ExpiryMonth = 2
        }
};

        var results = customers.Where(customer => customer.Card == "Visa"
                            && customer.ExpiryYear <= 2016);

        foreach (var result in results)
        {

            Console.WriteLine(result.Name);
        }
    }
}


