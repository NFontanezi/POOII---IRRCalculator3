
using IRRCalculator3.Domain.Enum;
using IRRCalculator3.Services.Interfaces;


namespace IRRCalculator3.Services
{
    public class RangeS : IRange
    {

        public  IRLevel GetRange(double salary)
        {
            if (salary <= 22847.76)
                return IRLevel.Level1;
            else if (salary > 22847.76 && salary <= 33919.80)
                return IRLevel.Level2;
            else if (salary > 33919.80 && salary <= 45012.60)
                return IRLevel.Level3;
            else if (salary > 45012.60 && salary <= 55976.16)
                return IRLevel.Level4;
            else //if (salary > 5976.16)
                return IRLevel.Level5;
            // return null;

        }
    }
}
