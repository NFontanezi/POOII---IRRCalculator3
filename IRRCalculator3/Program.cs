
using IRRCalculator3.Domain;
using IRRCalculator3.Domain.Enum;
using IRRCalculator3.Domain.Entities;
using IRRCalculator3.Services;

namespace IRRCalculator3
{
    public class Program
    {
        public static void Main()
        {

            ProjectFlows.MainFlow.BeginCalculator();

        }
    }
}