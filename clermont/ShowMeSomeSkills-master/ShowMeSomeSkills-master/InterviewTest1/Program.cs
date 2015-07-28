using InterviewTest.Model;
using InterviewTest1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTest1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var data = new Repo().All();
            PrintExercise(data, 1);
            PrintExercise(data, 2);
            PrintExercise(data, 3);
            Console.ReadLine();
        }

        private static void PrintExercise(IEnumerable<Invoice> data, int exerciseNo)
        {
           // var data = new Repo().All();

          
            Console.Write("Click enter to see Exercise " + exerciseNo.ToString());
            Console.Write(Environment.NewLine + "---------------");
            //Environment.NewLine;
            Console.ReadLine();

            foreach (Invoice inv in data)
            {
                Console.Write(Environment.NewLine);
                if (exerciseNo == 1)
                {
                    Console.WriteLine("Invoice Number: " + inv.InvoiceNo);
                    Console.Write(Environment.NewLine + "---------------" + Environment.NewLine);
                }

                switch (exerciseNo)
                {
                    case 1:
                        foreach (InvoiceItem item in inv.LineItems)
                            Console.WriteLine(item);
                        break;
                    case 2:
                        Console.WriteLine(string.Format("Company Name: {0}\tInvoice Number: {1}\tSubTotal: $ {2:#,0.00}\tTotal: $ {2:#,0.00}",
                                                        inv.CompanyName,
                                                        inv.InvoiceNo,
                                                        inv.SubTotal,
                                                        inv.Total));
                        Console.Write(Environment.NewLine);
                        inv.LineItems.Select(s => new { Item = s.LineText, UnitPrice = s.UnitPrice.ToString("$#,0.00"), Quantity = s.Quantity, SubTotal = s.SubTotal.ToString("$#,0.00"), Total = s.Total.ToString("$#,0.00") }).ToList().ForEach(Console.WriteLine);
                        break;
                    case 3:
                        Console.WriteLine(string.Format("Company Name: {0}\tInvoice Number: {1}\tSubTotal: $ {2:#,0.00}\tTotal: $ {3:#,0.00}\tCommission: $ {4:#,0.00}",
                              inv.CompanyName,
                              inv.InvoiceNo,
                              inv.SubTotal,
                              inv.Total,
                              inv.Commision));
                        Console.Write(Environment.NewLine);
                        inv.LineItems.Select(s => new { Item = s.LineText, UnitPrice = s.UnitPrice.ToString("$ #,0.00"), Quantity = s.Quantity, SubTotal = s.SubTotal.ToString("$#,0.00"), Total = s.Total.ToString("$#,0.00") }).ToList().ForEach(Console.WriteLine);
                        break;
                }

            }
            Console.Write(Environment.NewLine);
        }

        //private static void displayItems(IEnumerable<Invoice> data)
        //{
        //    //data = new Repo().All();
        //    data.SelectMany(invoice => invoice.LineItems)
        //        .ToList()
        //        .ForEach(Console.WriteLine);
        //}
    }
}
