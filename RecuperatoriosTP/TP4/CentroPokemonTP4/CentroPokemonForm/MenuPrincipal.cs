using Entidades;
using Entidades.Clases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PokedexApp
{
    public partial class MenuPrincipal : Form
    {
        public string tipoUsuario;
        Pokemon.DesalojarDelCentro desalojarDelCentro = Pokemon.DesalojarPokemon;

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
                this.BackColor = System.Drawing.Color.AliceBlue;
                this.Text = "Centro Pokemon - Menú enfermería";
            }
            else
            {
                this.grpAgregarPokemon.Enabled = false;
                this.grpLeerArchivo.Enabled = false;
                this.grpGuardarArchivo.Enabled = false;
                this.btnVerEntrenadores.Enabled = false;
                this.btnCurarPokemon.Enabled = false;
                this.BackColor = System.Drawing.Color.MistyRose;
                this.grpAgregarPokemon.Enabled = false;
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
        /// Al  seleccionar un item de la lista, mandará la descripción del mismo al RichTextBox.
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
        /// Botón que agregará un nuevo pokemon a la lista, y en caso de éxito, lo mostrará.
        /// </summary>
        private void btnAgregarPokemonManual_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(this.txtDanio.Text) < 0)
                {
                    MessageBox.Show("El porcentaje del daño del pokemon no puede ser negativo, carguelo correctamente.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (int.Parse(this.txtDanio.Text) > 100)
                {
                    MessageBox.Show("El porcentaje del daño del pokemon no puede ser mayor a 100, carguelo correctamente.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (int.Parse(this.txtIDPokemon.Text) <= 0)
                {
                    MessageBox.Show("El ID del pokemon no puede ser 0 ni negativo, carguelo correctamente.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (String.IsNullOrWhiteSpace(this.txtNombrePokemon.Text) || String.IsNullOrWhiteSpace(this.txtTipoPokemon.Text) || String.IsNullOrWhiteSpace(this.txtIDPokemon.Text) ||
                String.IsNullOrWhiteSpace(this.txtAtaquePokemon.Text) || String.IsNullOrWhiteSpace(this.txtDanio.Text))
                {
                    MessageBox.Show("Hay campos vacíos o erróneos, se necesitan completar todos los campos.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Pokemon.AgregarPokemonManualALaLista(this.txtNombrePokemon.Text, this.txtTipoPokemon.Text, int.Parse(this.txtIDPokemon.Text), this.txtAtaquePokemon.Text, int.Parse(this.txtDanio.Text)))
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
                MessageBox.Show("Hay campos que se encuentran vacíos o con datos inválidos.", "Error en los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Solamente números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Solamente números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Solamente letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Solamente letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Solamente letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Función que imprime por pantalla todos los entrenadores registrados en la app.
        /// </summary>
        private void btnVerEntrenadores_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Entrenador.MostrarDatos(), "Entrenadores registrados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardarEnArchivoTxt_Click(object sender, EventArgs e)
        {
            try
            {
                Pokemon.EscribirTxt();
                MessageBox.Show("Se guardó el archivo .txt correctamente.", "Guardado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al intentar guardar archivo .txt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLeerDeArchivoTxt_Click(object sender, EventArgs e)
        {
            string datosArchivo = Pokemon.LeerTxt("/Listado de Pokemon en el Centro.txt");

            if (datosArchivo != string.Empty)
            {
                this.rchPokemon.Text = "Leyendo desde archivo txt:\n\n" + datosArchivo;
                MessageBox.Show("Datos del archivo .txt cargado en la lista.", "Lectura correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo acceder al archivo .txt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarEnArchivoXml_Click(object sender, EventArgs e)
        {
            try
            {
                Pokemon.EscribirXml(Pokemon.ListaPokemon);
                MessageBox.Show("Se guardó el archivo .xml correctamente.", "Guardado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al intentar guardar archivo .xml.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLeerDeArchivoXml_Click(object sender, EventArgs e)
        {
            List<Pokemon> datosArchivo = Pokemon.LeerXml();

            if (datosArchivo is not null)
            {
                this.rchPokemon.Text = "Leyendo desde archivo xml:\n\n";

                foreach (var item in datosArchivo)
                {
                    this.rchPokemon.Text += item.MostrarDato() + "\n\n";
                }

                MessageBox.Show("Datos del archivo .xml cargado en la lista.", "Lectura correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo acceder al archivo .xml.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarEnArchivoJson_Click(object sender, EventArgs e)
        {
            try
            {
                Pokemon.EscribirJsonLista(Pokemon.ListaPokemon);
                MessageBox.Show("Se guardó el archivo json correctamente.", "Guardado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLeerDeArchivoJson_Click(object sender, EventArgs e)
        {
            List<Pokemon> datosArchivo = Pokemon.LeerJson();

            if (datosArchivo is not null)
            {
                this.rchPokemon.Text = "Leyendo desde archivo json:\n\n";

                foreach (var item in datosArchivo)
                {
                    this.rchPokemon.Text += item.MostrarDato() + "\n\n";
                }

                MessageBox.Show("Datos del archivo .json cargado en la lista.", "Lectura correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo acceder al archivo .json.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Carga los datos de la base de datos en el RichTextBox.
        /// </summary>
        private void btnCargarDeBaseDatos_Click(object sender, EventArgs e)
        {
            try
            {
                List<Pokemon> auxListaPokemon = PokemonAccesoDatos.Leer();
                this.rchPokemon.Text = "Leyendo pokemon alojados desde base de datos:" + "\n\n";

                if (auxListaPokemon.Count < 1)
                {
                    this.rchPokemon.Text = "Antes de cargar la lista de la base, debe presionar el botón guardar lista en base.";
                    throw new Exception();
                }
                foreach (var pokemonAux in auxListaPokemon)
                {
                    this.rchPokemon.Text += pokemonAux.MostrarDato() + "\n\n";
                }
                MessageBox.Show("Listado de la base de datos cargado en la lista.", "Lectura correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (CamposErroneosException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo acceder a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Botón que desaloja y elimina un pokemon de la lista y de la base si se encontrará.
        /// </summary>
        private void btnDesalojarPokemon_Click(object sender, EventArgs e)
        {
            if (this.lstPokemon.SelectedItem is not null)
            {
                string pokemonSeleccionado = (string)this.lstPokemon.SelectedItem;
                if (PokemonAccesoDatos.EliminarPokemonDeBase(pokemonSeleccionado) && desalojarDelCentro(pokemonSeleccionado))
                {
                    MessageBox.Show($"Se desalojó a {pokemonSeleccionado}, se quitó de la lista y de la base si se encontraba en ella.", "Desalojo exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarPokemonEnListaPokemon();
                }
                else
                {
                    MessageBox.Show("El pokemon aún no se encuentra curado.", "Elegí un pokemon sano", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No se seleccionó ningún pokemon.", "Elegí un pokemon a desalojar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Botón que cura un pokemon, tanto en la lista como en la base.
        /// </summary>
        private void btnCurarPokemon_Click(object sender, EventArgs e)
        {
            try
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
                                MessageBox.Show("El pokemón no presenta daños.", "Elegí un pokemon dañado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    MessageBox.Show("No se seleccionó ningún pokemon.", "Elegí un pokemon a sanar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al intentar leer pokemon.", "Elegí un pokemon a sanar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Botón que inserta la lista en la base. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarListaEnBase_Click(object sender, EventArgs e)
        {
            try
            {
                PokemonAccesoDatos.GuardarListaEnBase();
                MessageBox.Show("Listado guardado en la base de datos correctamente.", "Guardado correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("No se guardar la lista en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargarCuradosBase_Click(object sender, EventArgs e)
        {
            try
            {
                List<Pokemon> auxListaPokemon = PokemonAccesoDatos.LeerCurados();
                this.rchPokemon.Text = "Leyendo pokemon curados desde base de datos:" + "\n\n";

                if (auxListaPokemon.Count < 1)
                {
                    this.rchPokemon.Text = "Antes de cargar la lista de curados de la base, debe presionar el botón guardar lista en base.";
                    throw new Exception();
                }
                foreach (var pokemonAux in auxListaPokemon)
                {
                    this.rchPokemon.Text += pokemonAux.MostrarDato() + "\n\n";
                }
                MessageBox.Show("Listado de curados en la base de datos cargado en la lista.", "Lectura correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (CamposErroneosException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo acceder a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
