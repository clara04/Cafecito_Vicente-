namespace Cafecito_Vicente.Interfaz
{
    partial class FrmCorrida
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.Txtorigen = new System.Windows.Forms.TextBox();
            this.Txtfecha = new System.Windows.Forms.TextBox();
            this.Txthora = new System.Windows.Forms.TextBox();
            this.Tcorrida = new System.Windows.Forms.DataGridView();
            this.Btnagregar = new System.Windows.Forms.Button();
            this.Btneliminar = new System.Windows.Forms.Button();
            this.Btnmodificar = new System.Windows.Forms.Button();
            this.BtnSiguiente = new System.Windows.Forms.Button();
            this.Txtdestino = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tcorrida)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Txtdestino);
            this.groupBox1.Controls.Add(this.Txthora);
            this.groupBox1.Controls.Add(this.Txtfecha);
            this.groupBox1.Controls.Add(this.Txtorigen);
            this.groupBox1.Controls.Add(this.Txtid);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(52, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Corrida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Origen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora:";
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(62, 23);
            this.Txtid.Multiline = true;
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(155, 20);
            this.Txtid.TabIndex = 4;
            // 
            // Txtorigen
            // 
            this.Txtorigen.Location = new System.Drawing.Point(71, 52);
            this.Txtorigen.Multiline = true;
            this.Txtorigen.Name = "Txtorigen";
            this.Txtorigen.Size = new System.Drawing.Size(146, 20);
            this.Txtorigen.TabIndex = 5;
            // 
            // Txtfecha
            // 
            this.Txtfecha.Location = new System.Drawing.Point(79, 112);
            this.Txtfecha.Multiline = true;
            this.Txtfecha.Name = "Txtfecha";
            this.Txtfecha.Size = new System.Drawing.Size(100, 20);
            this.Txtfecha.TabIndex = 6;
            // 
            // Txthora
            // 
            this.Txthora.Location = new System.Drawing.Point(71, 144);
            this.Txthora.Name = "Txthora";
            this.Txthora.Size = new System.Drawing.Size(108, 20);
            this.Txthora.TabIndex = 1;
            // 
            // Tcorrida
            // 
            this.Tcorrida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tcorrida.Location = new System.Drawing.Point(52, 208);
            this.Tcorrida.Name = "Tcorrida";
            this.Tcorrida.Size = new System.Drawing.Size(409, 164);
            this.Tcorrida.TabIndex = 1;
            this.Tcorrida.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Tcorrida_MouseClick);
            // 
            // Btnagregar
            // 
            this.Btnagregar.Location = new System.Drawing.Point(517, 85);
            this.Btnagregar.Name = "Btnagregar";
            this.Btnagregar.Size = new System.Drawing.Size(102, 23);
            this.Btnagregar.TabIndex = 2;
            this.Btnagregar.Text = "Agregar nuevo";
            this.Btnagregar.UseVisualStyleBackColor = true;
            this.Btnagregar.Click += new System.EventHandler(this.Btnagregar_Click);
            // 
            // Btneliminar
            // 
            this.Btneliminar.Location = new System.Drawing.Point(637, 87);
            this.Btneliminar.Name = "Btneliminar";
            this.Btneliminar.Size = new System.Drawing.Size(94, 23);
            this.Btneliminar.TabIndex = 3;
            this.Btneliminar.Text = "Eliminar";
            this.Btneliminar.UseVisualStyleBackColor = true;
            this.Btneliminar.Click += new System.EventHandler(this.Btneliminar_Click);
            // 
            // Btnmodificar
            // 
            this.Btnmodificar.Location = new System.Drawing.Point(517, 137);
            this.Btnmodificar.Name = "Btnmodificar";
            this.Btnmodificar.Size = new System.Drawing.Size(108, 23);
            this.Btnmodificar.TabIndex = 4;
            this.Btnmodificar.Text = "Modificar";
            this.Btnmodificar.UseVisualStyleBackColor = true;
            this.Btnmodificar.Click += new System.EventHandler(this.Btnmodificar_Click);
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.Location = new System.Drawing.Point(637, 137);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(94, 23);
            this.BtnSiguiente.TabIndex = 5;
            this.BtnSiguiente.Text = "Siguiente";
            this.BtnSiguiente.UseVisualStyleBackColor = true;
            this.BtnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // Txtdestino
            // 
            this.Txtdestino.AutoSize = true;
            this.Txtdestino.Location = new System.Drawing.Point(19, 86);
            this.Txtdestino.Name = "Txtdestino";
            this.Txtdestino.Size = new System.Drawing.Size(46, 13);
            this.Txtdestino.TabIndex = 7;
            this.Txtdestino.Text = "Destino:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 83);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 8;
            // 
            // FrmCorrida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 370);
            this.Controls.Add(this.BtnSiguiente);
            this.Controls.Add(this.Btnmodificar);
            this.Controls.Add(this.Btneliminar);
            this.Controls.Add(this.Btnagregar);
            this.Controls.Add(this.Tcorrida);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCorrida";
            this.Text = "Corrida";
            this.Activated += new System.EventHandler(this.FrmCorrida_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tcorrida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txtfecha;
        private System.Windows.Forms.TextBox Txtorigen;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txthora;
        private System.Windows.Forms.DataGridView Tcorrida;
        private System.Windows.Forms.Button Btnagregar;
        private System.Windows.Forms.Button Btneliminar;
        private System.Windows.Forms.Button Btnmodificar;
        private System.Windows.Forms.Button BtnSiguiente;
        private System.Windows.Forms.Label Txtdestino;
        private System.Windows.Forms.TextBox textBox1;

    }
}