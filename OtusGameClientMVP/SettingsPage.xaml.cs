using MauiPageFullScreen;

namespace OtusGameClientMVP;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
	}

	private void ContentPage_Loaded(object sender, EventArgs e)
	{

	}

	private void FullScreenToggle_Clicked(object sender, EventArgs e)
	{
		Controls.ToggleFullScreenStatus();
	}

	private async void BackBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}

	private void ExitBtn_Clicked(object sender, EventArgs e)
	{
		Application.Current?.Quit();
	}
}