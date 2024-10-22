namespace Learn.Pages.Layouts;

public partial class Absolute : ContentPage
{
	public Absolute()
	{
		InitializeComponent();
	}

	public async void ToFlex(object sender, EventArgs e)
	{
        await Navigation.PushModalAsync(new FlexLayout());
    }
}
