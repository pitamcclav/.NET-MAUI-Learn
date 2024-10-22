namespace Learn.Pages.Nav;

public partial class NavPage1 : ContentPage
{
    public NavPage1()
    {
        InitializeComponent();
    }

    private async void goToPage2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NavPage2());
    }
}