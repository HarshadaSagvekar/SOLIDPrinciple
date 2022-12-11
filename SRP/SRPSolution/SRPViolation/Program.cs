// See https://aka.ms/new-console-template for more information
using SRPViolation.BusinessModel;

Console.WriteLine("Hello, World!");

Invoice invoice = new Invoice(discription: "Food Invoice", amount: 200, discountPercent: 20);
invoice.GenerateInvoice();