
using IRRCalculator3.Domain.Enum;
using IRRCalculator3.Services.Interfaces;

namespace IRRCalculator3.Services
{
    public class PercentualRange : IPercentualRange
    {
        private Dictionary<IRLevel, double> RangeDic = new Dictionary<IRLevel, double>()
        {
             {IRLevel.Level1, 0 },
             {IRLevel.Level2, 0.075 },
             {IRLevel.Level3, 0.150 },
             {IRLevel.Level4, 0.225 },
             {IRLevel.Level5, 0.275 }

        };

        public double GetPercentualRange(IRLevel level)
        {

            double value;
            switch (level)
            {
                case IRLevel.Level1:
                    {
                        bool levelvalid = RangeDic.TryGetValue(level, out value);
                        return value;
                        break;
                    }
                case IRLevel.Level2:
                    {
                        bool levelvalid = RangeDic.TryGetValue(level, out value);
                        return value;
                        break;
                    }
                case IRLevel.Level3:
                    {
                        bool levelvalid = RangeDic.TryGetValue(level, out value);
                        return value;
                        break;
                    }
                case IRLevel.Level4:
                    {
                        bool levelvalid = RangeDic.TryGetValue(level, out value);
                        return value;
                        break;
                    }
                case IRLevel.Level5:
                    {
                        bool levelvalid = RangeDic.TryGetValue(level, out value);
                        return value;
                        break;
                    }

            }
            return 0;
        }
    }
}
