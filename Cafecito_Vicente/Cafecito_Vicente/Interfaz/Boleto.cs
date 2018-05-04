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
            ControlBoleto mControlBoleto = new ControlBoleto();
            Tboleto.DataSource = mControlBoleto.consultarBoleto();
        }

        private void Btnsiguiente_Click(object sender, EventArgs e)
        {
            Frmpasajero pasajero = new Frmpasajero();
            pasajero.ShowDialog();
        }

        private void Btnatras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frmboleto_Activated(object sender, EventArgs e)
        {
          
        }

        private void Btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                Boleto mBoleto = new Boleto();
                mBoleto.id = int.Parse(Txtid.Text);
                mBoleto.Precio = float.Parse(Txtpecio.Text);
                mBoleto.tipo = Txttipo.Text;

                ControlBoleto mControl = new ControlBoleto();
                mControl.agregarBoleto(mBoleto);
                MessageBox.Show("Se ha agregado el boleto exitosamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar");
            }
        }

        private void Btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Boleto mBoleto = new Boleto();
                int ID = (int)Tboleto.SelectedRows[0].Cells[0].Value;

                ControlBoleto mControl = new ControlBoleto();
                mControl.eliminarBoleto(ID);
                MessageBox.Show("Se ha eliminado una corrida");
            }
            catch(Exception)
            {
                MessageBox.Show("Error al eliminar");

            }
        }

        private void Btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                Boleto mBoleto = new Boleto();
                int ID = (int)Tboleto.SelectedRows[0].Cells[0].Value;
                mBoleto.id = ID;
                mBoleto.Precio = float.Parse(Txtpecio.Text);
                mBoleto.tipo = Txttipo.Text;

                ControlBoleto mControl = new ControlBoleto();
                mControl.agregarBoleto(mBoleto);
                MessageBox.Show("Se ha modificado el boleto exitosamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al modificar.");
            }
        }

        private void Tboleto_MouseClick(object sender, MouseEventArgs e)
        {
            int ID = (int)Tboleto.SelectedRows[0].Cells[0].Value;
            Txtpecio.Text = Tboleto.SelectedRows[0].Cells[1].Value.ToString();
            Txttipo.Text = Tboleto.SelectedRows[0].Cells[2].Value.ToString();
          
        }
    }
}
