using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class bill
{
	static void Main(string[] args)
	{
		int conu;
		double chg, surchg = 0, gramt, netamt;
		string connm,custe,custmno;

		Console.Write("\n\n");
		Console.Write("Calculate Electricity Bill:\n");
		Console.Write("----------------------------");
		Console.Write("\n\n");

		
		Console.Write("Input the name of the customer :");
        connm = Console.ReadLine();
		Console.Write("Input Customer Mobile Number  :");
        custmno = Convert.ToString(Console.ReadLine());
		Console.Write("Input Customer Email :");
		custe = Console.ReadLine();
		Console.Write("Input the unit consumed by the customer : ");
		conu = Convert.ToInt32(Console.ReadLine());
		if (conu < 99)
			chg = 0.60;
		else if (conu < 199)
			chg = 1.40;
		else if (conu >= 200 && conu < 299)
			chg = 1.60;
		else if (conu >= 300 && conu < 399)
			chg = 1.80;
		else
			chg = 2.00;
		gramt = conu * chg;
		if (gramt > 600)
			surchg = gramt * 15 / 100.0;
		netamt = gramt + surchg;
		if (netamt < 100)
			netamt = 100;
		Console.Write("\nElectricity Bill\n");
		
		Console.Write("Customer Name                       :{0}\n", connm);
		Console.Write("Mobile Number                       :{0}\n", custmno);
		Console.Write("Email                               :{0}\n", custe);
		Console.Write("unit Consumed                       :{0}\n", conu);
		Console.Write("Amount Charges @Rs. {0}  per unit     :{1}\n", chg, gramt);
		Console.Write("Surcharge Amount                    :{0}\n", surchg);
		Console.Write("Net Amount Paid By the Customer     :{0}\n", netamt);
	}
}
