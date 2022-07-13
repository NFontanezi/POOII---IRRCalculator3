
using IRRCalculator3.Domain.Entities;
using IRRCalculator3.Services.Interfaces;

namespace IRRCalculator3.Services
{
    public class DueIRR
    {
        private ITax _ITax;
        private IPercentualRange _IPercentualRange;

        public DueIRR(ITax iTax, IPercentualRange iPercentualRange)
        {
            _ITax = iTax;
            _IPercentualRange = iPercentualRange;

        }
        public double CalculateDueIRR(User user)
        {
            double salary = user.SalaryBase.NormalSalary;
            double percrange = _IPercentualRange.GetPercentualRange(user.SalaryBase.IRLevel);
            double tax =_ITax.GetTax(user.SalaryBase.IRLevel);
            double valuepaid = salary * percrange - tax;
            return valuepaid;

        }
    }
}
