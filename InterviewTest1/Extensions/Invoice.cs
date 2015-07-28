using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTest1.Models
{
    public partial class Invoice: IInvoice
    {
        public void CalculateSubTotal()
        {
            //Invoice Subtotal
            SubTotal = this.LineItems.Select(s => s.Total).Sum();
        }
        public void CalculateTotal(Invoice inv)
        {
            //invoice total
            inv.Total = SubTotal + Shipping;
        }

        public void CalculateCommission()
        {
            // rounding off to the nearest half dollar
            Commision = Math.Round(this.LineItems.Select(s => s.Commission).Sum() * 2, MidpointRounding.ToEven) / 2;  
        }
    }
}
