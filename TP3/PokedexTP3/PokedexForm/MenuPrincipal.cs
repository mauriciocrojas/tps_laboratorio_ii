using Entidades;
using System;
using System.Windows.Forms;

namespace PokedexApp
{
    public partial class MenuPrincipal : Form
    {
        public string tipoUsuario;

        /// <summary>
        /// Constructor que recibe un usuario para luego trabajar con él y otros atributos.
        /// </summary>
        /// <param name="tipoUsuario">Usuario que definirá cómo se mostrarará el formulario de acceso</param>
        public MenuPrincipal(string tipoUsuario)
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
                this.grpAgregarPokemon.Enabled = false;
            }
            else
            {
                this.btnVerUsu.Enabled = false;
                this.BackColor = System.Drawing.Color.MistyRose;
                this.chkHabAgrPok.Visible = false;
                this.grpAgregarPokemon.Visible = false;
            }

            MostrarPokemonEnListaPokemon();

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
                MessageBox.Show(cadena, "Usuario logueado tipo: Administrador");
            }
            else
            {
                string cadena = Usuario.listaUsuarios[0].MostrarDato();
                MessageBox.Show(cadena, "Usuario logueado tipo: Usuario simple");
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

        /// <summary>
        /// Al  seleccionar un item de la lista, mandará la descripción de mismo al RichTextBox.
        /// </summary>
        private void lstPokemon_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Pokemon pokemon in Pokemon.listaPokemon)
            {
                if (pokemon.nombre == this.lstPokemon.SelectedItem.ToString())
                {
                    this.rchPokemon.Text = pokemon.MostrarDato();
                }
            }
        }

        public void MostrarPokemonEnListaPokemon()
        {
            lstPokemon.Items.Clear();
            foreach (Pokemon pokemon in Pokemon.listaPokemon)
            {
                this.lstPokemon.Items.Add(pokemon.nombre);
            }
        }


        public void MostrarListaPokemonEnRchPokemon()
        {
            foreach (Pokemon pokemon in Pokemon.listaPokemon)
            {
                this.rchPokemon.Text = pokemon.MostrarDato();
            }
        }

        private void chkHabAgrPok_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHabAgrPok.Checked)
            {
                this.grpAgregarPokemon.Enabled = true;
            }
            else { this.grpAgregarPokemon.Enabled = false; }
        }

        private void btnAgregarPokemon_Click(object sender, EventArgs e)
        {
            if (Pokemon.AgregarPokemon(this.txtNombrePokemon.Text, this.txtTipoPokemon.Text, this.txtIDPokemon.Text, this.txtAtaquePokemon.Text))
            {
                MostrarPokemonEnListaPokemon();
                MostrarListaPokemonEnRchPokemon();
                MessageBox.Show("Se agregó el pokemón");
            }
            else
            {
                MessageBox.Show("Error o faltante de datos");
            }
        }

        private void txtIDPokemon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solamente números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombrePokemon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solamente letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTipoPokemon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solamente letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAtaquePokemon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solamente letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
