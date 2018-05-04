namespace Cafecito_Vicente.Interfaz
{
    partial class Frmpasajero
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
            this.Tpasajero = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btnsiguiente = new System.Windows.Forms.Button();
            this.Btnactualizar = new System.Windows.Forms.Button();
            this.Btneliminar = new System.Windows.Forms.Button();
            this.Btnagregar = new System.Windows.Forms.Button();
            this.Txtasiento = new System.Windows.Forms.TextBox();
            this.Txtapellido = new System.Windows.Forms.TextBox();
            this.Txtnombre = new System.Windows.Forms.TextBox();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Btnatras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tpasajero)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tpasajero
            // 
            this.Tpasajero.AllowUserToAddRows = false;
            this.Tpasajero.AllowUserToDeleteRows = false;
            this.Tpasajero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tpasajero.Location = new System.Drawing.Point(22, 83);
            this.Tpasajero.Name = "Tpasajero";
            this.Tpasajero.ReadOnly = true;
            this.Tpasajero.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tpasajero.Size = new System.Drawing.Size(441, 182);
            this.Tpasajero.TabIndex = 0;
            this.Tpasajero.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tpasajero_CellContentClick);
            this.Tpasajero.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Tpasajero_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btnatras);
            this.groupBox1.Controls.Add(this.Btnsiguiente);
            this.groupBox1.Controls.Add(this.Btnactualizar);
            this.groupBox1.Controls.Add(this.Btneliminar);
            this.groupBox1.Controls.Add(this.Btnagregar);
            this.groupBox1.Controls.Add(this.Txtasiento);
            this.groupBox1.Controls.Add(this.Txtapellido);
            this.groupBox1.Controls.Add(this.Txtnombre);
            this.groupBox1.Controls.Add(this.Txtid);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 184);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pasajero";
            // 
            // Btnsiguiente
            // 
            this.Btnsiguiente.Location = new System.Drawing.Point(366, 78);
            this.Btnsiguiente.Name = "Btnsiguiente";
            this.Btnsiguiente.Size = new System.Drawing.Size(75, 23);
            this.Btnsiguiente.TabIndex = 11;
            this.Btnsiguiente.Text = "Siguiente";
            this.Btnsiguiente.UseVisualStyleBackColor = true;
            this.Btnsiguiente.Click += new System.EventHandler(this.Btnsiguiente_Click);
            // 
            // Btnactualizar
            // 
            this.Btnactualizar.Location = new System.Drawing.Point(267, 78);
            this.Btnactualizar.Name = "Btnactualizar";
            this.Btnactualizar.Size = new System.Drawing.Size(75, 23);
            this.Btnactualizar.TabIndex = 10;
            this.Btnactualizar.Text = "Actualizar";
            this.Btnactualizar.UseVisualStyleBackColor = true;
            this.Btnactualizar.Click += new System.EventHandler(this.Btnactualizar_Click);
            // 
            // Btneliminar
            // 
            this.Btneliminar.Location = new System.Drawing.Point(366, 34);
            this.Btneliminar.Name = "Btneliminar";
            this.Btneliminar.Size = new System.Drawing.Size(75, 23);
            this.Btneliminar.TabIndex = 9;
            this.Btneliminar.Text = "Eliminar";
            this.Btneliminar.UseVisualStyleBackColor = true;
            this.Btneliminar.Click += new System.EventHandler(this.Btneliminar_Click);
            // 
            // Btnagregar
            // 
            this.Btnagregar.Location = new System.Drawing.Point(267, 34);
            this.Btnagregar.Name = "Btnagregar";
            this.Btnagregar.Size = new System.Drawing.Size(75, 23);
            this.Btnagregar.TabIndex = 0;
            this.Btnagregar.Text = "Agregar";
            this.Btnagregar.UseVisualStyleBackColor = true;
            this.Btnagregar.Click += new System.EventHandler(this.Btnagregar_Click);
            // 
            // Txtasiento
            // 
            this.Txtasiento.Location = new System.Drawing.Point(74, 120);
            this.Txtasiento.Name = "Txtasiento";
            this.Txtasiento.Size = new System.Drawing.Size(94, 20);
            this.Txtasiento.TabIndex = 8;
            // 
            // Txtapellido
            // 
            this.Txtapellido.Location = new System.Drawing.Point(74, 89);
            this.Txtapellido.Multiline = true;
            this.Txtapellido.Name = "Txtapellido";
            this.Txtapellido.Size = new System.Drawing.Size(142, 20);
            this.Txtapellido.TabIndex = 7;
            // 
            // Txtnombre
            // 
            this.Txtnombre.Location = new System.Drawing.Point(74, 61);
            this.Txtnombre.Multiline = true;
            this.Txtnombre.Name = "Txtnombre";
            this.Txtnombre.Size = new System.Drawing.Size(142, 20);
            this.Txtnombre.TabIndex = 6;
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(74, 34);
            this.Txtid.Multiline = true;
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(74, 20);
            this.Txtid.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Asiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(188, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "LISTA DE PASAJEROS.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkedListBox1);
            this.groupBox2.Location = new System.Drawing.Point(519, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 198);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ASIENTOS";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Asiento 1",
            "Asiento 2",
            "Asiento 3",
            "Asiento 4",
            "Asiento 5",
            "Asiento 6",
            "Asiento 7",
            "Asiento 8",
            "Asiento 9",
            "Asiento 10",
            "Asiento 11",
            "Asiento 12",
            "Asiento 13",
            "Asiento 14",
            "Asiento 15",
            "Asiento 16",
            "Asiento 17",
            "Asiento 18",
            "Asiento 19",
            "Asiento 20",
            "Asiento 21",
            "Asiento 22",
            "Asiento 23",
            "Asiento 24",
            "Asiento 25",
            "Asiento 26",
            "Asiento 27",
            "Asiento 28",
            "Asiento 29",
            "Asiento 30",
            "Asiento 31",
            "Asiento 32",
            "Asiento 33",
            "Asiento 34",
            "Asiento 35",
            "Asiento 36",
            "Asiento 37",
            "Asiento 38",
            "Asiento 39",
            "Asiento 40",
            "Asiento 41",
            "Asiento 42",
            "Asiento 43",
            "Asiento 44",
            "Asiento 45",
            "Asiento 46",
            "Asiento 47",
            "Asiento 48",
            "Asiento 49",
            "Asiento 50",
            "Asiento 51",
            "Asiento 52",
            "Asiento 53",
            "Asiento 54",
            "Asiento 55",
            "Asiento 56",
            "Asiento 57",
            "Asiento 58",
            "Asiento 59",
            "Asiento 60"});
            this.checkedListBox1.Location = new System.Drawing.Point(26, 33);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(176, 139);
            this.checkedListBox1.TabIndex = 0;
            // 
            // Btnatras
            // 
            this.Btnatras.Location = new System.Drawing.Point(321, 118);
            this.Btnatras.Name = "Btnatras";
            this.Btnatras.Size = new System.Drawing.Size(75, 23);
            this.Btnatras.TabIndex = 12;
            this.Btnatras.Text = "Atrás";
            this.Btnatras.UseVisualStyleBackColor = true;
            this.Btnatras.Click += new System.EventHandler(this.Btnatras_Click);
            // 
            // Frmpasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 474);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Tpasajero);
            this.Name = "Frmpasajero";
            this.Text = "Pasajero";
            this.Activated += new System.EventHandler(this.Frmpasajero_Activated);
            this.Load += new System.EventHandler(this.Frmpasajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tpasajero)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Tpasajero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btnsiguiente;
        private System.Windows.Forms.Button Btnactualizar;
        private System.Windows.Forms.Button Btneliminar;
        private System.Windows.Forms.Button Btnagregar;
        private System.Windows.Forms.TextBox Txtasiento;
        private System.Windows.Forms.TextBox Txtapellido;
        private System.Windows.Forms.TextBox Txtnombre;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button Btnatras;
    }
}