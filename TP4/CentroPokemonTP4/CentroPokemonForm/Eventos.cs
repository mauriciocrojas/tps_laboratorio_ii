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

        private void MensajeCupoLleno(bool centroPokemonLleno)
        {
            if (centroPokemonLleno)
            {
                MessageBox.Show("El Centro Pokemon se encuentra completo. Vuelva pronto.\nLos esperamos");
                this.dtg_listado.Enabled = !centroPokemonLleno;
            }
        }

        private void DesactivarForm(bool estado)
        {
            this.btnTraerPokemonAleatorio.Enabled = !estado;
        }

        private void btnTraerPokemonAleatorio_Click(object sender, EventArgs e)
        {
            dtg_listado.DataSource = null;
            dtg_listado.DataSource = centroPokemon.TraerPokemon();
        }
    }
}
