

using IRRCalculator3.Domain.Entities;

namespace IRRCalculator3.Services.Interfaces
{
    public interface ITaxCalculator
    {
        public double CalculateDueTax(User user);
    }
}
