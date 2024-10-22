namespace Learn.Pages.Layouts;

public partial class stacklayout : ContentPage
{
	public stacklayout()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushModalAsync(new Grid());
    }
}