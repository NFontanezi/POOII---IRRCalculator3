
using IRRCalculator3.Domain.Enum;

namespace IRRCalculator3.Services.Interfaces
{
    public interface IPercentualRange
    {
        double GetPercentualRange(IRLevel level);
    }
}

