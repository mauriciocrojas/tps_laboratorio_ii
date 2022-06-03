using Entidades;
using System;
using System.Windows.Forms;

namespace PokedexApp
{
    public partial class Acceso : Form
    {
        public string tipoUsuario;

        /// <summary>
        /// Constructor que recibe un usuario para luego trabajar con él y otros atributos.
        /// </summary>
        /// <param name="usuario">Usuario que definirá cómo se mostrarará el formulario de acceso</param>
        public Acceso(string tipoUsuario)
        {
            InitializeComponent();

            this.tipoUsuario = tipoUsuario;
        }

        private void Acceso_Load(object sender, EventArgs e)
        {

            if (tipoUsuario == "Administrador")
            {
                this.btnVerUsu.Enabled = true;
                this.BackColor = System.Drawing.Color.AliceBlue;
            }
            else
            {
                this.btnVerUsu.Enabled = false;
                this.BackColor = System.Drawing.Color.MistyRose;
            }
        }


        /// <summary>
        /// Botón que a través de un MessageBox, mostrará sólo al Administrador,
        /// los usuarios actuales de la app.
        /// </summary>
        private void btnVerUsuarios_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Usuario.MostrarDatos(), "Usuarios de la app");
        }

        /// <summary>
        /// Botón que abrirá un formulario para ver y administrar el stock:
        ///El administrador podrá acceder a:
        /// Un control de stock y posibilidad de agregar nuevos productos.
        /// El empleado:
        /// Sólo control de Stock.
        /// </summary>
        private void btnControlDeStock(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Evento donde agruparemos el clickeo de cualquier botón-ubicación de mesa o barra,
        /// se analizará esa ubicación, y acorde a eso se abrirá la misma.
        /// </summary>
        private void btnUbicacion(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Botón que mostrará el usuario logueado actualmente
        /// </summary>
        private void btnUsuarioLogeado_Click(object sender, EventArgs e)
        {
            if (tipoUsuario == "Administrador")
            {
                string cadena = Administrador.listaAdministradores[0].MostrarDato();
                MessageBox.Show(cadena, "Usuario logueado tipo Administrador");
            }
            else
            {
                string cadena = Usuario.listaUsuarios[0].MostrarDato();
                MessageBox.Show(cadena, "Usuario logueado tipo Usuario simple");
            }
        }

        /// <summary>
        /// Botón que cerrará toda la aplicación.
        /// </summary>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Botón que irá un pasó atrás en la aplicación.
        /// </summary>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
