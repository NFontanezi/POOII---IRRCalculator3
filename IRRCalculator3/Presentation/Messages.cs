using IRRCalculator3.Domain.Entities;
using IRRCalculator3.Services;
using System.Globalization;


namespace IRRCalculator3.Presentation
{
    public static class Messages
    {
        public const string entrySalary = "\nEntry with the annual income: ";
        public const string inputInvalid = "\nInvalid input. Please try again.";
        public const string pressKey = "\nPress any key and try again.";
        public const string pressContinue = "\nPress any key and continue...";
        public static string TaxPayment(User user, double duepayment)
        {
            return $"\nIncome: {user.SalaryBase.NormalSalary.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\nDuePayment: {duepayment.ToString("F2", CultureInfo.InvariantCulture)}";
        }


    }
}
