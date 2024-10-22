namespace Learn.Pages.Layouts;

public partial class Grid : ContentPage
{
	public Grid()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushModalAsync(new Absolute());
    }
}