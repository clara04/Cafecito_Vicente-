using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cafecito_Vicente.Datos;
using Cafecito_Vicente.Logica;
using System.Windows.Forms;

namespace Cafecito_Vicente.Interfaz
{
    public partial class FrmCorrida : Form
    {
        public FrmCorrida()
        {
            InitializeComponent();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            Frmboleto mBoleto = new Frmboleto();
            mBoleto.ShowDialog();
        }

        private void FrmCorrida_Activated(object sender, EventArgs e)
        {
            ControlCorrida mControlCorrida = new ControlCorrida();
            Tcorrida.DataSource = mControlCorrida.consultarCorrida().Tables[0];
        }

        private void Btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                Corrida mCorrida = new Corrida();
                mCorrida.id = Txtid.Text;
                mCorrida.origen = Txtorigen.Text;
                mCorrida.destino = textBox1.Text;
                mCorrida.fecha = Txtfecha.Text;
                mCorrida.hora = Txthora.Text;

                ControlCorrida mControl = new ControlCorrida();
                mControl.agregarCorrida(mCorrida);
                MessageBox.Show("Se ha agregado una corrida");
            }
            catch 
            {
                MessageBox.Show("Error al actualizar");
            }
        }

        private void Btnmodificar_Click(object sender, EventArgs e)
        {
            Corrida mCorrida = new Corrida();
            mCorrida.id = Txtid.Text;
            mCorrida.origen = Txtorigen.Text;
            mCorrida.destino = textBox1.Text;
            mCorrida.fecha = Txtfecha.Text;
            mCorrida.hora = Txthora.Text;

            ControlCorrida mControl = new ControlCorrida();
            mControl.modificarCorrida(mCorrida);
            MessageBox.Show("Se ha modificado una corrida");
        }

        private void Btneliminar_Click(object sender, EventArgs e)
        {
            Corrida mCorrida = new Corrida();
            int ID = (int)Tcorrida.SelectedRows[0].Cells[0].Value;

            ControlCorrida mControl = new ControlCorrida();
            mControl.eliminarCorrida(ID);
            MessageBox.Show("Se ha eliminado una corrida");

        }

        private void Tcorrida_MouseClick(object sender, MouseEventArgs e)
        {
            int ID = (int)Tcorrida.SelectedRows[0].Cells[0].Value;
            Txtorigen.Text = Tcorrida.SelectedRows[0].Cells[1].Value.ToString();
            Txtdestino.Text = Tcorrida.SelectedRows[0].Cells[2].Value.ToString();
            Txtfecha.Text = Tcorrida.SelectedRows[0].Cells[3].Value.ToString();
            Txthora.Text = Tcorrida.SelectedRows[0].Cells[4].Value.ToString();


        }
    }
}
