namespace PokedexApp
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnCargarAdmin = new System.Windows.Forms.Button();
            this.btnCargarEntrenador = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picCentroPokemon = new System.Windows.Forms.PictureBox();
            this.picPokebola = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCentroPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPokebola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.SeaShell;
            this.txtUsuario.Location = new System.Drawing.Point(142, 164);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderText = "Ingrese usuario";
            this.txtUsuario.Size = new System.Drawing.Size(200, 27);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.Snow;
            this.txtClave.Location = new System.Drawing.Point(142, 388);
            this.txtClave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.PlaceholderText = "Ingrese contraseña";
            this.txtClave.Size = new System.Drawing.Size(200, 27);
            this.txtClave.TabIndex = 4;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Snow;
            this.btnIngresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIngresar.BackgroundImage")));
            this.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.ForeColor = System.Drawing.Color.Bisque;
            this.btnIngresar.Location = new System.Drawing.Point(168, 499);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(128, 64);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnCargarAdmin
            // 
            this.btnCargarAdmin.BackColor = System.Drawing.Color.LightCyan;
            this.btnCargarAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCargarAdmin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCargarAdmin.Location = new System.Drawing.Point(314, 485);
            this.btnCargarAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCargarAdmin.Name = "btnCargarAdmin";
            this.btnCargarAdmin.Size = new System.Drawing.Size(150, 35);
            this.btnCargarAdmin.TabIndex = 7;
            this.btnCargarAdmin.Text = "Soy administrador";
            this.btnCargarAdmin.UseVisualStyleBackColor = false;
            this.btnCargarAdmin.Click += new System.EventHandler(this.btnCargarAdmin_Click);
            // 
            // btnCargarEntrenador
            // 
            this.btnCargarEntrenador.BackColor = System.Drawing.Color.Linen;
            this.btnCargarEntrenador.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCargarEntrenador.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCargarEntrenador.Location = new System.Drawing.Point(314, 528);
            this.btnCargarEntrenador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCargarEntrenador.Name = "btnCargarEntrenador";
            this.btnCargarEntrenador.Size = new System.Drawing.Size(150, 35);
            this.btnCargarEntrenador.TabIndex = 8;
            this.btnCargarEntrenador.Text = "Soy entrenador";
            this.btnCargarEntrenador.UseVisualStyleBackColor = false;
            this.btnCargarEntrenador.Click += new System.EventHandler(this.btnCargarEntrenador_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Maroon;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(9, 488);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 75);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-26, -23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(11, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(11, 0);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // picCentroPokemon
            // 
            this.picCentroPokemon.Image = ((System.Drawing.Image)(resources.GetObject("picCentroPokemon.Image")));
            this.picCentroPokemon.Location = new System.Drawing.Point(-49, 3);
            this.picCentroPokemon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picCentroPokemon.Name = "picCentroPokemon";
            this.picCentroPokemon.Size = new System.Drawing.Size(559, 87);
            this.picCentroPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCentroPokemon.TabIndex = 13;
            this.picCentroPokemon.TabStop = false;
            // 
            // picPokebola
            // 
            this.picPokebola.BackColor = System.Drawing.Color.Transparent;
            this.picPokebola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picPokebola.Image = ((System.Drawing.Image)(resources.GetObject("picPokebola.Image")));
            this.picPokebola.Location = new System.Drawing.Point(217, 377);
            this.picPokebola.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picPokebola.Name = "picPokebola";
            this.picPokebola.Size = new System.Drawing.Size(58, 65);
            this.picPokebola.TabIndex = 11;
            this.picPokebola.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(217, 153);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 65);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(482, 579);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picCentroPokemon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCargarEntrenador);
            this.Controls.Add(this.btnCargarAdmin);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.picPokebola);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centro Pokemon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCentroPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPokebola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnCargarAdmin;
        private System.Windows.Forms.Button btnCargarEntrenador;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picCentroPokemon;
        private System.Windows.Forms.PictureBox picPokebola;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
