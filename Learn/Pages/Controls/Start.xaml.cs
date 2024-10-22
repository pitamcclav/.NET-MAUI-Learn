namespace Learn.Pages.Controls;

public partial class Start : ContentPage
{
	public Start()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CommonControls());
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ActionControls());
    }
}