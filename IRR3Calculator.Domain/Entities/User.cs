
namespace IRRCalculator3.Domain.Entities
{
    public class User
    {
        public Salary SalaryBase { get; set; }

        public User(Salary salaryBase)
        {
            SalaryBase = salaryBase;
        }
    }

}
