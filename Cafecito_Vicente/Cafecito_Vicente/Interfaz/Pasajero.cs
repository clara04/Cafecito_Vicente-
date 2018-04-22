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
    public partial class Frmpasajero : Form
    {
       
        public Frmpasajero()
        {
            InitializeComponent();
        }
    
        private void Frmpasajero_Activated(object sender, EventArgs e)
        {
            ControlPasajero mControlPasajero = new ControlPasajero();
            Tpasajero.DataSource = mControlPasajero.consultarPasajero().Tables[0];
        }

        private void Btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                Pasajero mPasajero = new Pasajero();
                mPasajero.ID = Txtid.Text;
                mPasajero.nombre = Txtnombre.Text;
                mPasajero.apellido = Txtapellido.Text;
                mPasajero.Asiento = int.Parse(Txtasiento.Text);

                ControlPasajero mControlPasajero = new ControlPasajero();
                mControlPasajero.agregarPasajero(mPasajero);
                MessageBox.Show("El Pasajero se ha agregado con éxito");
            }
            catch (Exception) 
            {
                MessageBox.Show("Error al actualizar");
                
            }
        }

        private void Btneliminar_Click(object sender, EventArgs e)
        {
            Pasajero mPasajero = new Pasajero();
            int ID = (int)Tpasajero.SelectedRows[0].Cells[0].Value;

            ControlPasajero mControlPasajero = new ControlPasajero();
            mControlPasajero.eliminarPasajero(ID);
            MessageBox.Show("Se ha eliminado un pasajero");
        }

        private void Tpasajero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frmpasajero_Load(object sender, EventArgs e)
        {
            int asientos = 60;
            this.checkedListBox1.Items.Clear();
            for (int i = 0; i < asientos; i++)
            {
                this.checkedListBox1.Items.Add("Asiento: " + (i + 1));
            }
        }

        private void Btnactualizar_Click(object sender, EventArgs e)
        {
            Pasajero mPasajero = new Pasajero();
            mPasajero.ID = Txtid.Text;
            mPasajero.nombre = Txtnombre.Text;
            mPasajero.apellido = Txtapellido.Text;
            mPasajero.Asiento = int.Parse(Txtasiento.Text);

        }

        private void Tpasajero_MouseClick(object sender, MouseEventArgs e)
        {
            int ID = (int)Tpasajero.SelectedRows[0].Cells[0].Value;
            Txtnombre.Text = Tpasajero.SelectedRows[0].Cells[1].Value.ToString();
            Txtapellido.Text = Tpasajero.SelectedRows[0].Cells[2].Value.ToString();
            Txtasiento.Text = Tpasajero.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void Btnsiguiente_Click(object sender, EventArgs e)
        {
            FrmConsultas consulta = new FrmConsultas();
            consulta.ShowDialog();
        }
    }
}
