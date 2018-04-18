using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cafecito_Vicente.BD;
using Cafecito_Vicente.Logica;
using Cafecito_Vicente.Datos;
using System.Windows.Forms;
using System.Windows.Forms;

namespace Cafecito_Vicente.Interfaz
{
    public partial class FrmConsulta : Form
    {

        public FrmConsulta()
        {
            InitializeComponent();
        }
        BaseDatos mBB = new BaseDatos();
        private void Btnbuscar_Click(object sender, EventArgs e)
        {
            ControlCorrida mControlCorrida = new ControlCorrida();
            Tbuscar.DataSource = mControlCorrida.consultarCorrida().Tables[0];

           
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
        }
    }
}
