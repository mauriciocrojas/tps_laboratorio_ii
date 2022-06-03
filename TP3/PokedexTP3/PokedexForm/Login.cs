using Entidades;
using System;
using System.Windows.Forms;

namespace PokedexApp
{
    public partial class Login : Form
    {
        private bool btnSeCargoEmp = false;
        private bool btnSeCargoAdm = false;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (CheckearUsuario(this.txtUsuario.Text, this.txtClave.Text))
            {
                System.Media.SystemSounds.Hand.Play();
                if (btnSeCargoEmp)
                {
                    Acceso acceso = new Acceso("Usuario");
                    acceso.ShowDialog();
                }
                else if (btnSeCargoAdm)
                {
                    Acceso acceso = new Acceso("Administrador");
                    acceso.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Función que cargara un usuario.
        /// </summary>
        /// <returns>Retorna un usuario</returns>
        public Usuario CargarUsuario()
        {
            this.txtUsuario.Text = Usuario.listaUsuarios[0].user;
            this.txtClave.Text = Usuario.listaUsuarios[0].password;
            Usuario usuario = Usuario.listaUsuarios[0];
            return usuario;
        }

        /// <summary>
        /// Función que cargará un administrador.
        /// </summary>
        /// <returns>Retorna unadministrador</returns>
        public Administrador CargarAdministrador()
        {
            this.txtUsuario.Text = Administrador.listaAdministradores[0].user;
            this.txtClave.Text = Administrador.listaAdministradores[0].password;
            Administrador usuario = Administrador.listaAdministradores[0];
            return usuario;
        }

        /// <summary>
        /// Botón que cargará los datos del usuario en los textbox correspondientes.
        /// </summary>
        private void btnCargarUsu_Click(object sender, EventArgs e)
        {
            CargarUsuario();
            btnSeCargoEmp = true;
            btnSeCargoAdm = false;
        }

        /// <summary>
        /// Botón que cargará los datos del administrador en los textbox correspondientes.
        /// </summary>
        private void btnCargarAdmin_Click(object sender, EventArgs e)
        {
            CargarAdministrador();
            btnSeCargoAdm = true;
            btnSeCargoEmp = false;
        }

        /// <summary>
        /// Función que chequea si los usuarios ingresados son correctos
        /// </summary>
        /// <param name="usuario">Usuario que se pasará para chequear</param>
        /// <param name="password">Password que se pasará para chequear</param>
        /// <returns>Retorna true en caso correcto, sino false</returns>
        public bool CheckearUsuario(string usuario, string password)
        {
            if ((usuario == "aperez" && password == "arielsito") || (usuario == "lmessi" && password == "copaamerica"))
            {
                return true;
            }
            else if (String.IsNullOrEmpty(usuario) && String.IsNullOrEmpty(password))
            {
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("Campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("Campos incorrectos", "Datos erroneos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
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
