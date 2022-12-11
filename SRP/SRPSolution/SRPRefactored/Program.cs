// See https://aka.ms/new-console-template for more information
using SRPRefactored.BusinessModel;
using SRPRefactored.ReportService;

Console.WriteLine("Hello, World!");

Invoice invoice = new Invoice(discription: "Book Invoice", amount: 200, discountPercent: 20);
InvoiceReportConsole invoiceReport = new InvoiceReportConsole(invoice);
invoiceReport.GenerateInvoice();
Console.WriteLine("End Of Project");
Console.ReadLine();