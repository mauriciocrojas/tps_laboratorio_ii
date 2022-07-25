using Entidades;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokedexApp
{
    public partial class FrmProgramacionMultiHilo : Form
    {
        Task cargaPokemon;
        CancellationTokenSource cts;
        List<Pokemon> listaPokemon;

        public FrmProgramacionMultiHilo()
        {
            InitializeComponent();
            cts = new CancellationTokenSource();
            cargaPokemon = new Task(ComenzarCarga);
            listaPokemon = new List<Pokemon>();
        }

        /// <summary>
        /// Función que cargará un pokemon aleatorio desde la lista cada dos segundos, en un DataGrid.
        /// </summary>
        private void ComenzarCarga()
        {
            try
            {

                while (true)
                {
                    if (cts.IsCancellationRequested)
                    {
                        return;
                    }
                    else if (this.dtg_listado.InvokeRequired)
                    {
                        listaPokemon.Add(GeneradorDeDatos.GetUnPokemon);

                        this.dtg_listado.BeginInvoke((MethodInvoker)delegate ()
                        {
                            dtg_listado.DataSource = null;
                            dtg_listado.DataSource = listaPokemon;
                        });
                    }
                    Thread.Sleep(2000);
                }
            }catch (Exception)
            {
                MessageBox.Show("No se pudo realizar la carga de datos");
            }
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
                MessageBox.Show("No se pudo a comenzar la carga.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
