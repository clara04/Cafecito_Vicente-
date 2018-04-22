using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cafecito_Vicente.Logica;
using Cafecito_Vicente.Datos;
using Cafecito_Vicente.BD;
namespace Cafecito_Vicente.Interfaz
{
    public partial class FrmConsultas : Form
    {
        public FrmConsultas()
        {
            InitializeComponent();
        }
        BaseDatos mBD = new BaseDatos();
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (Txtbuscar.Text != "")
            {
                TBuscar.DataSource = mBD.ejecutarConsulta(Txtbuscar.Text);
            }
            else
            {
                MessageBox.Show("Error. No se ha encontrado el dato ingresado.");
            }
        }
    }
}
