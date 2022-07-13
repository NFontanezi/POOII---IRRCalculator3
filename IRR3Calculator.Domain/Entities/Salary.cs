using IRRCalculator3.Domain.Enum;


namespace IRRCalculator3.Domain.Entities

{
    public class Salary
    {
        public double NormalSalary { get; set; }
        public IRLevel IRLevel { get; set; }

        public Salary(double normalSalary, IRLevel iRLevel)
        {
            NormalSalary = normalSalary;
            IRLevel = iRLevel;
        }
    }

}
