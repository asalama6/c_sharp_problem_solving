using System;
internal class Program
{
    public static void Main(string[] args)
    {
        const double tax = 0.03;

        Console.Write("first name : ");
        String fName = Console.ReadLine(); 

        Console.Write("last name : ");
        string lName = Console.ReadLine();

        Console.Write("wage : ");
        var wage=Convert.ToDouble(Console.ReadLine());

        Console.Write("logged hours : ");
        var lHours=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("--------------------------------------------------------------------");
        var netSalary = (wage * lHours)-(wage * tax * lHours);
        Console.WriteLine($" Full Name : {fName} {lName} \n Wage : {wage} \n Logged Hours : {lHours} \n Net Salary After Taxes : {netSalary}");

    }
}