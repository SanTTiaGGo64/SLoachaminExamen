using System.Collections.ObjectModel;

namespace SLoachaminExamen;

public partial class Registro : ContentPage
{
    public ObservableCollection<string> Paises { get; set; }
    public ObservableCollection<string> Ciudades { get; set; }
    string user;
    int MInicial = 0;
    int costo = 0;
    decimal interes = 0;
    decimal pagomensual  = 0;
    decimal pagototal = 0;
    public Registro(string usuario)
    {

        InitializeComponent();
        user = usuario;
        lblUserConectado.Text = usuario;

        Paises = new ObservableCollection<string>();
        Paises.Add("Ecuador");
        Paises.Add("Peru");
        pckPais.ItemsSource = Paises;
        pckPais.SelectedIndex = 0;

        Ciudades = new ObservableCollection<string>();
        Ciudades.Add("Quito");
        Ciudades.Add("Lima");
        pckCiudad.ItemsSource = Ciudades;
        pckCiudad.SelectedIndex = 0;
    }

    private void btnCalcularButtonClicked(object sender, EventArgs e)
    {
        costo = Convert.ToInt32(txtCostoCurso.Text);
        if (Convert.ToDecimal(txtMontoInicial.Text) == 0)
        {
            DisplayAlert("AVISO", "Monto inicial no puede ser 0.", "ok");
        }
        else if (Convert.ToDecimal(txtMontoInicial.Text) > 1500)
        {
            DisplayAlert("AVISO", "Monto inicial no puede ser mayor a 1500.", "ok");
        }
        else
        {
            MInicial = Convert.ToInt32(txtMontoInicial.Text);
        }

        interes = costo * 0.04m;

        pagomensual = (((costo - MInicial) / 4) + interes);
        txtPagoMensual.Text = pagomensual.ToString();
        pagototal = (pagomensual * 4) + MInicial;

    }
    private void btnResumenButtonClicked(object sender, EventArgs e)
    {
        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        int edad = Convert.ToInt32(txtEdad.Text);
        DateTime fecha = dpFecha.Date;
        string ciudad = pckCiudad.SelectedItem.ToString();
        string pais = pckPais.SelectedItem.ToString();

        Resumen resumenPage = new Resumen(nombre, apellido,edad, fecha, ciudad, pais,MInicial, pagomensual, pagototal,user);
        Navigation.PushAsync(resumenPage);
    }
}
