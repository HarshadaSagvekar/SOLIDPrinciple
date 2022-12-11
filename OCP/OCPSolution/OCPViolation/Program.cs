// See https://aka.ms/new-console-template for more information
using OCPViolation.BusinessModel;

Console.WriteLine("Hello, World!");

FixedDeposit fd = new FixedDeposit(name: "Harshada",principle:100000,duration: 10,
    policyType: FestivalPolicyType.DIWALI);

Console.WriteLine(fd);
Console.WriteLine(fd.ToString());

Console.ReadLine();