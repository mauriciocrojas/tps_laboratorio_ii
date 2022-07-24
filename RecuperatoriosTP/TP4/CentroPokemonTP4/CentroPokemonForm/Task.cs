using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

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

        private void ComenzarCarga()
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
        }

        private void btn_comenzarCarga_Click(object sender, EventArgs e)
        {
            btn_comenzarCarga.Enabled = false;
            cargaPokemon.Start();
        }

        private void btn_cancelarCarga_Click_1(object sender, EventArgs e)
        {
            btn_cancelarCarga.Enabled = false;
            MessageBox.Show("Carga de pokemon cancelada");
            cts.Cancel();
        }
    }
}
