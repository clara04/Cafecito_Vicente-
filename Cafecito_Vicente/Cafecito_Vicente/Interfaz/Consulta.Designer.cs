namespace Cafecito_Vicente.Interfaz
{
    partial class Frmconsulta
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
            this.Btnbuscar = new System.Windows.Forms.Button();
            this.Btngenerar = new System.Windows.Forms.Button();
            this.Btnsalir = new System.Windows.Forms.Button();
            this.Btnimprimir = new System.Windows.Forms.Button();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.Tbuscar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Tbuscar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btnbuscar
            // 
            this.Btnbuscar.Location = new System.Drawing.Point(165, 34);
            this.Btnbuscar.Name = "Btnbuscar";
            this.Btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.Btnbuscar.TabIndex = 0;
            this.Btnbuscar.Text = "Buscar";
            this.Btnbuscar.UseVisualStyleBackColor = true;
            this.Btnbuscar.Click += new System.EventHandler(this.Btnbuscar_Click);
            // 
            // Btngenerar
            // 
            this.Btngenerar.Location = new System.Drawing.Point(475, 61);
            this.Btngenerar.Name = "Btngenerar";
            this.Btngenerar.Size = new System.Drawing.Size(96, 28);
            this.Btngenerar.TabIndex = 1;
            this.Btngenerar.Text = "Generar Reporte";
            this.Btngenerar.UseVisualStyleBackColor = true;
            this.Btngenerar.Click += new System.EventHandler(this.Btngenerar_Click);
            // 
            // Btnsalir
            // 
            this.Btnsalir.Location = new System.Drawing.Point(474, 160);
            this.Btnsalir.Name = "Btnsalir";
            this.Btnsalir.Size = new System.Drawing.Size(97, 25);
            this.Btnsalir.TabIndex = 2;
            this.Btnsalir.Text = "Salir";
            this.Btnsalir.UseVisualStyleBackColor = true;
            this.Btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // Btnimprimir
            // 
            this.Btnimprimir.Location = new System.Drawing.Point(474, 108);
            this.Btnimprimir.Name = "Btnimprimir";
            this.Btnimprimir.Size = new System.Drawing.Size(91, 27);
            this.Btnimprimir.TabIndex = 3;
            this.Btnimprimir.Text = "Imprimir";
            this.Btnimprimir.UseVisualStyleBackColor = true;
            this.Btnimprimir.Click += new System.EventHandler(this.Btnimprimir_Click);
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(50, 36);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(88, 20);
            this.Txtid.TabIndex = 4;
            // 
            // Tbuscar
            // 
            this.Tbuscar.AllowUserToAddRows = false;
            this.Tbuscar.AllowUserToDeleteRows = false;
            this.Tbuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tbuscar.Location = new System.Drawing.Point(28, 91);
            this.Tbuscar.Name = "Tbuscar";
            this.Tbuscar.ReadOnly = true;
            this.Tbuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tbuscar.Size = new System.Drawing.Size(372, 163);
            this.Tbuscar.TabIndex = 5;
            this.Tbuscar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Tbuscar_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Tbuscar);
            this.groupBox1.Controls.Add(this.Btnsalir);
            this.groupBox1.Controls.Add(this.Btnimprimir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Txtid);
            this.groupBox1.Controls.Add(this.Btngenerar);
            this.groupBox1.Controls.Add(this.Btnbuscar);
            this.groupBox1.Location = new System.Drawing.Point(23, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 271);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por Corrida";
            // 
            // Frmconsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 320);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frmconsulta";
            this.Text = "Consulta";
            this.Activated += new System.EventHandler(this.Frmconsulta_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.Tbuscar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btnbuscar;
        private System.Windows.Forms.Button Btngenerar;
        private System.Windows.Forms.Button Btnsalir;
        private System.Windows.Forms.Button Btnimprimir;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.DataGridView Tbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}