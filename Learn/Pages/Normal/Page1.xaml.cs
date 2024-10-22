namespace Learn.Pages;

public partial class Page1 : ContentPage
{
    public Page1()
    {
        InitializeComponent();
    }
    private async void goToPage2(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Page2());
    }
}