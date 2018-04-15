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

namespace Cafecito_Vicente.Interfaz
{
    public partial class Frmboleto : Form
    {
        public Frmboleto()
        {
            InitializeComponent();
        }

        private void Btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                Boleto mBoleto = new Boleto();
                mBoleto.id = Txtid.Text;
                mBoleto.tipo = Txttipo.Text;
                mBoleto.Precio = float.Parse(Txtprecio.Text);

                ControlBoleto mControlBoleto = new ControlBoleto();
                mControlBoleto.agregarBoleto(mBoleto);
                MessageBox.Show("Se ha agregado un boleto");
            }
            catch
            {
                MessageBox.Show("Error al actualizar");
            }
        }

        private void Frmboleto_Activated(object sender, EventArgs e)
        {
            ControlBoleto mControlBoleto = new ControlBoleto();
            Tboleto.DataSource = mControlBoleto.consultarBoleto().Tables[0];
        }

        private void Btneliminar_Click(object sender, EventArgs e)
        {
            Boleto mBoleto = new Boleto();
            int ID = (int)Tboleto.SelectedRows[0].Cells[0].Value;

            ControlBoleto mControlBoleto = new ControlBoleto();
            mControlBoleto.eliminarBoleto(ID);
            MessageBox.Show("Se ha eliminado un boleto");
        }

        private void Tboleto_MouseClick(object sender, MouseEventArgs e)
        {
           
            int ID = (int)Tboleto.SelectedRows[0].Cells[0].Value;
            Txttipo.Text = Tboleto.SelectedRows[0].Cells[1].Value.ToString();
            Txttipo.Text = Tboleto.SelectedRows[0].Cells[2].Value.ToString();
            Txtprecio.Text = Tboleto.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void Btnsiguiente_Click(object sender, EventArgs e)
        {
            Frmpasajero frmpasajero = new Frmpasajero();
            frmpasajero.ShowDialog();
        }
    }
}
