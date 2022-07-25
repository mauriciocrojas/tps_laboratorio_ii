using Entidades;
using System;
using System.Windows.Forms;

namespace Entidades
{
    public partial class FrmEventos : Form
    {
        CentroPokemon centroPokemon;
        public FrmEventos()
        {
            InitializeComponent();
            centroPokemon = new CentroPokemon(GeneradorDeDatos.Rnd.Next(10, 33));
            centroPokemon.cupoLleno += MensajeCupoLleno;
            centroPokemon.cupoLleno += DesactivarForm;
        }

        /// <summary>
        /// Función que lanzará un messageBox y desactivará el DataGrid si la capacidad de Centro se completa.
        /// </summary>
        /// <param name="centroPokemonLleno"></param>
        private void MensajeCupoLleno(bool centroPokemonLleno)
        {
            if (centroPokemonLleno)
            {
                MessageBox.Show("El Centro Pokemon se encuentra completo. Vuelva pronto.\nLos esperamos");
                this.dtg_listado.Enabled = !centroPokemonLleno;
            }
        }

        /// <summary>
        /// Función que desactivará el botón de TraerPokemonAleatorio.
        /// </summary>
        /// <param name="estado"></param>
        private void DesactivarForm(bool estado)
        {
            this.btnTraerPokemonAleatorio.Enabled = !estado;
        }

        /// <summary>
        /// Botón que traerá una lista de pokemon al DataGrid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTraerPokemonAleatorio_Click(object sender, EventArgs e)
        {
            dtg_listado.DataSource = null;
            dtg_listado.DataSource = centroPokemon.TraerPokemon();
        }
    }
}
