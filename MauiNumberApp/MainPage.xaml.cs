namespace MauiNumberApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnShowNumberClicked(object sender, EventArgs e)
    {
        string input = NumberEntry.Text;

        if (int.TryParse(input, out int number))
        {
            await DisplayAlert("Result", $"You entered the number {number}", "Ok");
        }
        else
        {
            await DisplayAlert("Error", "Please enter a valid integer", "OK");
        }
    }
}