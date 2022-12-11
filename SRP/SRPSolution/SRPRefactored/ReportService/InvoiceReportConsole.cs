using SRPRefactored.BusinessModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPRefactored.ReportService
{
    internal class InvoiceReportConsole
    {
        private readonly Invoice _invoice;

        public InvoiceReportConsole(Invoice invoice)
        {
            _invoice = invoice;
        }

        public string FormattedOutput()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Discription : " + _invoice.Discription);
            sb.Append("\nAmount : " + _invoice.Amount);
            sb.Append("\nTax : " + _invoice.Tax);
            sb.Append("\nDiscount : " + _invoice.Discount);
            sb.Append("\nTotal : " + _invoice.Total);

            return sb.ToString();
        }

        public void GenerateInvoice()
        {
            string str = FormattedOutput();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor= ConsoleColor.Black;
            Console.WriteLine(str);
            Console.ResetColor();
        }

    }
}
