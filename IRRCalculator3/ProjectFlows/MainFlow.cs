

using IRRCalculator3.Domain.Enum;
using IRRCalculator3.Domain.Entities;
using IRRCalculator3.Services;
using IRRCalculator3.ProjectFlows.Interfaces;
//using IRRCalculator3.Presentation.Messages;

namespace IRRCalculator3.ProjectFlows
{
    public class MainFlow
    {
        public static void BeginCalculator()
        {

            Navigate();
        }

        public static void Navigate()
        {
            bool quit = false;
            do
            {
                int OptionInput = NavigateMenu();


                switch (OptionInput)
                {
                    case 1:
                        
                        Infrastructure.ScreemPresenter.HeaderMenu1();                   
                        GetTax(GetIncome());
                        Infrastructure.ScreemPresenter.ShowMessage(Presentation.Messages.pressContinue);
                        Console.ReadKey();
                        break;

                    case 2:
                        quit = true;
                        break;

                }
            } while (!quit);
        }


        public static int NavigateMenu()

        {
            bool input = false;
            int optionInput;
            do
            {
                Console.Clear();
                Infrastructure.ScreemPresenter.HeaderMenu();
                input = int.TryParse(Console.ReadLine(), out optionInput) && optionInput == 1 || optionInput == 2;





                if (!input )
                {
                    Infrastructure.ScreemPresenter.ShowMessage(Presentation.Messages.inputInvalid);
                    Infrastructure.ScreemPresenter.ShowMessage(Presentation.Messages.pressContinue);
                    Console.ReadKey();

                }
            } while (!input);
            return optionInput;
        }


        public static double GetIncome()
        {
            return Infrastructure.ScreemPresenter.GetNumber();
        }

        public static void GetTax(double income)
        {
            IRLevel level = RangeSalary.GetRange(income);

            User user = new User(new Salary(income, level));

            TaxCalculator duepayment = new TaxCalculator(new IRRTax(), new PercentualRange());
            double validpayment = duepayment.CalculateDueTax(user);

            Infrastructure.ScreemPresenter.ShowMessage(Presentation.Messages.TaxPayment(user, validpayment));
        }
    }
}
