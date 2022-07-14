
using IRRCalculator3.Domain.Enum;
using IRRCalculator3.Services.Interfaces;

namespace IRRCalculator3.Services
{ 
public class Tax : ITax
{
    private Dictionary<IRLevel, double> IRRTaxDic = new Dictionary<IRLevel, double>()
        {
             {IRLevel.Level1, 0 },
             {IRLevel.Level2, 1713.58 },
             {IRLevel.Level3, 4257.57 },
             {IRLevel.Level4, 7633.51 },
             {IRLevel.Level5, 10432.32 }

        };

    public double GetTax(IRLevel level)
    {
        double value;
        switch (level)
        {
            case IRLevel.Level1:
                {
                    bool levelvalid = IRRTaxDic.TryGetValue(level, out value);
                    return value;
                    break;
                }
            case IRLevel.Level2:
                {
                    bool levelvalid = IRRTaxDic.TryGetValue(level, out value);
                    return value;
                    break;
                }
            case IRLevel.Level3:
                {
                    bool levelvalid = IRRTaxDic.TryGetValue(level, out value);
                    return value;
                    break;
                }
            case IRLevel.Level4:
                {
                    bool levelvalid = IRRTaxDic.TryGetValue(level, out value);
                    return value;
                    break;
                }
            case IRLevel.Level5:
                {
                    bool levelvalid = IRRTaxDic.TryGetValue(level, out value);
                    return value;
                    break;
                }

        }
        return 0;
    }

}
}
