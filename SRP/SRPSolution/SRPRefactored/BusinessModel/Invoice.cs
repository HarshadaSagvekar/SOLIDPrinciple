using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPRefactored.BusinessModel
{
    internal class Invoice
    {
        private readonly double _amount;
        private readonly double _discountPercent;
        private readonly string _discription;

        public Invoice(string discription, double amount, double discountPercent)
        {
            _amount = amount;
            _discountPercent = discountPercent;
            _discription = discription;
        }

        public double Discount
        {
            get
            {
                return Amount * _discountPercent / 100;
            }
        }

        public double Tax
        {
            get
            {
                return Amount * .10;
            }
        }

        public double Total
        {
            get
            {
                return Amount - Discount + Tax;
            }
        }

        public double Amount => _amount;

        public string Discription
        {
            get
            {
                return _discription;
            }
        
        } 
    }
}
