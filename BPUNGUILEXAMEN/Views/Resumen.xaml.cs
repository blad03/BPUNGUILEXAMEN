namespace BPUNGUILEXAMEN.Views;

public partial class Resumen : ContentPage
{
    public Resumen(string nombre, string apellido, string edad, string fecha, string? pais, string? ciudad, string montoInicial, string pagoMensual, string cajaUsuario, string montoTotal)
    {

        InitializeComponent();

        // Aquí puedes usar los datos recibidos para inicializar los elementos de la página
        lblNombre.Text = nombre;
        lblApellido.Text = apellido;
        lblEdad.Text = edad;
        lblFecha.Text = fecha;
        lblPais.Text = pais;
        lblCiudad.Text = ciudad;
        lblMontoInicial.Text = montoInicial;
        lblPagoMensual.Text = pagoMensual;
        lblPagoTotal.Text = montoTotal;
        lblUsuario.Text = cajaUsuario;
    }
}