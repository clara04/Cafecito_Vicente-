namespace Cafecito_Vicente.Interfaz
{
    partial class FrmConsulta
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
            this.Tbuscar = new System.Windows.Forms.DataGridView();
            this.Btnbuscar = new System.Windows.Forms.Button();
            this.Txtbuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Tbuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // Tbuscar
            // 
            this.Tbuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tbuscar.Location = new System.Drawing.Point(55, 74);
            this.Tbuscar.Name = "Tbuscar";
            this.Tbuscar.Size = new System.Drawing.Size(407, 177);
            this.Tbuscar.TabIndex = 2;
            this.Tbuscar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Tbuscar_MouseClick);
            // 
            // Btnbuscar
            // 
            this.Btnbuscar.Location = new System.Drawing.Point(55, 30);
            this.Btnbuscar.Name = "Btnbuscar";
            this.Btnbuscar.Size = new System.Drawing.Size(109, 29);
            this.Btnbuscar.TabIndex = 4;
            this.Btnbuscar.Text = "Buscar";
            this.Btnbuscar.UseVisualStyleBackColor = true;
            this.Btnbuscar.Click += new System.EventHandler(this.Btnbuscar_Click);
            // 
            // Txtbuscar
            // 
            this.Txtbuscar.Location = new System.Drawing.Point(184, 35);
            this.Txtbuscar.Name = "Txtbuscar";
            this.Txtbuscar.Size = new System.Drawing.Size(267, 20);
            this.Txtbuscar.TabIndex = 5;
            this.Txtbuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 283);
            this.Controls.Add(this.Txtbuscar);
            this.Controls.Add(this.Btnbuscar);
            this.Controls.Add(this.Tbuscar);
            this.Name = "FrmConsulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.FrmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tbuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Tbuscar;
        private System.Windows.Forms.Button Btnbuscar;
        private System.Windows.Forms.TextBox Txtbuscar;
    }
}