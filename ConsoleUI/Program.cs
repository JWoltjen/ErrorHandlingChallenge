using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentProcessor paymentProcessor = new PaymentProcessor();
            for (int i = 0; i <= 10; i++)
            {
                TransactionModel result = null;

                try
                {
                    result = paymentProcessor.MakePayment($"Demo{i}", i);

                    if (result != null)
                    {
                        Console.WriteLine(result.TransactionAmount);
                    }
                    else
                    {
                        Console.WriteLine($"Null value for item {i}");
                    }
                }
                catch
                {
                    Console.WriteLine($"Payment skipped for payment with {i} items");
                }               
            }
            Console.ReadLine();
        }
    }
}
