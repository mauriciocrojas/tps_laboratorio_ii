using Entidades;
using System;
using System.Windows.Forms;

namespace PokedexApp
{
    public partial class Login : Form
    {
        private bool btnSeCargoEntrenador = false;
        private bool btnSeCargoAdministrador = false;

        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (CheckearUsuario(this.txtUsuario.Text, this.txtClave.Text))
            {
                System.Media.SystemSounds.Hand.Play();
                if (btnSeCargoEntrenador)
                {
                    MenuPrincipal acceso = new MenuPrincipal("Entrenador");
                    acceso.ShowDialog();
                }
                else if (btnSeCargoAdministrador)
                {
                    MenuPrincipal acceso = new MenuPrincipal("Administrador");
                    acceso.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Función que cargara un usuario.
        /// </summary>
        /// <returns>Retorna un usuario</returns>
        public Entrenador CargarEntrenador()
        {
            this.txtUsuario.Text = Entrenador.listaEntrenadores[0].user;
            this.txtClave.Text = Entrenador.listaEntrenadores[0].password;
            Entrenador entrenador = Entrenador.listaEntrenadores[0];
            return entrenador;
        }

        /// <summary>
        /// Función que cargará un administrador.
        /// </summary>
        /// <returns>Retorna unadministrador</returns>
        public Administrador CargarAdministrador()
        {
            this.txtUsuario.Text = Administrador.listaAdministradores[0].user;
            this.txtClave.Text = Administrador.listaAdministradores[0].password;
            Administrador administrador = Administrador.listaAdministradores[0];
            return administrador;
        }

        /// <summary>
        /// Botón que cargará los datos del entrenador en los textbox correspondientes.
        /// </summary>
        private void btnCargarEntrenador_Click(object sender, EventArgs e)
        {
            CargarEntrenador();
            btnSeCargoEntrenador = true;
            btnSeCargoAdministrador = false;
        }

        /// <summary>
        /// Botón que cargará los datos del administrador en los textbox correspondientes.
        /// </summary>
        private void btnCargarAdmin_Click(object sender, EventArgs e)
        {
            CargarAdministrador();
            btnSeCargoAdministrador = true;
            btnSeCargoEntrenador = false;
        }

        /// <summary>
        /// Función que chequea si los usuarios ingresados son correctos
        /// </summary>
        /// <param name="usuario">Usuario que se pasará para chequear</param>
        /// <param name="password">Password que se pasará para chequear</param>
        /// <returns>Retorna true en caso correcto, sino false</returns>
        public bool CheckearUsuario(string usuario, string password)
        {
            bool flag = false;

            try
            {
                if ((usuario == "AshKetchum" && password == "charizard") || (usuario == "ProfesorOak" && password == "pueblopaleta"))
                {
                    flag = true;
                }
                else if (String.IsNullOrEmpty(usuario) && String.IsNullOrEmpty(password))
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    //MessageBox.Show("Campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new CamposVaciosException("Alguno de los campos está vacío");
                }
                else
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    //MessageBox.Show("Campos incorrectos", "Datos erroneos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    throw new CamposErroneosException("Alguno de los campos es incorrecto");
                }
            }
            catch (CamposVaciosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (CamposErroneosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return flag;
        }

        /// <summary>
        /// Botón que cerrará toda la aplicación.
        /// </summary>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Cuando se intente cerrar la app por completo, si se preguntará si está seguro.
        /// </summary>
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Media.SystemSounds.Exclamation.Play();

            if (MessageBox.Show("¿Esta seguro que desea salir?", "Salida", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
