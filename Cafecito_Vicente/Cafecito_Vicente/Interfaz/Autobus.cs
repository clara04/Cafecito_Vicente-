using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafecito_Vicente.Interfaz
{
    public partial class Autobus : Form
    {
        private Label LblId;
        private Label LblNombre;
        private Label LblApellidos;
        private Label LblHora;
        private Label LblOrigen;
        private Label LblDestino;
        private TextBox TxtID;
        private TextBox TxtFecha;
        private TextBox TxtOrigen;
        private TextBox TxtNombre;
        private TextBox TxtApellidos;
        private TextBox TxtHora;
        private TextBox TxtDestino;
        private Button BtnGuardar;
        private Button BtnSiguiente;
        private Label LblFecha;
    
        public Autobus()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.LblId = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblHora = new System.Windows.Forms.Label();
            this.LblOrigen = new System.Windows.Forms.Label();
            this.LblDestino = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.TxtOrigen = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.TxtHora = new System.Windows.Forms.TextBox();
            this.TxtDestino = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnSiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(12, 29);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(21, 13);
            this.LblId.TabIndex = 0;
            this.LblId.Text = "ID:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(11, 58);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(47, 13);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.Location = new System.Drawing.Point(11, 85);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(52, 13);
            this.LblApellidos.TabIndex = 2;
            this.LblApellidos.Text = "Apellidos:";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(11, 111);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(40, 13);
            this.LblFecha.TabIndex = 3;
            this.LblFecha.Text = "Fecha:";
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Location = new System.Drawing.Point(11, 137);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(33, 13);
            this.LblHora.TabIndex = 4;
            this.LblHora.Text = "Hora:";
            // 
            // LblOrigen
            // 
            this.LblOrigen.AutoSize = true;
            this.LblOrigen.Location = new System.Drawing.Point(12, 163);
            this.LblOrigen.Name = "LblOrigen";
            this.LblOrigen.Size = new System.Drawing.Size(41, 13);
            this.LblOrigen.TabIndex = 5;
            this.LblOrigen.Text = "Origen:";
            // 
            // LblDestino
            // 
            this.LblDestino.AutoSize = true;
            this.LblDestino.Location = new System.Drawing.Point(12, 189);
            this.LblDestino.Name = "LblDestino";
            this.LblDestino.Size = new System.Drawing.Size(46, 13);
            this.LblDestino.TabIndex = 6;
            this.LblDestino.Text = "Destino:";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(91, 29);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(186, 20);
            this.TxtID.TabIndex = 7;
            // 
            // TxtFecha
            // 
            this.TxtFecha.Location = new System.Drawing.Point(91, 108);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(186, 20);
            this.TxtFecha.TabIndex = 8;
            // 
            // TxtOrigen
            // 
            this.TxtOrigen.Location = new System.Drawing.Point(91, 160);
            this.TxtOrigen.Name = "TxtOrigen";
            this.TxtOrigen.Size = new System.Drawing.Size(186, 20);
            this.TxtOrigen.TabIndex = 9;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(91, 55);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(186, 20);
            this.TxtNombre.TabIndex = 10;
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Location = new System.Drawing.Point(91, 82);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(186, 20);
            this.TxtApellidos.TabIndex = 11;
            // 
            // TxtHora
            // 
            this.TxtHora.Location = new System.Drawing.Point(91, 134);
            this.TxtHora.Name = "TxtHora";
            this.TxtHora.Size = new System.Drawing.Size(186, 20);
            this.TxtHora.TabIndex = 12;
            // 
            // TxtDestino
            // 
            this.TxtDestino.Location = new System.Drawing.Point(91, 186);
            this.TxtDestino.Name = "TxtDestino";
            this.TxtDestino.Size = new System.Drawing.Size(186, 20);
            this.TxtDestino.TabIndex = 13;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(63, 253);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 14;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.Location = new System.Drawing.Point(202, 253);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.BtnSiguiente.TabIndex = 15;
            this.BtnSiguiente.Text = "Siguiente";
            this.BtnSiguiente.UseVisualStyleBackColor = true;
            // 
            // Autobus
            // 
            this.ClientSize = new System.Drawing.Size(395, 324);
            this.Controls.Add(this.BtnSiguiente);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtDestino);
            this.Controls.Add(this.TxtHora);
            this.Controls.Add(this.TxtApellidos);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtOrigen);
            this.Controls.Add(this.TxtFecha);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.LblDestino);
            this.Controls.Add(this.LblOrigen);
            this.Controls.Add(this.LblHora);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.LblApellidos);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblId);
            this.Name = "Autobus";
            this.Load += new System.EventHandler(this.Autobus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Autobus_Load(object sender, EventArgs e)
        {

        }
    }
}
