

using IRRCalculator3.Domain.Enum;
using IRRCalculator3.Domain.Entities;
using IRRCalculator3.Services;
using IRRCalculator3.ProjectFlows.Interfaces;
using IRRCalculator3.Services.Interfaces;


namespace IRRCalculator3.ProjectFlows
{
    public class MainFlow : IMainFlow
    {
        private readonly ITaxCalculator _taxCalculator;

        public MainFlow(ITaxCalculator service)
        {
            _taxCalculator = service;

        }

        public void BeginCalculator()
        {

            Navigate();
        }

        public void Navigate()
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


        public int NavigateMenu()

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


        public double GetIncome()
        {
            return Infrastructure.ScreemPresenter.GetNumber();
        }

        public void GetTax(double income)
        {   
            RangeS rangeS = new RangeS(); //nao tem interface, deve ser instaciado
            IRLevel level = rangeS.GetRange(income);

            User user = new User(new Salary(income, level)); 


            double duepayment= _taxCalculator.CalculateDueTax(user); //criação de 2 objetos nos parametros >>>container passa os parametros devido da classe concreta da interface           
            //TaxCalculator duepayment = new TaxCalculator(new Tax(), new PercentualRange());
            //double validpayment = duepayment.CalculateDueTax(user);

            Infrastructure.ScreemPresenter.ShowMessage(Presentation.Messages.TaxPayment(user, duepayment));//validpayment));
        }
    }
}
