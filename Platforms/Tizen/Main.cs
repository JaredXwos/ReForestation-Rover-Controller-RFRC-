using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace ReForestation_Rover_Controller__RFRC_;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
