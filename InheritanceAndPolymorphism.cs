using System;

abstract class Employee
{
    public decimal GetPay();
}

class HourlyEmployee : Employee
{
    decimal rate;
    decimal hours;
    public HourlyEmployee(decimal rate,decimal hours)
    {
        this.rate = rate;
        this.hours = hours;
    }
    public override decimal GetPay()=> rate*hours;
}

class SalariedEmployee : Employee
{
    decimal monthlySal;

    public SalariedEmployee(decimal pay)
    {
        monthlySal = rate;
        
    }
    public override decimal GetPay()=> monthlySal;
}

class CommissionEmployee : Employee
{
    decimal baseSal;
    decimal commission;
    public CommissionEmployee(decimal baseSal,decimal commission)
    {
        this.baseSal=baseSal;
        this.commission=commission;
    }
    public override decimal GetPay()=> baseSal+commission;
}

class InheritanceAndPolymorphism
{
    decimal total = 0m;
        public static decimal TotalPayroll(string[] employee)
    {
        foreach (var emp in employees)
    {
        var p = emp.Split(' ');

        Employee employee = p[0] switch
        {
            "H" => new HourlyEmployee(
                        decimal.Parse(p[1]),
                        decimal.Parse(p[2])),

            "S" => new SalariedEmployee(
                        decimal.Parse(p[1])),

            "C" => new CommissionEmployee(
                        decimal.Parse(p[1]),
                        decimal.Parse(p[2])),

            _ => null
        };

        if (employee != null)
            total += employee.GetPay();
    }

    return Math.Round(total, 2);
    }

}