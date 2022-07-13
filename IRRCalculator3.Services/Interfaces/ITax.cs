
using IRRCalculator3.Domain.Enum;

namespace IRRCalculator3.Services.Interfaces
{
    public interface ITax
    {
        double GetTax(IRLevel level);
    }
}
