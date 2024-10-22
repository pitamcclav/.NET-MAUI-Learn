using Learn.Pages.Layouts;
using Learn.Pages.Tabbed;
using Learn.Pages.Controls;

namespace Learn;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        //MainPage = new AppShell();
        //MainPage = new HelloPage();
        //MainPage = new Pages.Page1();
        //MainPage = new Pages.Nav.NavPage1();
        //MainPage = new FlyoutPage1();
        //MainPage = new TabPage1();
        //MainPage = new stacklayout();


        //****Setting different attributes for nav bar****
        //var navPage = new NavigationPage(new Pages.Nav.NavPage1());
        //navPage.BackgroundColor = Colors.Red;
        //navPage.BarTextColor = Colors.Beige;
        //      MainPage = navPage;

        var navPage = new NavigationPage(new Start());
        MainPage = navPage;
    }

    public static void HandleAppActions(AppAction appAction)
    {
        Current.Dispatcher.Dispatch(async () =>
        {
            var page = appAction.Id 
            switch
            {
                "home_sc" => new ActionControls(),
               
                _ => default(Page)
            };

            if (page != null)
            {
                await Application.Current.MainPage.Navigation.PopToRootAsync();
                await Application.Current.MainPage.Navigation.PushAsync(page);
            }
        });
    }
}
