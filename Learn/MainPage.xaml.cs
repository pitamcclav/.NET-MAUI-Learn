namespace Learn;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();

    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }

    void OnSliderValue(object sender, ValueChangedEventArgs args)
    {
        valueLabel.Text = args.NewValue.ToString("F3");
    }
    async void onButtonClicked(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        //this method takes in the title of the alert, the message, and the name of the exit button 
        await DisplayAlert("Clicked!", "The button labelled " + btn.Text + "has been clicked", "ok");
    }
}

