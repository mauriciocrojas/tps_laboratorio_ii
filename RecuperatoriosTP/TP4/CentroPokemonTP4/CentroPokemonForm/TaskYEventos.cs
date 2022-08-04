using Entidades;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokedexApp
{
    public partial class FrmProgramacionMultiHiloYEventos : Form
    {
        Task cargaPokemon;
        CancellationTokenSource cts;
        int cupoCentro;

        CentroPokemon centroPokemon;

        bool hayLugar;

        public FrmProgramacionMultiHiloYEventos()
        {
            InitializeComponent();
            cts = new CancellationTokenSource();
            cargaPokemon = new Task(ComenzarCarga);

            centroPokemon = new CentroPokemon(20);
            cupoCentro = centroPokemon.cupo;
            centroPokemon.cupoLleno += MensajeCupoLleno;
            centroPokemon.cupoLleno += DesactivarForm;

            hayLugar = true;
        }

        /// <summary>
        /// Función que cargará un pokemon aleatorio desde la lista cada dos segundos, en un DataGrid.
        /// </summary>
        private void ComenzarCarga()
        {
            try
            {

                while (hayLugar)
                {
                    if (cts.IsCancellationRequested)
                    {
                        return;
                    }
                    else if (this.dtg_listado.InvokeRequired)
                    {

                        this.dtg_listado.BeginInvoke((MethodInvoker)delegate ()
                        {
                            dtg_listado.DataSource = null;
                            dtg_listado.DataSource = centroPokemon.TraerPokemon();
                        });
                    }
                    Thread.Sleep(100);

                    cupoCentro--;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo realizar la carga de datos");
            }
        }

        /// <summary>
        /// Función que lanzará un messageBox y desactivará el DataGrid si la capacidad de Centro se completa.
        /// </summary>
        /// <param name="centroPokemonLleno"></param>
        private void MensajeCupoLleno(bool centroPokemonLleno)
        {
            if (centroPokemonLleno)
            {
                hayLugar = !centroPokemonLleno;
                MessageBox.Show("El Centro Pokemon completó sus 20 lugares. Vuelva pronto.\nLos esperamos");
                this.dtg_listado.Enabled = !centroPokemonLleno;
            }
        }

        /// <summary>
        /// Función que desactivará el botón de TraerPokemonAleatorio.
        /// </summary>
        /// <param name="estado"></param>
        private void DesactivarForm(bool estado)
        {
            this.btn_comenzarCarga.Enabled = !estado;
            this.btn_cancelarCarga.Enabled = !estado;
        }

        /// <summary>
        /// Botón que comenzará la carga aleatoria de pokemon.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_comenzarCarga_Click(object sender, EventArgs e)
        {
            try
            {
                btn_comenzarCarga.Enabled = false;
                cargaPokemon.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo comenzar la carga.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Botón que cancelará la carga aleatoria de pokemon.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancelarCarga_Click_1(object sender, EventArgs e)
        {
            try
            {
                btn_cancelarCarga.Enabled = false;
                MessageBox.Show("Carga de pokemon cancelada");
                cts.Cancel();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cancelar la carga.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
