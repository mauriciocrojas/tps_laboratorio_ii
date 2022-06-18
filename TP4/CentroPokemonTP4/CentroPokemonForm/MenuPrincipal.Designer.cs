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
            this.btnLeerDeArchivoXml = new System.Windows.Forms.Button();
            this.btnGuardarEnArchivoXml = new System.Windows.Forms.Button();
            this.btnLeerDeArchivoJson = new System.Windows.Forms.Button();
            this.btnGuardarEnArchivoJson = new System.Windows.Forms.Button();
            this.btnGuardarEnArchivoTxt = new System.Windows.Forms.Button();
            this.btnLeerDeArchivoTxt = new System.Windows.Forms.Button();
            this.grpGuardarArchivo = new System.Windows.Forms.GroupBox();
            this.grpLeerArchivo = new System.Windows.Forms.GroupBox();
            this.grpAgregarPokemon.SuspendLayout();
            this.grpGuardarArchivo.SuspendLayout();
            this.grpLeerArchivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerEntrenadores
            // 
            this.btnVerEntrenadores.Location = new System.Drawing.Point(14, 533);
            this.btnVerEntrenadores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVerEntrenadores.Name = "btnVerEntrenadores";
            this.btnVerEntrenadores.Size = new System.Drawing.Size(117, 80);
            this.btnVerEntrenadores.TabIndex = 23;
            this.btnVerEntrenadores.Text = "Ver entrenadores registrados";
            this.btnVerEntrenadores.UseVisualStyleBackColor = true;
            this.btnVerEntrenadores.Click += new System.EventHandler(this.btnVerEntrenadores_Click);
            // 
            // btnUsuarioLogeado
            // 
            this.btnUsuarioLogeado.Location = new System.Drawing.Point(153, 533);
            this.btnUsuarioLogeado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUsuarioLogeado.Name = "btnUsuarioLogeado";
            this.btnUsuarioLogeado.Size = new System.Drawing.Size(117, 80);
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
            this.btnSalir.Location = new System.Drawing.Point(524, 543);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 66);
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
            this.btnVolver.Location = new System.Drawing.Point(414, 543);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(104, 66);
            this.btnVolver.TabIndex = 26;
            this.btnVolver.Text = "Volver Atrás";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lstPokemon
            // 
            this.lstPokemon.FormattingEnabled = true;
            this.lstPokemon.ItemHeight = 20;
            this.lstPokemon.Location = new System.Drawing.Point(14, 41);
            this.lstPokemon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstPokemon.Name = "lstPokemon";
            this.lstPokemon.Size = new System.Drawing.Size(182, 224);
            this.lstPokemon.TabIndex = 27;
            this.lstPokemon.SelectedIndexChanged += new System.EventHandler(this.lstPokemon_SelectedIndexChanged);
            // 
            // rchPokemon
            // 
            this.rchPokemon.Location = new System.Drawing.Point(338, 41);
            this.rchPokemon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rchPokemon.Name = "rchPokemon";
            this.rchPokemon.ReadOnly = true;
            this.rchPokemon.Size = new System.Drawing.Size(290, 224);
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
            this.grpAgregarPokemon.Location = new System.Drawing.Point(24, 282);
            this.grpAgregarPokemon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpAgregarPokemon.Name = "grpAgregarPokemon";
            this.grpAgregarPokemon.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpAgregarPokemon.Size = new System.Drawing.Size(604, 99);
            this.grpAgregarPokemon.TabIndex = 29;
            this.grpAgregarPokemon.TabStop = false;
            this.grpAgregarPokemon.Text = "Agregar Pokemon";
            // 
            // txtDanio
            // 
            this.txtDanio.Location = new System.Drawing.Point(406, 42);
            this.txtDanio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDanio.Name = "txtDanio";
            this.txtDanio.PlaceholderText = "Daño %";
            this.txtDanio.Size = new System.Drawing.Size(65, 27);
            this.txtDanio.TabIndex = 4;
            this.txtDanio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDanio_KeyPress);
            // 
            // btnAgregarPokemon
            // 
            this.btnAgregarPokemon.Location = new System.Drawing.Point(488, 30);
            this.btnAgregarPokemon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarPokemon.Name = "btnAgregarPokemon";
            this.btnAgregarPokemon.Size = new System.Drawing.Size(95, 50);
            this.btnAgregarPokemon.TabIndex = 5;
            this.btnAgregarPokemon.Text = "Agregar";
            this.btnAgregarPokemon.UseVisualStyleBackColor = true;
            this.btnAgregarPokemon.Click += new System.EventHandler(this.btnAgregarPokemonManual_Click);
            // 
            // txtAtaquePokemon
            // 
            this.txtAtaquePokemon.Location = new System.Drawing.Point(271, 42);
            this.txtAtaquePokemon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAtaquePokemon.Name = "txtAtaquePokemon";
            this.txtAtaquePokemon.PlaceholderText = "Ataque principal";
            this.txtAtaquePokemon.Size = new System.Drawing.Size(129, 27);
            this.txtAtaquePokemon.TabIndex = 3;
            this.txtAtaquePokemon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAtaquePokemon_KeyPress);
            // 
            // txtIDPokemon
            // 
            this.txtIDPokemon.Location = new System.Drawing.Point(225, 42);
            this.txtIDPokemon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDPokemon.Name = "txtIDPokemon";
            this.txtIDPokemon.PlaceholderText = "ID";
            this.txtIDPokemon.Size = new System.Drawing.Size(40, 27);
            this.txtIDPokemon.TabIndex = 2;
            this.txtIDPokemon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDPokemon_KeyPress);
            // 
            // txtTipoPokemon
            // 
            this.txtTipoPokemon.Location = new System.Drawing.Point(122, 42);
            this.txtTipoPokemon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTipoPokemon.Name = "txtTipoPokemon";
            this.txtTipoPokemon.PlaceholderText = "Tipo";
            this.txtTipoPokemon.Size = new System.Drawing.Size(95, 27);
            this.txtTipoPokemon.TabIndex = 1;
            this.txtTipoPokemon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipoPokemon_KeyPress);
            // 
            // txtNombrePokemon
            // 
            this.txtNombrePokemon.Location = new System.Drawing.Point(14, 42);
            this.txtNombrePokemon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombrePokemon.Name = "txtNombrePokemon";
            this.txtNombrePokemon.PlaceholderText = "Nombre";
            this.txtNombrePokemon.Size = new System.Drawing.Size(95, 27);
            this.txtNombrePokemon.TabIndex = 0;
            this.txtNombrePokemon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombrePokemon_KeyPress);
            // 
            // chkHabAgrPok
            // 
            this.chkHabAgrPok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chkHabAgrPok.AutoSize = true;
            this.chkHabAgrPok.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkHabAgrPok.Location = new System.Drawing.Point(14, 282);
            this.chkHabAgrPok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkHabAgrPok.Name = "chkHabAgrPok";
            this.chkHabAgrPok.Size = new System.Drawing.Size(18, 17);
            this.chkHabAgrPok.TabIndex = 30;
            this.chkHabAgrPok.UseVisualStyleBackColor = true;
            this.chkHabAgrPok.CheckedChanged += new System.EventHandler(this.chkHabAgrPok_CheckedChanged);
            // 
            // btnCurarPokemon
            // 
            this.btnCurarPokemon.Location = new System.Drawing.Point(214, 50);
            this.btnCurarPokemon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCurarPokemon.Name = "btnCurarPokemon";
            this.btnCurarPokemon.Size = new System.Drawing.Size(107, 51);
            this.btnCurarPokemon.TabIndex = 31;
            this.btnCurarPokemon.Text = "Curar pokemon";
            this.btnCurarPokemon.UseVisualStyleBackColor = true;
            this.btnCurarPokemon.Click += new System.EventHandler(this.btnCurarPokemon_Click);
            // 
            // txtPokemonAtendido
            // 
            this.txtPokemonAtendido.AutoSize = true;
            this.txtPokemonAtendido.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.txtPokemonAtendido.Location = new System.Drawing.Point(13, 15);
            this.txtPokemonAtendido.Name = "txtPokemonAtendido";
            this.txtPokemonAtendido.Size = new System.Drawing.Size(181, 23);
            this.txtPokemonAtendido.TabIndex = 32;
            this.txtPokemonAtendido.Text = "Pokemon en atención:";
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblDetalle.Location = new System.Drawing.Point(338, 15);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(67, 23);
            this.lblDetalle.TabIndex = 33;
            this.lblDetalle.Text = "Detalle:";
            // 
            // btnLeerDeArchivoXml
            // 
            this.btnLeerDeArchivoXml.Location = new System.Drawing.Point(89, 26);
            this.btnLeerDeArchivoXml.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLeerDeArchivoXml.Name = "btnLeerDeArchivoXml";
            this.btnLeerDeArchivoXml.Size = new System.Drawing.Size(48, 34);
            this.btnLeerDeArchivoXml.TabIndex = 37;
            this.btnLeerDeArchivoXml.Text = "Xml";
            this.btnLeerDeArchivoXml.UseVisualStyleBackColor = true;
            this.btnLeerDeArchivoXml.Click += new System.EventHandler(this.btnLeerDeArchivoXml_Click);
            // 
            // btnGuardarEnArchivoXml
            // 
            this.btnGuardarEnArchivoXml.Location = new System.Drawing.Point(79, 27);
            this.btnGuardarEnArchivoXml.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardarEnArchivoXml.Name = "btnGuardarEnArchivoXml";
            this.btnGuardarEnArchivoXml.Size = new System.Drawing.Size(48, 34);
            this.btnGuardarEnArchivoXml.TabIndex = 36;
            this.btnGuardarEnArchivoXml.Text = "Xml";
            this.btnGuardarEnArchivoXml.UseVisualStyleBackColor = true;
            this.btnGuardarEnArchivoXml.Click += new System.EventHandler(this.btnGuardarEnArchivoXml_Click);
            // 
            // btnLeerDeArchivoJson
            // 
            this.btnLeerDeArchivoJson.Location = new System.Drawing.Point(143, 26);
            this.btnLeerDeArchivoJson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLeerDeArchivoJson.Name = "btnLeerDeArchivoJson";
            this.btnLeerDeArchivoJson.Size = new System.Drawing.Size(48, 34);
            this.btnLeerDeArchivoJson.TabIndex = 39;
            this.btnLeerDeArchivoJson.Text = "Json";
            this.btnLeerDeArchivoJson.UseVisualStyleBackColor = true;
            this.btnLeerDeArchivoJson.Click += new System.EventHandler(this.btnLeerDeArchivoJson_Click);
            // 
            // btnGuardarEnArchivoJson
            // 
            this.btnGuardarEnArchivoJson.Location = new System.Drawing.Point(133, 27);
            this.btnGuardarEnArchivoJson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardarEnArchivoJson.Name = "btnGuardarEnArchivoJson";
            this.btnGuardarEnArchivoJson.Size = new System.Drawing.Size(48, 34);
            this.btnGuardarEnArchivoJson.TabIndex = 38;
            this.btnGuardarEnArchivoJson.Text = "Json";
            this.btnGuardarEnArchivoJson.UseVisualStyleBackColor = true;
            this.btnGuardarEnArchivoJson.Click += new System.EventHandler(this.btnGuardarEnArchivoJson_Click);
            // 
            // btnGuardarEnArchivoTxt
            // 
            this.btnGuardarEnArchivoTxt.Location = new System.Drawing.Point(25, 27);
            this.btnGuardarEnArchivoTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardarEnArchivoTxt.Name = "btnGuardarEnArchivoTxt";
            this.btnGuardarEnArchivoTxt.Size = new System.Drawing.Size(48, 34);
            this.btnGuardarEnArchivoTxt.TabIndex = 34;
            this.btnGuardarEnArchivoTxt.Text = "Txt";
            this.btnGuardarEnArchivoTxt.UseVisualStyleBackColor = true;
            this.btnGuardarEnArchivoTxt.Click += new System.EventHandler(this.btnGuardarEnArchivoTxt_Click);
            // 
            // btnLeerDeArchivoTxt
            // 
            this.btnLeerDeArchivoTxt.Location = new System.Drawing.Point(35, 26);
            this.btnLeerDeArchivoTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLeerDeArchivoTxt.Name = "btnLeerDeArchivoTxt";
            this.btnLeerDeArchivoTxt.Size = new System.Drawing.Size(48, 34);
            this.btnLeerDeArchivoTxt.TabIndex = 35;
            this.btnLeerDeArchivoTxt.Text = "Txt";
            this.btnLeerDeArchivoTxt.UseVisualStyleBackColor = true;
            this.btnLeerDeArchivoTxt.Click += new System.EventHandler(this.btnLeerDeArchivoTxt_Click);
            // 
            // grpGuardarArchivo
            // 
            this.grpGuardarArchivo.Controls.Add(this.btnGuardarEnArchivoTxt);
            this.grpGuardarArchivo.Controls.Add(this.btnGuardarEnArchivoXml);
            this.grpGuardarArchivo.Controls.Add(this.btnGuardarEnArchivoJson);
            this.grpGuardarArchivo.Location = new System.Drawing.Point(20, 389);
            this.grpGuardarArchivo.Name = "grpGuardarArchivo";
            this.grpGuardarArchivo.Size = new System.Drawing.Size(221, 74);
            this.grpGuardarArchivo.TabIndex = 42;
            this.grpGuardarArchivo.TabStop = false;
            this.grpGuardarArchivo.Text = "Guardar listado en formato:";
            // 
            // grpLeerArchivo
            // 
            this.grpLeerArchivo.Controls.Add(this.btnLeerDeArchivoXml);
            this.grpLeerArchivo.Controls.Add(this.btnLeerDeArchivoTxt);
            this.grpLeerArchivo.Controls.Add(this.btnLeerDeArchivoJson);
            this.grpLeerArchivo.Location = new System.Drawing.Point(261, 389);
            this.grpLeerArchivo.Name = "grpLeerArchivo";
            this.grpLeerArchivo.Size = new System.Drawing.Size(221, 74);
            this.grpLeerArchivo.TabIndex = 43;
            this.grpLeerArchivo.TabStop = false;
            this.grpLeerArchivo.Text = "Leer listado en formato:";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(644, 622);
            this.Controls.Add(this.grpLeerArchivo);
            this.Controls.Add(this.grpGuardarArchivo);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centro Pokemon Menú";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.grpAgregarPokemon.ResumeLayout(false);
            this.grpAgregarPokemon.PerformLayout();
            this.grpGuardarArchivo.ResumeLayout(false);
            this.grpLeerArchivo.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnLeerDeArchivoXml;
        private System.Windows.Forms.Button btnGuardarEnArchivoXml;
        private System.Windows.Forms.Button btnLeerDeArchivoJson;
        private System.Windows.Forms.Button btnGuardarEnArchivoJson;
        private System.Windows.Forms.Button btnGuardarEnArchivoTxt;
        private System.Windows.Forms.Button btnLeerDeArchivoTxt;
        private System.Windows.Forms.GroupBox grpGuardarArchivo;
        private System.Windows.Forms.GroupBox grpLeerArchivo;
    }
}