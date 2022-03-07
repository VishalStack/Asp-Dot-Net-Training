// See https://aka.ms/new-console-template for more information
using System;
public class Bill
{
	static void Main(string[] args)
	{
		int custid, conunit;
		double chg, surchg = 0, gramt, netamt;
		string conname;


        Console.Write("Calculate Electricity Bill:\n");

		Console.Write("Input Customer ID :");
		custid = Convert.ToInt32(Console.ReadLine());
		Console.Write("Input the name of the customer :");
		Console.Write("Input the unit consumed by the customer : ");
		conunit = Convert.ToInt32(Console.ReadLine());

		if (conunit < 200)
			chg = 1.20;
		else if (conunit >= 200 && conunit < 400)
			chg = 1.50;
		else if (conunit >= 400 && conunit < 600)
			chg = 1.80;
		else
			chg = 2.00;
		gramt = conunit * chg;

		if (gramt > 300)
			surchg = gramt * 15 / 100.0;
		netamt = gramt + surchg;

		if (netamt < 100)
			netamt = 100;
		Console.Write("\nElectricity Bill\n");
		Console.Write("Customer IDNO :{0}\n", custid);
		Console.Write("Customer Name :{0}\n", conname);
		Console.Write("unit Consumed :{0}\n", conunit);
		Console.Write("Amount Charges @Rs. {0}  per unit :{1}\n", chg, gramt);
		Console.Write("Surchage Amount :{0}\n", surchg);
		Console.Write("Net Amount Paid By the Customer :{0}\n", netamt);
	}
}
