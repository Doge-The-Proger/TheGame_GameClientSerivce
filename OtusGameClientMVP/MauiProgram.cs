﻿using MauiPageFullScreen;
using Microsoft.Extensions.Logging;
using Plugin.Maui.Audio;

namespace OtusGameClientMVP
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>().UseFullScreen()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				});
            builder.AddAudio();
#if DEBUG
            builder.Logging.AddDebug();
#endif

			return builder.Build();
		}
	}
}
