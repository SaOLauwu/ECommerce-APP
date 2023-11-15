using System.Diagnostics;
using System.Text.Json;
namespace ProyectoFinal
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int ci;
            String pass = txtboxPass.Text;

            // Verifica si el CI es numérico
            if (!int.TryParse(txtboxCi.Text, out ci))
            {
                MessageBox.Show("El valor ingresado debe ser numérico, sin puntos ni guiones.");
                return;
            }

            // Preparar el objeto empleado
            EntidadesJSON.empleado empleado = new EntidadesJSON.empleado
            {
                ci = ci,
                rol = "",
                clave = pass,
                resultado = ""
            };

            try
            {
                // Serializar el objeto empleado a JSON
                string empleadoserializado = JsonSerializer.Serialize(empleado);

                // Llamar al método de autenticación y obtener la respuesta
                String emp = APIAut.Identificacion(empleadoserializado);

                // Verifica que la respuesta no sea nula o vacía antes de deserializar
                if (string.IsNullOrWhiteSpace(emp))
                {
                    MessageBox.Show("La respuesta del servicio de autenticación está vacía.");
                    return;
                }
                Debug.WriteLine($"Respuesta recibida: {emp}");
                // Intenta deserializar la respuesta
                empleado = JsonSerializer.Deserialize<EntidadesJSON.empleado>(emp);

                // Procesa el resultado de la autenticación
                switch (empleado.resultado)
                {
                    case "true":
                        EntidadesJSON.SesionUsuario.CiChofer = empleado.ci;
                        if (Program.login(emp) == 0)
                        {
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Existe un error con el rol de este usuario. Avise a un administrador.");
                        }
                        break;

                    case "false":
                        MessageBox.Show("Datos de inicio de sesión incorrectos.");
                        break;

                    default:
                        MessageBox.Show("Error desconocido durante el inicio de sesión.");
                        break;
                }
            }
            catch (JsonException jsonEx)
            {
                // Maneja los errores específicos de JSON
                MessageBox.Show($"Error al procesar la respuesta del servicio de autenticación: {jsonEx.Message}");
            }
            catch (Exception ex)
            {
                // Maneja otros errores inesperados
                MessageBox.Show($"Se produjo un error inesperado: {ex.Message}");
            }
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el frmLogin
            Program.principal.MostrarFrmSeguimiento(); // Método que agregaremos en frmPrincipal
            Program.principal.Show(); // Muestra el frmPrincipal
        }
    }
}
