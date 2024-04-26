namespace SLoachaminExamen;

public partial class Acerca : ContentPage
{
	public Acerca()
	{
		InitializeComponent();
	}
    private void btnCerrarButtonClicked(object sender, EventArgs e)
    {
        Login loginPage = new Login();
        Navigation.PushAsync(loginPage);
    }
}
