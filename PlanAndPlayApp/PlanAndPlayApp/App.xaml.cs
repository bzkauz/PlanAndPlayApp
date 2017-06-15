using PlanAndPlayApp.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PlanAndPlayApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            SetMainPage();
            
        }

        public static void SetMainPage()
        {
            Current.MainPage = new TabbedPage
            {

                Children =
                {
                    new NavigationPage(new ItemsPage())
                    {
                        Title = "Overview",
                        Icon = Device.OnPlatform("tab_feed.png",null,null),
                        BarBackgroundColor = Color.Gray,
                        BackgroundColor = Color.Red
        },
                    new NavigationPage(new VotePage())
                    {
                        Title = "Vote",
                        Icon = Device.OnPlatform("tab_about.png",null,"pp_logo_notextOripng.png"),
                        BarBackgroundColor = Color.White,
                        BackgroundColor = Color.White
        },
                    new NavigationPage(new DiaryPage())
                    {
                        Title = "Diary",
                        Icon = Device.OnPlatform("tab_about.png",null,null),
                         BarBackgroundColor = Color.Blue,
                        BackgroundColor = Color.White

                    },
                    new NavigationPage(new SettingPage())
                    {
                        Title = "Setting",
                        Icon = Device.OnPlatform("tab_about.png",null,null)

                    },
                    new NavigationPage(new LoginPage())
                    {
                        Title = "Login",
                        Icon = Device.OnPlatform("tab_about.png",null,null),
                         BarBackgroundColor = Color.Gray

                    },
                    new NavigationPage(new AboutPage())
                    {
                        Title = "About",
                        Icon = Device.OnPlatform("tab_about.png",null,null)
                    },
                }
            };
            
            
        }
    }
}
