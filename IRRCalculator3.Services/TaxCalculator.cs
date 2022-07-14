
using IRRCalculator3.Domain.Entities;
using IRRCalculator3.Services.Interfaces;

namespace IRRCalculator3.Services
{
    public class TaxCalculator : ITaxCalculator
    {
        private readonly ITax _ITax;
        private readonly IPercentualRange _IPercentualRange;
        

        public TaxCalculator(ITax iTax, IPercentualRange iPercentualRange)
        {
            _ITax = iTax;
            _IPercentualRange = iPercentualRange;

        }
        public double CalculateDueTax(User user)
        {
            double salary = user.SalaryBase.NormalSalary;
            double percrange = _IPercentualRange.GetPercentualRange(user.SalaryBase.IRLevel);
            double tax =_ITax.GetTax(user.SalaryBase.IRLevel);
            double valuepaid = salary * percrange - tax;
            return valuepaid;
           

        }
    }
}
