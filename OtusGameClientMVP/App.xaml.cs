using Microsoft.Maui.Platform;
using Microsoft.UI.Windowing;
using Windows.Graphics;

namespace OtusGameClientMVP
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			MainPage = new AppShell();
			// Отцентровка маленького окна
			Microsoft.Maui.Handlers.WindowHandler.Mapper.AppendToMapping(nameof(IWindow), (handler, view) =>
			{
				var windowWidth = 1280;
				var windowHeight = 720;
				var nativeWindow = handler.PlatformView;
				var appWindow = nativeWindow.GetAppWindow();
				if (appWindow is not null)
				{
					appWindow.Resize(new SizeInt32(windowWidth, windowHeight));
					var windowId = appWindow.Id;
					DisplayArea displayArea = DisplayArea.GetFromWindowId(windowId, DisplayAreaFallback.Nearest);
					if (displayArea is not null)
					{
						PointInt32 CenteredPosition = new()
						{
							X = ((displayArea.WorkArea.Width - appWindow.Size.Width) / 2),
							Y = ((displayArea.WorkArea.Height - appWindow.Size.Height) / 2)
						};
						appWindow.Move(CenteredPosition);
					}
				}
				nativeWindow.Activate();
			});
		}
	}
}
