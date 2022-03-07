using System;

namespace Electricity_Bill
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int mobilno ,unitconsumed, unit;
            string custName , email ;
            double billAmount=0;
            double surcharge = 0;

            Console.Write("\n\nCalculate Electricity Bill:\n");
            Console.Write("----------------------------\n\n");

            Console.Write("Enter Customer Name :");
            custName = Console.ReadLine();
            Console.Write("Enter Customer's Mobile No :");
            mobilno = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter Customer's Mail Id:");
            email = Console.ReadLine();
            Console.Write("Enter the number of units consumed by the customer : ");
            unitconsumed = Convert.ToInt32(Console.ReadLine());
            if (unitconsumed < 0)
            {
                Console.Write("Invalid Unput of units:\n");
                Console.Write("Enter the number of units consumed by the customer : ");
                unitconsumed = Convert.ToInt32(Console.ReadLine());
            }
            unit = unitconsumed;

            if (unit <= 99)
            {
                billAmount = unit*0.6;
            }
            else if(unit>99 && unit <=199)
            {
                billAmount = (99 * 0.6) + (unit - 99) * 1.4;
            }
            else if (unit>199 && unit <= 299 )
            {
                billAmount = (99 * 0.6) + (100 * 1.4) + ((unit-199)*1.6);
            }
            else if (unit> 299 && unit <= 399)
            {
                billAmount = (99 * 0.6) + (100* 1.4) + (100 * 1.6) +(unit-299)*1.8;
            }
            else
            {
                billAmount = (99 * 0.6) + (100 * 1.4) + (100 * 1.6) + (100 * 1.8) + (unit - 399) * 2;
            }



            if (billAmount > 600)
            {
                surcharge = (billAmount * 0.15);
                billAmount = billAmount + surcharge;
            }
            else if (billAmount <= 100)
            {
                surcharge = 0;
                billAmount = 100;
            }
            else
            {
                surcharge = 0;
            }

            Console.Write("\nElectricity Bill\n");
            Console.Write("----------------------------\n\n");
            Console.Write("Customer Name                       :{0}\n", custName);
            Console.Write("Customer Mobile No.                 :{0}\n", mobilno);
            Console.Write("unit Consumed by the Customer       :{0}\n", unitconsumed);
            Console.Write("surcharge on bill                   :{0}\n", surcharge);
            Console.Write("Total Amount Paid By the Customer   :{0}\n", billAmount);



        }
    }
}
