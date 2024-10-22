namespace Learn.Pages.Nav;

public partial class NavPage2 : ContentPage
{
    public NavPage2()
    {
        InitializeComponent();
    }

    private async void ClosePage(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void Page3(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NavPage3());
    }
}