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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.Txtprecio = new System.Windows.Forms.TextBox();
            this.Txttipo = new System.Windows.Forms.TextBox();
            this.Tboleto = new System.Windows.Forms.DataGridView();
            this.Btnagregar = new System.Windows.Forms.Button();
            this.Btneliminar = new System.Windows.Forms.Button();
            this.Btnsiguiente = new System.Windows.Forms.Button();
            this.Btnactualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tboleto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id_Boleto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo:";
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(93, 33);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(144, 20);
            this.Txtid.TabIndex = 5;
            // 
            // Txtprecio
            // 
            this.Txtprecio.Location = new System.Drawing.Point(93, 98);
            this.Txtprecio.Name = "Txtprecio";
            this.Txtprecio.Size = new System.Drawing.Size(144, 20);
            this.Txtprecio.TabIndex = 6;
            // 
            // Txttipo
            // 
            this.Txttipo.Location = new System.Drawing.Point(93, 67);
            this.Txttipo.Name = "Txttipo";
            this.Txttipo.Size = new System.Drawing.Size(144, 20);
            this.Txttipo.TabIndex = 7;
            // 
            // Tboleto
            // 
            this.Tboleto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tboleto.Location = new System.Drawing.Point(23, 143);
            this.Tboleto.Name = "Tboleto";
            this.Tboleto.Size = new System.Drawing.Size(293, 150);
            this.Tboleto.TabIndex = 8;
            this.Tboleto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Tboleto_MouseClick);
            // 
            // Btnagregar
            // 
            this.Btnagregar.Location = new System.Drawing.Point(342, 70);
            this.Btnagregar.Name = "Btnagregar";
            this.Btnagregar.Size = new System.Drawing.Size(75, 23);
            this.Btnagregar.TabIndex = 9;
            this.Btnagregar.Text = "Agregar";
            this.Btnagregar.UseVisualStyleBackColor = true;
            this.Btnagregar.Click += new System.EventHandler(this.Btnagregar_Click);
            // 
            // Btneliminar
            // 
            this.Btneliminar.Location = new System.Drawing.Point(452, 70);
            this.Btneliminar.Name = "Btneliminar";
            this.Btneliminar.Size = new System.Drawing.Size(75, 23);
            this.Btneliminar.TabIndex = 10;
            this.Btneliminar.Text = "Eliminar";
            this.Btneliminar.UseVisualStyleBackColor = true;
            this.Btneliminar.Click += new System.EventHandler(this.Btneliminar_Click);
            // 
            // Btnsiguiente
            // 
            this.Btnsiguiente.Location = new System.Drawing.Point(452, 127);
            this.Btnsiguiente.Name = "Btnsiguiente";
            this.Btnsiguiente.Size = new System.Drawing.Size(75, 23);
            this.Btnsiguiente.TabIndex = 11;
            this.Btnsiguiente.Text = "Siguiente";
            this.Btnsiguiente.UseVisualStyleBackColor = true;
            this.Btnsiguiente.Click += new System.EventHandler(this.Btnsiguiente_Click);
            // 
            // Btnactualizar
            // 
            this.Btnactualizar.Location = new System.Drawing.Point(342, 128);
            this.Btnactualizar.Name = "Btnactualizar";
            this.Btnactualizar.Size = new System.Drawing.Size(87, 21);
            this.Btnactualizar.TabIndex = 12;
            this.Btnactualizar.Text = "Actualizar";
            this.Btnactualizar.UseVisualStyleBackColor = true;
            // 
            // Frmboleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 305);
            this.Controls.Add(this.Btnactualizar);
            this.Controls.Add(this.Btnsiguiente);
            this.Controls.Add(this.Btneliminar);
            this.Controls.Add(this.Btnagregar);
            this.Controls.Add(this.Tboleto);
            this.Controls.Add(this.Txttipo);
            this.Controls.Add(this.Txtprecio);
            this.Controls.Add(this.Txtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Frmboleto";
            this.Text = "Boleto";
            this.Activated += new System.EventHandler(this.Frmboleto_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.Tboleto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.TextBox Txtprecio;
        private System.Windows.Forms.TextBox Txttipo;
        private System.Windows.Forms.DataGridView Tboleto;
        private System.Windows.Forms.Button Btnagregar;
        private System.Windows.Forms.Button Btneliminar;
        private System.Windows.Forms.Button Btnsiguiente;
        private System.Windows.Forms.Button Btnactualizar;
    }
}