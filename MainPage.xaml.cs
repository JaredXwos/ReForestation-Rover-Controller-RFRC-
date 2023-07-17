namespace ReForestation_Rover_Controller__RFRC_;

public partial class MainPage : ContentPage
{
	string address = "http://192.168.3.1/";


    public MainPage()
	{
		InitializeComponent();
	}

	private void OnPressed(object sender, EventArgs e)
	{
		new HttpClient().GetAsync(address + "p" + ((Button)sender).StyleId);
	}

    private void OnRelease(object sender, EventArgs e)
    {
        new HttpClient().GetAsync(address + "r" + ((Button)sender).StyleId);
    }

}

