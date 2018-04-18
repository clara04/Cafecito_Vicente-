namespace Cafecito_Vicente.Interfaz
{
    partial class Frmlogin
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
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblContraseña = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.LblIngreseDatos = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTNcancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(30, 64);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(46, 13);
            this.LblUsuario.TabIndex = 0;
            this.LblUsuario.Text = "Usuario:";
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.Location = new System.Drawing.Point(30, 97);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(64, 13);
            this.LblContraseña.TabIndex = 1;
            this.LblContraseña.Text = "Contraseña:";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(141, 61);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(100, 20);
            this.TxtUsuario.TabIndex = 2;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Location = new System.Drawing.Point(141, 94);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.PasswordChar = '*';
            this.TxtContraseña.Size = new System.Drawing.Size(100, 20);
            this.TxtContraseña.TabIndex = 3;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(89, 175);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(75, 23);
            this.BtnIngresar.TabIndex = 4;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // LblIngreseDatos
            // 
            this.LblIngreseDatos.AutoSize = true;
            this.LblIngreseDatos.Location = new System.Drawing.Point(138, 18);
            this.LblIngreseDatos.Name = "LblIngreseDatos";
            this.LblIngreseDatos.Size = new System.Drawing.Size(73, 13);
            this.LblIngreseDatos.TabIndex = 5;
            this.LblIngreseDatos.Text = "Ingrese Datos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cafecito_Vicente.Properties.Resources.descarga;
            this.pictureBox1.Location = new System.Drawing.Point(272, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // BTNcancelar
            // 
            this.BTNcancelar.Location = new System.Drawing.Point(219, 175);
            this.BTNcancelar.Name = "BTNcancelar";
            this.BTNcancelar.Size = new System.Drawing.Size(75, 23);
            this.BTNcancelar.TabIndex = 7;
            this.BTNcancelar.Text = "Cancelar";
            this.BTNcancelar.UseVisualStyleBackColor = true;
            this.BTNcancelar.Click += new System.EventHandler(this.BTNcancelar_Click);
            // 
            // Frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 225);
            this.Controls.Add(this.BTNcancelar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblIngreseDatos);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.LblContraseña);
            this.Controls.Add(this.LblUsuario);
            this.Name = "Frmlogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblContraseña;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label LblIngreseDatos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTNcancelar;
    }
}