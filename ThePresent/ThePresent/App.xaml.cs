using WorkingWithListview;
using Xamarin.Forms;

namespace ThePresent
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            var tabsCs = new TabbedPage { Title = "Working with ListView" };
            tabsCs.Children.Add(new CustomCellXaml { Title = "Дарю", IconImageSource = "csharp.png" });
            //tabsCs.Children.Add(new FriendsPage { Title = "Хочу", IconImageSource = "csharp.png" });
            //tabsCs.Children.Add(new FriendsPage { Title = "Друзья", IconImageSource = "csharp.png" });

            MainPage =  new NavigationPage(tabsCs);

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
