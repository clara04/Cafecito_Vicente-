namespace Cafecito_Vicente.Interfaz
{
    partial class Boleto
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btnagregar = new System.Windows.Forms.Button();
            this.Btneliminar = new System.Windows.Forms.Button();
            this.Btnsiguiente = new System.Windows.Forms.Button();
            this.Btnactualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(93, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(144, 20);
            this.textBox3.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(293, 150);
            this.dataGridView1.TabIndex = 8;
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
            // 
            // Btnsiguiente
            // 
            this.Btnsiguiente.Location = new System.Drawing.Point(452, 127);
            this.Btnsiguiente.Name = "Btnsiguiente";
            this.Btnsiguiente.Size = new System.Drawing.Size(75, 23);
            this.Btnsiguiente.TabIndex = 11;
            this.Btnsiguiente.Text = "Siguiente";
            this.Btnsiguiente.UseVisualStyleBackColor = true;
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
            // Boleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 305);
            this.Controls.Add(this.Btnactualizar);
            this.Controls.Add(this.Btnsiguiente);
            this.Controls.Add(this.Btneliminar);
            this.Controls.Add(this.Btnagregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Boleto";
            this.Text = "Boleto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btnagregar;
        private System.Windows.Forms.Button Btneliminar;
        private System.Windows.Forms.Button Btnsiguiente;
        private System.Windows.Forms.Button Btnactualizar;
    }
}