
using IRRCalculator3.Domain;
using IRRCalculator3.Domain.Enum;
using IRRCalculator3.Domain.Entities;
using IRRCalculator3.Services;

namespace IRRCalculator3
{
    public class Program
    {
        public static void Main()
        {

            Console.WriteLine("Entre com o salario");
            double salaryinput = double.Parse(Console.ReadLine());
            IRLevel level = RangeSalary.GetRange(salaryinput);

            User user = new User(new Salary(salaryinput, level));

            DueIRR duepayment = new DueIRR(new IRRTax(), new PercentualRange());
            double validpayment = duepayment.CalculateDueIRR(user);

            Console.WriteLine($"Salario: {user.SalaryBase}\nFaixa: {user.SalaryBase.IRLevel}\nDuePayment: {validpayment}");

        }
    }
}
