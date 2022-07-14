namespace IRRCalculator3.Infrastructure
{
    public static class ScreemPresenter
    {
        public static void ShowMenu(string menu, string message = "")
        {
            //Console.Clear();
            Console.WriteLine(message);
            Console.WriteLine(menu);
        }

        public static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        public static void HeaderMenu1()
        {
            Console.Clear();
            ScreemPresenter.ShowMenu(Presentation.Screens.WelcomeMenu);
            ScreemPresenter.ShowMessage(Presentation.Messages.entrySalary);
        }
        public static void HeaderMenu()
        {
            Console.Clear();
            ScreemPresenter.ShowMenu(Presentation.Screens.WelcomeMenu);
            ScreemPresenter.ShowMenu(Presentation.Screens.MenuOptions);
        }

        public static double GetNumber()
        {
            bool check = false;
            double numberresponse;
            do
            {
                HeaderMenu1();
                var response = Console.ReadLine();
                bool OptionNull = Validators.IsStringValid(response);
                bool OptionNumber = Validators.IsValidNumber(response);
                check = double.TryParse(response, out numberresponse)&& numberresponse>0;


                if (OptionNull == false || OptionNumber == false ||!check)
                {
                    ShowMessage(Presentation.Messages.inputInvalid);
                    ShowMessage(Presentation.Messages.pressKey);
                    Console.ReadKey();
                    
                }

            } while (!check);

            return numberresponse;


        }

    }
}
