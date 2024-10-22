namespace Learn.Pages;

public partial class Page2 : ContentPage
{
    public Page2()
    {
        InitializeComponent();
    }

    private async void ClosePage(object sender, EventArgs e)
    {   //this creates a new instance instead of going back or closing the page
        //await Navigation.PushModalAsync(new Page1());
        await Navigation.PopModalAsync();
    }

    private async void Page3(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Page3());
    }
}