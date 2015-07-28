using InterviewTest.Model;
using InterviewTest1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTest1
{
    public interface IInvoice
    {
        void CalculateSubTotal();
        void CalculateTotal(Invoice inv);

        void CalculateCommission();
    }
}
