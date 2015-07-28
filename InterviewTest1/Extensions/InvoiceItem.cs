using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTest1.Models
{
    public partial class InvoiceItem: IInvoice
    {
        //invoice item subtotal
        public void CalculateSubTotal()
        {
            SubTotal = UnitPrice * Quantity;
        }
        //invoice item Total 
        public void CalculateTotal(Invoice inv)
        {
            Total = Taxable ? ((SubTotal - getDiscount(SubTotal)) * inv.TaxRate) + (SubTotal - getDiscount(SubTotal)) : (SubTotal - getDiscount(SubTotal));
        }
        //invoice item commission
        public void CalculateCommission()
        {
            Commission = (SubTotal - getDiscount(SubTotal)) * 0.03M;
        }
        private decimal getDiscount(decimal subTotal)
        {
            return (subTotal * (Discount / 100M));
        }

        public void assignInvoiceNumber(Invoice inv)
        {
            InvoiceId = inv.Id;
        }
    }
}
