namespace OtusGameClientMVP;

public partial class GamePage : ContentPage
{
	public GamePage()
	{
		InitializeComponent();
	}

	private  void ContentPage_Loaded(object sender, EventArgs e)
	{
		
	}

	private async void BackBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}