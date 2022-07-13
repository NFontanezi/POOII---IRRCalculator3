
using IRRCalculator3.Domain.Enum;

namespace IRRCalculator3.Services.Interfaces
{
    public interface IRange
    {
       IRLevel GetRange(double salary);
    }
}

