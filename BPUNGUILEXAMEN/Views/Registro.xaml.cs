namespace BPUNGUILEXAMEN.Views;

public partial class Registro : ContentPage
{
    public Registro(string cajaUsuario)
    {
        InitializeComponent();
        DisplayAlert("Bienvenido", cajaUsuario, "Cerrar");
        lblUsuario.Text = "Usuario conectado " + cajaUsuario;
    }
    private void btnCalcular_Clicked(object sender, EventArgs e)
    {


        if (!double.TryParse(txtMontoInicial.Text, out double montoInicial ))
        {
            DisplayAlert("Error", "Por favor ingrese un monto inicial válido.", "OK");
            return;
        }
        if (montoInicial > 1500)
        {
            DisplayAlert("Error", "El monto inicial no puede ser mayor a 1500.", "OK");
        }
        else if (montoInicial < 0)
        {
            DisplayAlert("Error", "El monto inicial no puede ser negativo.", "OK");
        }
        else
        {

            double montoRestante = 1500 - montoInicial;
            double montoPorCuota = montoRestante / 4;
            double intereses = 1500 * 0.04;
            double montoConInteres = montoPorCuota + intereses;
            double montoTotal = montoConInteres + montoInicial;
            

            txtPagoMensual.Text = montoConInteres.ToString("C");
        }

    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {

        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        string edad = txtEdad.Text;
        string fecha = datePicker.Date.ToString("dd/MM/yyyy");
        string pais = pickerPais.SelectedItem?.ToString();
        string ciudad = pickerCiudad.SelectedItem?.ToString();
        string montoInicial = txtMontoInicial.Text;
        string pagoMensual = txtPagoMensual.Text;
        string cajaUsuario = lblUsuario.Text;
        string montoTotal = txtmontoTotal.Text;



        Resumen resumenPage = new Resumen(nombre, apellido, edad, fecha, pais, ciudad, montoInicial, pagoMensual, cajaUsuario, montoTotal);
        Navigation.PushAsync(resumenPage);
    }
}