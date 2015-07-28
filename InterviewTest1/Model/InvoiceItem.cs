using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTest1.Models
{
    public partial class InvoiceItem
    {
        public int Id { get; set; }

        /// <summary>
        /// Short Description of purchased item
        /// </summary>
        public string LineText { get; set; }

        /// <summary>
        /// Item is subject to tax
        /// </summary>
        public bool Taxable { get; set; }

        /// <summary>
        /// Number of units purchased
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Random price per unit
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Discount in whole percent, ie: 55 %
        /// </summary>
        public byte Discount { get; set; }

        /// <summary>
        /// Total for line item not including tax or discount
        /// </summary>
        public decimal SubTotal { get; set; }

        /// <summary>
        /// Total for line item including tax
        /// </summary>
        public decimal Total { get; set; }

        /// <summary>
        /// Commission 
        /// </summary>
        public decimal Commission { get; set; }

        /// <summary>
        /// Example ToString implementation, update/replace as desired
        /// </summary>
        /// <returns></returns>
         public decimal InvoiceId { get; set; }
        public override string ToString()
        {
            //had to remove extra {5} placeholder to obtain correct format for Per unit price
            return string.Format("{0}Quantity: {1:00}\tPer Unit: $ {2:#,0.00}\tDiscount: {3:00} %\tSubTotal: $ {4:#,0.00}\tTotal: $ {5:#,0.00}",
                                 LineText.PadRight(20),
                                 Quantity,
                                 UnitPrice,
                                 Discount,
                                 SubTotal,
                                 Total,
                                 Taxable ? "T" : null);
        }

     


    }
}
