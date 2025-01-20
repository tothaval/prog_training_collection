using DelegateTraining_ClubMemberShipApplication.Views;

namespace DelegateTraining_ClubMemberShipApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IView mainView = Factory.GetMainViewObject();
            mainView.RunView();

            Console.ReadKey();

        }
    }
}
