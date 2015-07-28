using InterviewTest.Model;
using InterviewTest1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTest
{
    public class MyContext : DbContext
    {
        public MyContext()
        { }

        public DbSet<Invoice> Invoices{ get; set; }
        public DbSet<InvoiceItem> Items { get; set; }
    }
}
