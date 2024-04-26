namespace SLoachaminExamen;

public partial class Login : ContentPage
{
    string[] usuarios = { "estudiante2024", "examen1", "NombreEstudiante" };
    string[] contrase�as = { "uisrael2024", "parcial1", "2024" };

    public Login()
    {
        InitializeComponent();
    }
    private void btnLoginButtonClicked(object sender, EventArgs e)
    {
        string strUser = string.Empty;
        string strContrase�a = string.Empty;
        int posicion = -1;

        //Comprobar datos vacios
        if (string.IsNullOrEmpty(txtUsuario.Text))
        {
            DisplayAlert("AVISO", "Ingrese un usuario.", "Ok");
            return;
        }
        else if (string.IsNullOrEmpty(txtContrase�a.Text))
        {
            DisplayAlert("AVISO", "Ingrese una contrase�a.", "Ok");
            return;
        }
        else
        {
            strUser = txtUsuario.Text;
            strContrase�a = txtContrase�a.Text;

            //Varible para tomar la posicion del usuario
            for (int i = 0; i < usuarios.Length; i++)
            {
                if (usuarios[i] == strUser)
                {
                    posicion = i;
                    break;
                }
            }
            if (posicion == -1)
            {
                DisplayAlert("AVISO", "Usuario no encontrado.", "Ok");
                return;
            }
        }

        if (strContrase�a == contrase�as[posicion])
        {
            DisplayAlert("AVISO", "Ingreso exitoso de usuario: " + strUser + ".", "Ok");
            Registro registroPage = new Registro(strUser);
            Navigation.PushAsync(registroPage);
        }
        else

        {
            DisplayAlert("AVISO", "Contrase�a incorrecta.", "Ok");
        }
    }
    private void btnAcercaButtonClicked(object sender, EventArgs e)
    {
        Acerca acercaPage = new Acerca();
        Navigation.PushAsync(acercaPage);
    }
}
