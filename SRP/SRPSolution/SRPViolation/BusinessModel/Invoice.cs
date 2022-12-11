using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPViolation.BusinessModel
{
    internal class Invoice
    {
        private readonly double _amount;
        private readonly double _discountPercent;
        private readonly string _discription;

        public Invoice(string discription,double amount,double discountPercent)
        { 
            _amount= amount;
            _discountPercent= discountPercent;
            _discription= discription;
        }

        public double Discount
        {
            get
            {
                return _amount * _discountPercent/100;
            }
        }

        public double Tax
        {
            get
            {
                return _amount * .10;
            }
        }

        public double Total
        {
            get
            {
                return _amount - Discount + Tax;
            }
        }

        public void GenerateInvoice()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Discription : " + _discription);
            sb.Append("\nAmount : " + _amount);
            sb.Append("\nTax : " + Tax);
            sb.Append("\nDiscount : " + Discount);
            sb.Append("\nTotal : " + Total);

            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }

}
