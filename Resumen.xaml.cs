using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SLoachaminExamen;
public partial class Resumen : ContentPage
{
    public Resumen(string nombre, string apellido, int edad, DateTime fecha, string ciudad, string pais, decimal MInicial, decimal pagomensual, decimal pagototal, string user)
    {
        InitializeComponent();
        lblUserConectado.Text = user;
        txtNombre.Text = nombre;
        txtApellido.Text = apellido;
        txtEdad.Text = edad.ToString();
        txtFecha.Text = fecha.ToString();
        txtCiudad.Text = ciudad.ToString();
        txtPais.Text = pais.ToString();
        txtMinicial.Text = MInicial.ToString();
        txtPMensual.Text = pagomensual.ToString();
        txtPTotal.Text = pagototal.ToString();
    }

    private void btnCerrarButtonClicked(object sender, EventArgs e)
    {
        Login loginPage = new Login();
        Navigation.PushAsync(loginPage);
    }
}