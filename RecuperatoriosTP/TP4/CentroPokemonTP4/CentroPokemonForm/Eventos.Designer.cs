namespace Entidades
{
    partial class FrmEventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEventos));
            this.lb_seccion = new System.Windows.Forms.Label();
            this.btnTraerPokemonAleatorio = new System.Windows.Forms.Button();
            this.dtg_listado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listado)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_seccion
            // 
            this.lb_seccion.AutoSize = true;
            this.lb_seccion.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_seccion.ForeColor = System.Drawing.Color.RosyBrown;
            this.lb_seccion.Location = new System.Drawing.Point(197, 9);
            this.lb_seccion.Name = "lb_seccion";
            this.lb_seccion.Size = new System.Drawing.Size(109, 37);
            this.lb_seccion.TabIndex = 8;
            this.lb_seccion.Text = "Eventos";
            // 
            // btnTraerPokemonAleatorio
            // 
            this.btnTraerPokemonAleatorio.Location = new System.Drawing.Point(142, 427);
            this.btnTraerPokemonAleatorio.Name = "btnTraerPokemonAleatorio";
            this.btnTraerPokemonAleatorio.Size = new System.Drawing.Size(199, 76);
            this.btnTraerPokemonAleatorio.TabIndex = 6;
            this.btnTraerPokemonAleatorio.Text = "Traer Pokemon Aleatorio";
            this.btnTraerPokemonAleatorio.UseVisualStyleBackColor = true;
            this.btnTraerPokemonAleatorio.Click += new System.EventHandler(this.btnTraerPokemonAleatorio_Click);
            // 
            // dtg_listado
            // 
            this.dtg_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_listado.Location = new System.Drawing.Point(12, 61);
            this.dtg_listado.Name = "dtg_listado";
            this.dtg_listado.RowTemplate.Height = 25;
            this.dtg_listado.Size = new System.Drawing.Size(498, 349);
            this.dtg_listado.TabIndex = 9;
            // 
            // FrmEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 515);
            this.Controls.Add(this.dtg_listado);
            this.Controls.Add(this.lb_seccion);
            this.Controls.Add(this.btnTraerPokemonAleatorio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEventos";
            this.Text = "Eventos";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_seccion;
        private System.Windows.Forms.Button btnTraerPokemonAleatorio;
        private System.Windows.Forms.DataGridView dtg_listado;
    }
}