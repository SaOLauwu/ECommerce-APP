﻿using System.Text.Json;
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
            String nombre = txtboxNombre.Text;
            String pass = txtboxPass.Text;
            if (!int.TryParse(txtboxCi.Text, out ci))
            {
                MessageBox.Show("El valor ingresado debe ser numerico, sin puntos ni guiones.");
                return;
            }
            else
            {
                EntidadesJSON.empleado empleado = new EntidadesJSON.empleado();
                empleado.ci = ci;
                empleado.nombre = nombre + ci;
                empleado.rol = "";
                empleado.clave = pass;
                empleado.resultado = "";

                string empleadoserializado = JsonSerializer.Serialize(empleado);
                String emp = APIAut.Login(empleadoserializado);
                empleado = JsonSerializer.Deserialize<EntidadesJSON.empleado>(emp);

                switch (empleado.resultado)
                {
                    case "true":
                        if (Program.login(emp) == 0)
                        {
                            if (empleado.clave == "contrasena")
                            {
                                CambioContrasena c = new CambioContrasena(empleado.nombre);
                                c.ShowDialog();
                                this.Close();
                            }
                            else
                                this.Close();
                            
                        }
                        else
                            MessageBox.Show("1Existe un error con el rol de este usuario. Avise a un administrador.");
                        break;
                    case "false":
                        MessageBox.Show(empleado.nombre + empleado.clave);
                        MessageBox.Show("Su combinación de nombre y contraseña es incorrecta.");
                        return;
                    default:
                        MessageBox.Show("error");
                        return;
                }


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
    }
}
