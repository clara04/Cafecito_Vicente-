namespace Cafecito_Vicente.Interfaz
{
    partial class Frmboleto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.Txtpecio = new System.Windows.Forms.TextBox();
            this.Txttipo = new System.Windows.Forms.TextBox();
            this.Tboleto = new System.Windows.Forms.DataGridView();
            this.Btnagregar = new System.Windows.Forms.Button();
            this.Btneliminar = new System.Windows.Forms.Button();
            this.Btnmodificar = new System.Windows.Forms.Button();
            this.Btnsiguiente = new System.Windows.Forms.Button();
            this.Btnatras = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tboleto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Txttipo);
            this.panel1.Controls.Add(this.Txtpecio);
            this.panel1.Controls.Add(this.Txtid);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 127);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id_boleto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo:";
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(72, 16);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(91, 20);
            this.Txtid.TabIndex = 3;
            // 
            // Txtpecio
            // 
            this.Txtpecio.Location = new System.Drawing.Point(72, 39);
            this.Txtpecio.Name = "Txtpecio";
            this.Txtpecio.Size = new System.Drawing.Size(91, 20);
            this.Txtpecio.TabIndex = 4;
            // 
            // Txttipo
            // 
            this.Txttipo.Location = new System.Drawing.Point(72, 65);
            this.Txttipo.Name = "Txttipo";
            this.Txttipo.Size = new System.Drawing.Size(91, 20);
            this.Txttipo.TabIndex = 5;
            // 
            // Tboleto
            // 
            this.Tboleto.AllowUserToAddRows = false;
            this.Tboleto.AllowUserToDeleteRows = false;
            this.Tboleto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tboleto.Location = new System.Drawing.Point(12, 166);
            this.Tboleto.Name = "Tboleto";
            this.Tboleto.ReadOnly = true;
            this.Tboleto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tboleto.Size = new System.Drawing.Size(322, 150);
            this.Tboleto.TabIndex = 1;
            this.Tboleto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Tboleto_MouseClick);
            // 
            // Btnagregar
            // 
            this.Btnagregar.Location = new System.Drawing.Point(384, 54);
            this.Btnagregar.Name = "Btnagregar";
            this.Btnagregar.Size = new System.Drawing.Size(75, 23);
            this.Btnagregar.TabIndex = 2;
            this.Btnagregar.Text = "Agregar";
            this.Btnagregar.UseVisualStyleBackColor = true;
            this.Btnagregar.Click += new System.EventHandler(this.Btnagregar_Click);
            // 
            // Btneliminar
            // 
            this.Btneliminar.Location = new System.Drawing.Point(481, 54);
            this.Btneliminar.Name = "Btneliminar";
            this.Btneliminar.Size = new System.Drawing.Size(75, 23);
            this.Btneliminar.TabIndex = 3;
            this.Btneliminar.Text = "Eliminar";
            this.Btneliminar.UseVisualStyleBackColor = true;
            this.Btneliminar.Click += new System.EventHandler(this.Btneliminar_Click);
            // 
            // Btnmodificar
            // 
            this.Btnmodificar.Location = new System.Drawing.Point(384, 109);
            this.Btnmodificar.Name = "Btnmodificar";
            this.Btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.Btnmodificar.TabIndex = 4;
            this.Btnmodificar.Text = "Modificar";
            this.Btnmodificar.UseVisualStyleBackColor = true;
            this.Btnmodificar.Click += new System.EventHandler(this.Btnmodificar_Click);
            // 
            // Btnsiguiente
            // 
            this.Btnsiguiente.Location = new System.Drawing.Point(481, 109);
            this.Btnsiguiente.Name = "Btnsiguiente";
            this.Btnsiguiente.Size = new System.Drawing.Size(75, 23);
            this.Btnsiguiente.TabIndex = 5;
            this.Btnsiguiente.Text = "Siguiente";
            this.Btnsiguiente.UseVisualStyleBackColor = true;
            this.Btnsiguiente.Click += new System.EventHandler(this.Btnsiguiente_Click);
            // 
            // Btnatras
            // 
            this.Btnatras.Location = new System.Drawing.Point(435, 166);
            this.Btnatras.Name = "Btnatras";
            this.Btnatras.Size = new System.Drawing.Size(75, 23);
            this.Btnatras.TabIndex = 6;
            this.Btnatras.Text = "Atras";
            this.Btnatras.UseVisualStyleBackColor = true;
            this.Btnatras.Click += new System.EventHandler(this.Btnatras_Click);
            // 
            // Frmboleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 337);
            this.Controls.Add(this.Btnatras);
            this.Controls.Add(this.Btnsiguiente);
            this.Controls.Add(this.Btnmodificar);
            this.Controls.Add(this.Btneliminar);
            this.Controls.Add(this.Btnagregar);
            this.Controls.Add(this.Tboleto);
            this.Controls.Add(this.panel1);
            this.Name = "Frmboleto";
            this.Text = "Boleto";
            this.Activated += new System.EventHandler(this.Frmboleto_Activated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tboleto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txttipo;
        private System.Windows.Forms.TextBox Txtpecio;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Tboleto;
        private System.Windows.Forms.Button Btnagregar;
        private System.Windows.Forms.Button Btneliminar;
        private System.Windows.Forms.Button Btnmodificar;
        private System.Windows.Forms.Button Btnsiguiente;
        private System.Windows.Forms.Button Btnatras;
    }
}