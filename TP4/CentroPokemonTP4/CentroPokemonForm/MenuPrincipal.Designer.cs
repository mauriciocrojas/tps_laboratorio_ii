namespace PokedexApp
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.btnVerEntrenadores = new System.Windows.Forms.Button();
            this.btnUsuarioLogeado = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lstPokemon = new System.Windows.Forms.ListBox();
            this.rchPokemon = new System.Windows.Forms.RichTextBox();
            this.grpAgregarPokemon = new System.Windows.Forms.GroupBox();
            this.txtDanio = new System.Windows.Forms.TextBox();
            this.btnAgregarPokemon = new System.Windows.Forms.Button();
            this.txtAtaquePokemon = new System.Windows.Forms.TextBox();
            this.txtIDPokemon = new System.Windows.Forms.TextBox();
            this.txtTipoPokemon = new System.Windows.Forms.TextBox();
            this.txtNombrePokemon = new System.Windows.Forms.TextBox();
            this.chkHabAgrPok = new System.Windows.Forms.CheckBox();
            this.btnCurarPokemon = new System.Windows.Forms.Button();
            this.txtPokemonAtendido = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.btnGuardarEnArchivo = new System.Windows.Forms.Button();
            this.btnLeerDeArchivo = new System.Windows.Forms.Button();
            this.grpAgregarPokemon.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerEntrenadores
            // 
            this.btnVerEntrenadores.Location = new System.Drawing.Point(12, 378);
            this.btnVerEntrenadores.Name = "btnVerEntrenadores";
            this.btnVerEntrenadores.Size = new System.Drawing.Size(111, 57);
            this.btnVerEntrenadores.TabIndex = 23;
            this.btnVerEntrenadores.Text = "Ver entrenadores registrados";
            this.btnVerEntrenadores.UseVisualStyleBackColor = true;
            this.btnVerEntrenadores.Click += new System.EventHandler(this.btnVerEntrenadores_Click);
            // 
            // btnUsuarioLogeado
            // 
            this.btnUsuarioLogeado.Location = new System.Drawing.Point(134, 378);
            this.btnUsuarioLogeado.Name = "btnUsuarioLogeado";
            this.btnUsuarioLogeado.Size = new System.Drawing.Size(102, 60);
            this.btnUsuarioLogeado.TabIndex = 24;
            this.btnUsuarioLogeado.Text = "Mostrar usuario logueado";
            this.btnUsuarioLogeado.UseVisualStyleBackColor = true;
            this.btnUsuarioLogeado.Click += new System.EventHandler(this.btnUsuarioLogeado_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Maroon;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(432, 389);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 46);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Firebrick;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVolver.Location = new System.Drawing.Point(341, 389);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(85, 46);
            this.btnVolver.TabIndex = 26;
            this.btnVolver.Text = "Volver Atrás";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lstPokemon
            // 
            this.lstPokemon.FormattingEnabled = true;
            this.lstPokemon.ItemHeight = 15;
            this.lstPokemon.Location = new System.Drawing.Point(13, 31);
            this.lstPokemon.Name = "lstPokemon";
            this.lstPokemon.Size = new System.Drawing.Size(169, 169);
            this.lstPokemon.TabIndex = 27;
            this.lstPokemon.SelectedIndexChanged += new System.EventHandler(this.lstPokemon_SelectedIndexChanged);
            // 
            // rchPokemon
            // 
            this.rchPokemon.Location = new System.Drawing.Point(266, 31);
            this.rchPokemon.Name = "rchPokemon";
            this.rchPokemon.ReadOnly = true;
            this.rchPokemon.Size = new System.Drawing.Size(256, 169);
            this.rchPokemon.TabIndex = 28;
            this.rchPokemon.Text = "";
            // 
            // grpAgregarPokemon
            // 
            this.grpAgregarPokemon.Controls.Add(this.txtDanio);
            this.grpAgregarPokemon.Controls.Add(this.btnAgregarPokemon);
            this.grpAgregarPokemon.Controls.Add(this.txtAtaquePokemon);
            this.grpAgregarPokemon.Controls.Add(this.txtIDPokemon);
            this.grpAgregarPokemon.Controls.Add(this.txtTipoPokemon);
            this.grpAgregarPokemon.Controls.Add(this.txtNombrePokemon);
            this.grpAgregarPokemon.Location = new System.Drawing.Point(22, 256);
            this.grpAgregarPokemon.Name = "grpAgregarPokemon";
            this.grpAgregarPokemon.Size = new System.Drawing.Size(496, 74);
            this.grpAgregarPokemon.TabIndex = 29;
            this.grpAgregarPokemon.TabStop = false;
            this.grpAgregarPokemon.Text = "Agregar Pokemon";
            // 
            // txtDanio
            // 
            this.txtDanio.Location = new System.Drawing.Point(350, 33);
            this.txtDanio.Name = "txtDanio";
            this.txtDanio.PlaceholderText = "Daño %";
            this.txtDanio.Size = new System.Drawing.Size(76, 23);
            this.txtDanio.TabIndex = 4;
            this.txtDanio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDanio_KeyPress);
            // 
            // btnAgregarPokemon
            // 
            this.btnAgregarPokemon.Location = new System.Drawing.Point(432, 33);
            this.btnAgregarPokemon.Name = "btnAgregarPokemon";
            this.btnAgregarPokemon.Size = new System.Drawing.Size(58, 23);
            this.btnAgregarPokemon.TabIndex = 5;
            this.btnAgregarPokemon.Text = "Agregar";
            this.btnAgregarPokemon.UseVisualStyleBackColor = true;
            this.btnAgregarPokemon.Click += new System.EventHandler(this.btnAgregarPokemonManual_Click);
            // 
            // txtAtaquePokemon
            // 
            this.txtAtaquePokemon.Location = new System.Drawing.Point(244, 33);
            this.txtAtaquePokemon.Name = "txtAtaquePokemon";
            this.txtAtaquePokemon.PlaceholderText = "Ataque principal";
            this.txtAtaquePokemon.Size = new System.Drawing.Size(100, 23);
            this.txtAtaquePokemon.TabIndex = 3;
            this.txtAtaquePokemon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAtaquePokemon_KeyPress);
            // 
            // txtIDPokemon
            // 
            this.txtIDPokemon.Location = new System.Drawing.Point(191, 33);
            this.txtIDPokemon.Name = "txtIDPokemon";
            this.txtIDPokemon.PlaceholderText = "ID";
            this.txtIDPokemon.Size = new System.Drawing.Size(47, 23);
            this.txtIDPokemon.TabIndex = 2;
            this.txtIDPokemon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDPokemon_KeyPress);
            // 
            // txtTipoPokemon
            // 
            this.txtTipoPokemon.Location = new System.Drawing.Point(101, 33);
            this.txtTipoPokemon.Name = "txtTipoPokemon";
            this.txtTipoPokemon.PlaceholderText = "Tipo";
            this.txtTipoPokemon.Size = new System.Drawing.Size(84, 23);
            this.txtTipoPokemon.TabIndex = 1;
            this.txtTipoPokemon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipoPokemon_KeyPress);
            // 
            // txtNombrePokemon
            // 
            this.txtNombrePokemon.Location = new System.Drawing.Point(6, 33);
            this.txtNombrePokemon.Name = "txtNombrePokemon";
            this.txtNombrePokemon.PlaceholderText = "Nombre";
            this.txtNombrePokemon.Size = new System.Drawing.Size(84, 23);
            this.txtNombrePokemon.TabIndex = 0;
            this.txtNombrePokemon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombrePokemon_KeyPress);
            // 
            // chkHabAgrPok
            // 
            this.chkHabAgrPok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chkHabAgrPok.AutoSize = true;
            this.chkHabAgrPok.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkHabAgrPok.Location = new System.Drawing.Point(13, 256);
            this.chkHabAgrPok.Name = "chkHabAgrPok";
            this.chkHabAgrPok.Size = new System.Drawing.Size(15, 14);
            this.chkHabAgrPok.TabIndex = 30;
            this.chkHabAgrPok.UseVisualStyleBackColor = true;
            this.chkHabAgrPok.CheckedChanged += new System.EventHandler(this.chkHabAgrPok_CheckedChanged);
            // 
            // btnCurarPokemon
            // 
            this.btnCurarPokemon.Location = new System.Drawing.Point(13, 213);
            this.btnCurarPokemon.Name = "btnCurarPokemon";
            this.btnCurarPokemon.Size = new System.Drawing.Size(111, 37);
            this.btnCurarPokemon.TabIndex = 31;
            this.btnCurarPokemon.Text = "Curar pokemon";
            this.btnCurarPokemon.UseVisualStyleBackColor = true;
            this.btnCurarPokemon.Click += new System.EventHandler(this.btnCurarPokemon_Click);
            // 
            // txtPokemonAtendido
            // 
            this.txtPokemonAtendido.AutoSize = true;
            this.txtPokemonAtendido.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.txtPokemonAtendido.Location = new System.Drawing.Point(12, 11);
            this.txtPokemonAtendido.Name = "txtPokemonAtendido";
            this.txtPokemonAtendido.Size = new System.Drawing.Size(144, 17);
            this.txtPokemonAtendido.TabIndex = 32;
            this.txtPokemonAtendido.Text = "Pokemon en atención:";
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblDetalle.Location = new System.Drawing.Point(266, 11);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(52, 17);
            this.lblDetalle.TabIndex = 33;
            this.lblDetalle.Text = "Detalle:";
            // 
            // btnGuardarEnArchivo
            // 
            this.btnGuardarEnArchivo.Location = new System.Drawing.Point(130, 213);
            this.btnGuardarEnArchivo.Name = "btnGuardarEnArchivo";
            this.btnGuardarEnArchivo.Size = new System.Drawing.Size(130, 37);
            this.btnGuardarEnArchivo.TabIndex = 34;
            this.btnGuardarEnArchivo.Text = "Guardar en archivo";
            this.btnGuardarEnArchivo.UseVisualStyleBackColor = true;
            this.btnGuardarEnArchivo.Click += new System.EventHandler(this.btnGuardarEnArchivo_Click);
            // 
            // btnLeerDeArchivo
            // 
            this.btnLeerDeArchivo.Location = new System.Drawing.Point(266, 214);
            this.btnLeerDeArchivo.Name = "btnLeerDeArchivo";
            this.btnLeerDeArchivo.Size = new System.Drawing.Size(126, 36);
            this.btnLeerDeArchivo.TabIndex = 35;
            this.btnLeerDeArchivo.Text = "Leer de archivo";
            this.btnLeerDeArchivo.UseVisualStyleBackColor = true;
            this.btnLeerDeArchivo.Click += new System.EventHandler(this.btnLeerDeArchivo_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.btnLeerDeArchivo);
            this.Controls.Add(this.btnGuardarEnArchivo);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.txtPokemonAtendido);
            this.Controls.Add(this.btnCurarPokemon);
            this.Controls.Add(this.chkHabAgrPok);
            this.Controls.Add(this.grpAgregarPokemon);
            this.Controls.Add(this.rchPokemon);
            this.Controls.Add(this.lstPokemon);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnUsuarioLogeado);
            this.Controls.Add(this.btnVerEntrenadores);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centro Pokemon Menú";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.grpAgregarPokemon.ResumeLayout(false);
            this.grpAgregarPokemon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVerEntrenadores;
        private System.Windows.Forms.Button btnUsuarioLogeado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ListBox lstPokemon;
        private System.Windows.Forms.RichTextBox rchPokemon;
        private System.Windows.Forms.GroupBox grpAgregarPokemon;
        private System.Windows.Forms.CheckBox chkHabAgrPok;
        private System.Windows.Forms.TextBox txtAtaquePokemon;
        private System.Windows.Forms.TextBox txtIDPokemon;
        private System.Windows.Forms.TextBox txtTipoPokemon;
        private System.Windows.Forms.TextBox txtNombrePokemon;
        private System.Windows.Forms.Button btnAgregarPokemon;
        private System.Windows.Forms.Button btnCurarPokemon;
        private System.Windows.Forms.TextBox txtDanio;
        private System.Windows.Forms.Label txtPokemonAtendido;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Button btnGuardarEnArchivo;
        private System.Windows.Forms.Button btnLeerDeArchivo;
    }
}