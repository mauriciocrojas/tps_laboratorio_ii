namespace PokedexApp
{
    partial class FrmProgramacionMultiHilo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProgramacionMultiHilo));
            this.lblCargaPokemon = new System.Windows.Forms.Label();
            this.btn_comenzarCarga = new System.Windows.Forms.Button();
            this.dtg_listado = new System.Windows.Forms.DataGridView();
            this.btn_cancelarCarga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCargaPokemon
            // 
            this.lblCargaPokemon.AutoSize = true;
            this.lblCargaPokemon.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCargaPokemon.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblCargaPokemon.Location = new System.Drawing.Point(197, 27);
            this.lblCargaPokemon.Name = "lblCargaPokemon";
            this.lblCargaPokemon.Size = new System.Drawing.Size(425, 37);
            this.lblCargaPokemon.TabIndex = 9;
            this.lblCargaPokemon.Text = "Carga aleatoria de Pokemon (Task)";
            // 
            // btn_comenzarCarga
            // 
            this.btn_comenzarCarga.Location = new System.Drawing.Point(67, 444);
            this.btn_comenzarCarga.Name = "btn_comenzarCarga";
            this.btn_comenzarCarga.Size = new System.Drawing.Size(274, 63);
            this.btn_comenzarCarga.TabIndex = 8;
            this.btn_comenzarCarga.Text = "Comenzar carga Pokemon";
            this.btn_comenzarCarga.UseVisualStyleBackColor = true;
            this.btn_comenzarCarga.Click += new System.EventHandler(this.btn_comenzarCarga_Click);
            // 
            // dtg_listado
            // 
            this.dtg_listado.AllowUserToAddRows = false;
            this.dtg_listado.AllowUserToDeleteRows = false;
            this.dtg_listado.AllowUserToResizeColumns = false;
            this.dtg_listado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_listado.Location = new System.Drawing.Point(67, 82);
            this.dtg_listado.Name = "dtg_listado";
            this.dtg_listado.RowHeadersVisible = false;
            this.dtg_listado.RowTemplate.Height = 25;
            this.dtg_listado.Size = new System.Drawing.Size(653, 322);
            this.dtg_listado.TabIndex = 7;
            // 
            // btn_cancelarCarga
            // 
            this.btn_cancelarCarga.Location = new System.Drawing.Point(443, 444);
            this.btn_cancelarCarga.Name = "btn_cancelarCarga";
            this.btn_cancelarCarga.Size = new System.Drawing.Size(277, 63);
            this.btn_cancelarCarga.TabIndex = 6;
            this.btn_cancelarCarga.Text = "Cancelar Carga Pokemon";
            this.btn_cancelarCarga.UseVisualStyleBackColor = true;
            this.btn_cancelarCarga.Click += new System.EventHandler(this.btn_cancelarCarga_Click_1);
            // 
            // FrmProgramacionMultiHilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.lblCargaPokemon);
            this.Controls.Add(this.btn_comenzarCarga);
            this.Controls.Add(this.dtg_listado);
            this.Controls.Add(this.btn_cancelarCarga);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProgramacionMultiHilo";
            this.Text = "Task";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCargaPokemon;
        private System.Windows.Forms.Button btn_comenzarCarga;
        private System.Windows.Forms.DataGridView dtg_listado;
        private System.Windows.Forms.Button btn_cancelarCarga;
    }
}