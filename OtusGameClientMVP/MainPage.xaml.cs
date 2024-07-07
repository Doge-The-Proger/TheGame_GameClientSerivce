using MauiPageFullScreen;

namespace OtusGameClientMVP
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private async void ContentPage_Loaded(object sender, EventArgs e)
		{
			// Сразу полный экран - кнопка Полный экран вкл/выкл почему-то пропускает 1 клик
			// Controls.FullScreen();

			// Анимация загрузки
			await Task.Delay(2000);
			await LoadingScreen.FadeTo(0, 2000, Easing.Linear);
			LoadingScreen.IsAnimationPlaying = false;
			RootGrid.Children.Remove(LoadingScreen);

			// Анимация меню
			await MenuStack.FadeTo(1, 1000, Easing.Linear);
			await Task.Delay(1000);
			for (int i = 0; i < 10; i++) 
			{
				await MenuStack.ScaleTo(1.1, 500, Easing.Linear);
				await MenuStack.ScaleTo(1, 500, Easing.Linear);
			}
		}

		private void StartGameBtn_Clicked(object sender, EventArgs e)
		{

		}

		private async void SettingsBtn_Clicked(object sender, EventArgs e)
		{
			await MenuStack.FadeTo(0, 1000, Easing.Linear);
			MenuStack.IsEnabled = false;
			MenuStack.ZIndex = 1;
			await Task.Delay(100);
			await SettingsStack.FadeTo(1, 1000, Easing.Linear);
			SettingsStack.IsEnabled = true;
			SettingsStack.ZIndex = 2;
		}

		private async void BackBtn_Clicked(object sender, EventArgs e)
		{
			await SettingsStack.FadeTo(0, 1000, Easing.Linear);
			SettingsStack.IsEnabled = false;
			SettingsStack.ZIndex = 1;
			await Task.Delay(100);
			await MenuStack.FadeTo(1, 1000, Easing.Linear);
			MenuStack.IsEnabled = true;
			MenuStack.ZIndex = 2;
		}

		// Кнопки полного экрана
		private void FullScreenToggle_Clicked(object sender, EventArgs e)
		{
			Controls.ToggleFullScreenStatus();
		}

		private void FullScreen_Clicked(object sender, EventArgs e)
		{
			Controls.FullScreen();
		}

		private void RestoreFullscreen_Clicked(object sender, EventArgs e)
		{
			Controls.RestoreScreen();
		}

		private void ExitBtn_Clicked(object sender, EventArgs e)
		{
			Application.Current?.Quit();
		}

	}

}
