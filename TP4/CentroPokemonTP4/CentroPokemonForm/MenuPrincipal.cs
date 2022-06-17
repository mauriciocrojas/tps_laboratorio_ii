﻿using Entidades;
using System;
using System.Windows.Forms;

namespace PokedexApp
{
    public partial class MenuPrincipal : Form
    {
        public string tipoUsuario;

        /// <summary>
        /// Constructor que recibe un usuario para luego trabajar con él.
        /// </summary>
        /// <param name="tipoUsuario">Usuario que definirá cómo se mostrarará el formulario de MenuPrincipal</param>
        public MenuPrincipal(string tipoUsuario)
        {
            InitializeComponent();
            this.tipoUsuario = tipoUsuario;
        }

        /// <summary>
        /// Se determina cómo se cargará el formulario MenuPrincipal.
        /// </summary>
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            if (tipoUsuario == "Administrador")
            {
                this.btnVerEntrenadores.Enabled = true;
                this.BackColor = System.Drawing.Color.AliceBlue;
                this.grpAgregarPokemon.Enabled = false;
                this.Text = "Centro Pokemon - Menú enfermería";
            }
            else
            {
                this.btnVerEntrenadores.Enabled = false;
                this.BackColor = System.Drawing.Color.MistyRose;
                this.chkHabAgrPok.Visible = false;
                this.grpAgregarPokemon.Visible = false;
                this.Text = "Centro Pokemon - Menú Entrenadores";
            }

            MostrarPokemonEnListaPokemon();
        }


        /// <summary>
        /// Botón que mostrará el usuario logueado actualmente.
        /// </summary>
        private void btnUsuarioLogeado_Click(object sender, EventArgs e)
        {
            if (tipoUsuario == "Administrador")
            {
                string cadena = Administrador.listaAdministradores[0].MostrarDato();
                MessageBox.Show(cadena, "Usuario logueado tipo: Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string cadena = Entrenador.listaEntrenadores[0].MostrarDato();
                MessageBox.Show(cadena, "Usuario logueado tipo: Entrenador", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                foreach (Pokemon pokemon in Pokemon.ListaPokemon)
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

        /// <summary>
        /// Carga los pokemon de la listaPokemon en la lstPokemon del form.
        /// </summary>
        public void MostrarPokemonEnListaPokemon()
        {
            lstPokemon.Items.Clear();
            foreach (Pokemon pokemon in Pokemon.ListaPokemon)
            {
                this.lstPokemon.Items.Add(pokemon.nombre);
            }
        }

        /// <summary>
        /// Muestra el último pokemon cargado en el rchPokemon.
        /// </summary>
        public void MostrarPokemonEnRichTextPokemon()
        {
            foreach (Pokemon pokemon in Pokemon.ListaPokemon)
            {
                this.rchPokemon.Text = pokemon.MostrarDato();
            }
        }

        /// <summary>
        /// Según si está marcado o no el chkAgregarPokemon, se habilitará el grpAgregarPokemon.
        /// </summary>
        private void chkHabAgrPok_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHabAgrPok.Checked)
            {
                this.grpAgregarPokemon.Enabled = true;
            }
            else { this.grpAgregarPokemon.Enabled = false; }
        }

        /// <summary>
        /// Botón que agregará un nuevo pokemon a la lista, y en caso de éxito, lo mostrará.
        /// </summary>
        private void btnAgregarPokemonManual_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(this.txtDanio.Text) < 0)
                {
                    MessageBox.Show("El porcentaje del daño del pokemon no puede ser negativo, carguelo correctamente", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (int.Parse(this.txtDanio.Text) > 100)
                {
                    MessageBox.Show("El porcentaje del daño del pokemon no puede ser mayor a 100, carguelo correctamente", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(int.Parse(this.txtIDPokemon.Text) <= 0)
                {
                    MessageBox.Show("El ID del pokemon no puede ser 0 ni negativo, carguelo correctamente", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Pokemon.AgregarPokemonManual(this.txtNombrePokemon.Text, this.txtTipoPokemon.Text, int.Parse(this.txtIDPokemon.Text), this.txtAtaquePokemon.Text, int.Parse(this.txtDanio.Text)))
                    {
                        MostrarPokemonEnListaPokemon();
                        MostrarPokemonEnRichTextPokemon();
                        MessageBox.Show("Se agregó el pokemón.", "Agregado correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El id o el nombre del pokemón ya se encuentra registrado en el centro. Se admite solo un mismo tipo de pokemon, por ejemplo, un solo Pikachu, proximamente ampliaremos el centro, sepa disculpar las molestias.", "Admisión no aceptada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hay campos que se encuentran vacíos.", "Error en los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sólo permitimos ingreso de números.
        /// </summary>
        private void txtIDPokemon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solamente números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sólo permitimos ingreso de números.
        /// </summary>
        private void txtDanio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solamente números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sólo permitimos ingreso de letras.
        /// </summary>
        private void txtNombrePokemon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solamente letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sólo permitimos ingreso de letras.
        /// </summary>
        private void txtTipoPokemon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solamente letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sólo permitimos ingreso de letras.
        /// </summary>
        private void txtAtaquePokemon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solamente letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Función que imprime por pantalla todos los entrenadores registrados en la app.
        /// </summary>
        private void btnVerEntrenadores_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Entrenador.MostrarDatos(), "Entrenadores registrados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Función que hace que un pokemon lance un ataque y imprima por pantalla.
        /// </summary>
        private void btnCurarPokemon_Click(object sender, EventArgs e)
        {

            if (this.lstPokemon.SelectedItem is not null)
            {
                string pokemonSeleccionado = (string)this.lstPokemon.SelectedItem;

                foreach (Pokemon pokemon in Pokemon.ListaPokemon)
                {
                    if (pokemon.nombre == pokemonSeleccionado)
                    {

                        if (pokemon.danio == 0)
                        {
                            MessageBox.Show("El pokemón no presenta daños", "¡Elegí un pokemon aún sin sanar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show(pokemonSeleccionado.CurarPokemon(), "Estado de salud", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No se seleccionó ningún pokemon", "¡Elegí un pokemon a sanar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
