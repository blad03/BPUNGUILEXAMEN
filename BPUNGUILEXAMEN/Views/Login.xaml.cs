using Microsoft.Win32;

namespace BPUNGUILEXAMEN.Views;

public partial class Login : ContentPage
{
    string[,] usuariosContraseñas = {
            {"estudiante", "moviles"},
            {"uisrael", "2024"},

        };

    public Login()
    {
        InitializeComponent();
    }

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string cajaUsuario = txtUsuario.Text;
        string cajaContrasena = txtContrasena.Text;

        bool usuarioValido = false;
        bool contrasenaValida = false;

        for (int i = 0; i < usuariosContraseñas.GetLength(0); i++)
        {
            if (usuariosContraseñas[i, 0] == cajaUsuario)
            {
                usuarioValido = true;
                if (usuariosContraseñas[i, 1] == cajaContrasena)
                {
                    contrasenaValida = true;
                    break;
                }
            }
        }

        if (usuarioValido && contrasenaValida)
        {

            Navigation.PushAsync(new Registro(cajaUsuario));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario/Contraseña incorrectos", "Cerrar");
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }
    }
}