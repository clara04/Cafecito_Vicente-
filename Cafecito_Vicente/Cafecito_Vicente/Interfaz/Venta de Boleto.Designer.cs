namespace Cafecito_Vicente.Interfaz
{
    partial class Venta_de_Boleto
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
            this.LblBuscar = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.DtvMostrar = new System.Windows.Forms.DataGridView();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnImprimirBoleto = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LblSubTotal = new System.Windows.Forms.Label();
            this.LblIVA = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.TxtSubTotal = new System.Windows.Forms.TextBox();
            this.TxtIVA = new System.Windows.Forms.TextBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtvMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // LblBuscar
            // 
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Location = new System.Drawing.Point(13, 32);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(40, 13);
            this.LblBuscar.TabIndex = 0;
            this.LblBuscar.Text = "Buscar";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(77, 32);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(224, 20);
            this.TxtBuscar.TabIndex = 1;
            // 
            // DtvMostrar
            // 
            this.DtvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtvMostrar.Location = new System.Drawing.Point(77, 96);
            this.DtvMostrar.Name = "DtvMostrar";
            this.DtvMostrar.Size = new System.Drawing.Size(397, 201);
            this.DtvMostrar.TabIndex = 2;
            this.DtvMostrar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(526, 117);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(526, 166);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 23);
            this.BtnModificar.TabIndex = 4;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnImprimirBoleto
            // 
            this.BtnImprimirBoleto.Location = new System.Drawing.Point(526, 218);
            this.BtnImprimirBoleto.Name = "BtnImprimirBoleto";
            this.BtnImprimirBoleto.Size = new System.Drawing.Size(75, 23);
            this.BtnImprimirBoleto.TabIndex = 5;
            this.BtnImprimirBoleto.Text = "Imprimir Boleto";
            this.BtnImprimirBoleto.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(526, 263);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // LblSubTotal
            // 
            this.LblSubTotal.AutoSize = true;
            this.LblSubTotal.Location = new System.Drawing.Point(300, 312);
            this.LblSubTotal.Name = "LblSubTotal";
            this.LblSubTotal.Size = new System.Drawing.Size(53, 13);
            this.LblSubTotal.TabIndex = 7;
            this.LblSubTotal.Text = "SubTotal:";
            // 
            // LblIVA
            // 
            this.LblIVA.AutoSize = true;
            this.LblIVA.Location = new System.Drawing.Point(317, 346);
            this.LblIVA.Name = "LblIVA";
            this.LblIVA.Size = new System.Drawing.Size(27, 13);
            this.LblIVA.TabIndex = 8;
            this.LblIVA.Text = "IVA:";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(310, 375);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(34, 13);
            this.LblTotal.TabIndex = 9;
            this.LblTotal.Text = "Total:";
            // 
            // TxtSubTotal
            // 
            this.TxtSubTotal.Location = new System.Drawing.Point(374, 309);
            this.TxtSubTotal.Name = "TxtSubTotal";
            this.TxtSubTotal.Size = new System.Drawing.Size(100, 20);
            this.TxtSubTotal.TabIndex = 10;
            // 
            // TxtIVA
            // 
            this.TxtIVA.Location = new System.Drawing.Point(374, 343);
            this.TxtIVA.Name = "TxtIVA";
            this.TxtIVA.Size = new System.Drawing.Size(100, 20);
            this.TxtIVA.TabIndex = 11;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(374, 372);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(100, 20);
            this.TxtTotal.TabIndex = 12;
            // 
            // Venta_de_Boleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 399);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.TxtIVA);
            this.Controls.Add(this.TxtSubTotal);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LblIVA);
            this.Controls.Add(this.LblSubTotal);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnImprimirBoleto);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.DtvMostrar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.LblBuscar);
            this.Name = "Venta_de_Boleto";
            this.Text = "Venta_de_Boleto";
            this.Load += new System.EventHandler(this.Venta_de_Boleto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtvMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DataGridView DtvMostrar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnImprimirBoleto;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label LblSubTotal;
        private System.Windows.Forms.Label LblIVA;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.TextBox TxtSubTotal;
        private System.Windows.Forms.TextBox TxtIVA;
        private System.Windows.Forms.TextBox TxtTotal;
    }
}