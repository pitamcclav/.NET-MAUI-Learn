namespace Learn.Pages;

public partial class Page3 : ContentPage
{
    public Page3()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}