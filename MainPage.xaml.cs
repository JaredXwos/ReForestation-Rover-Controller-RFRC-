namespace ReForestation_Rover_Controller__RFRC_;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnPressed(object sender, EventArgs e)
	{
		new HttpClient().GetAsync("http://192.168.3.1/p" + ((Button)sender).StyleId);
	}

    private void OnRelease(object sender, EventArgs e)
    {
        new HttpClient().GetAsync("http://192.168.3.1/r" + ((Button)sender).StyleId);
    }

}

