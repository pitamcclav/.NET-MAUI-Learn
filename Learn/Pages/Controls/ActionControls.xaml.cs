namespace Learn.Pages.Controls;

public partial class ActionControls : ContentPage
{
	public ActionControls()
	{
		InitializeComponent();
	}

	public async void Alert(object sender, EventArgs e)
	{
        await DisplayAlert("Alert", "You have been alerted", "OK");
    }	

	public async void SearchClicked(object sender, EventArgs e)
	{
        await DisplayAlert("Search Clicked", $"You searched for {search.Text}", "OK");
    }
}