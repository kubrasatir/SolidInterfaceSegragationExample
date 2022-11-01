
using SolidInterfaceSegragationExample;

IWorker contractWorker=new ContractEmployee();
contractWorker.HourlyRate = 10;
contractWorker.HoursInMonth = 2;
IWorker fullTimeWorker=new FullTimeEmployee();
fullTimeWorker.MonthlySalary = 300;
fullTimeWorker.OtherBenefits = 40;

Console.WriteLine($"contractWorker {contractWorker.CalculateWorkedSalary()}");
Console.WriteLine($"fullTimeWorker {fullTimeWorker.CalculateNetSalary()}");
Console.ReadKey();
