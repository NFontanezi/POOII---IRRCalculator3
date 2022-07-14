
namespace IRRCalculator3.Infrastructure
{
    public static class Validators
    {
        public static bool IsStringValid(string input)
        {   if (!String.IsNullOrEmpty(input))
                return true;
            else return false;
        }

        public static bool IsValidNumber(string input)
        {
            double validNumber;
            if (input == ",")
                return false;
            else
                return double.TryParse(input, out validNumber);
        }
        
    }
}
