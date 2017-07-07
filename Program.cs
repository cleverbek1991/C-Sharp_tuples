using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();

            transactions.Add(("Tool Storage", 78.99, 4));
            transactions.Add(("Drill", 44.93, 9));
            transactions.Add(("Socket", 1.49, 5));
            transactions.Add(("Hammer", 33.59, 6));
            transactions.Add(("Compressor", 45.78, 4));

            double totalQuantity = 0;
            double revenue = 0;

            foreach ((string product, double amount, int quantity) t in transactions)
            {
                totalQuantity += t.quantity;
                revenue += t.amount;
            }
                Console.WriteLine(totalQuantity);
                Console.WriteLine(totalQuantity * revenue);   
        }
    }
}
