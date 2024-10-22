namespace Learn.Pages.Nav;

public partial class NavPage3 : ContentPage
{
    public NavPage3()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}