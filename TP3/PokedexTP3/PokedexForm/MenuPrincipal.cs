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
                this.Text = "Pokedex - Menú Administrador";
            }
            else
            {
                this.btnVerUsu.Enabled = false;
                this.BackColor = System.Drawing.Color.MistyRose;
                this.chkHabAgrPok.Visible = false;
                this.grpAgregarPokemon.Visible = false;
                this.Text = "Pokedex - Menú Entrenador";
            }

            MostrarPokemonEnListaPokemon();

        }


        /// <summary>
        /// Botón que a través de un MessageBox, mostrará sólo al Administrador,
        /// los usuarios actuales de la app.
        /// </summary>
        private void btnVerUsuarios_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Entrenador.MostrarDatos(), "Usuarios de la app");
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
                string cadena = Entrenador.listaEntrenadores[0].MostrarDato();
                MessageBox.Show(cadena, "Usuario logueado tipo: Entrenador");
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
            try
            {
                foreach (Pokemon pokemon in Pokemon.listaPokemon)
                {
                    if (pokemon.nombre == (string)this.lstPokemon.SelectedItem)
                    {
                        this.rchPokemon.Text = pokemon.MostrarDato();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("¡Lanzaste una excepción!", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        public void MostrarPokemonEnRichTextPokemon()
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
                MostrarPokemonEnRichTextPokemon();
                MessageBox.Show("Se agregó el pokemón", "Agregado correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error o faltante de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnLanzarAtaque_Click(object sender, EventArgs e)
        {
            if (this.lstPokemon.SelectedItem is not null)
            {
                string pokemonSeleccionado = (string)this.lstPokemon.SelectedItem;

                MessageBox.Show(pokemonSeleccionado.LanzarAtaque(), "¡Te han atacado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("No se seleccionó ningún pokemon", "¡Elegí un pokemon!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
