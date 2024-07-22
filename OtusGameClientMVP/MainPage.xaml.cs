using MauiPageFullScreen;

namespace OtusGameClientMVP
{
	public partial class MainPage : ContentPage
	{
		private bool isFirstLoad = true;

		public MainPage()
		{
			InitializeComponent();
		}

		private async void ContentPage_Loaded(object sender, EventArgs e)
		{
			if (isFirstLoad)
			{
				// Сразу полный экран - кнопка Полный экран вкл/выкл почему-то пропускает 1 клик
				//Controls.FullScreen();

				// Анимация загрузки
				await Task.Delay(1000);
				await LoadingScreen.FadeTo(0, 1000, Easing.Linear);
				LoadingScreen.IsAnimationPlaying = false;
				RootGrid.Children.Remove(LoadingScreen);

				// Появление главной страницы
				await PageSplash.FadeTo(0, 1000, Easing.Linear);
				RootGrid.Children.Remove(PageSplash);

				isFirstLoad = false;
			}
		}

		private async void StartGameBtn_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new GamePage());
		}

		private async void SettingsBtn_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new SettingsPage());
		}

		private void ExitBtn_Clicked(object sender, EventArgs e)
		{
			Application.Current?.Quit();
		}

	}

}
