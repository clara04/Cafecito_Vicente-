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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BTNcancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if(TxtUsuario.Text == "ADMIN" && TxtContraseña.Text == "12345")
            {
                //MessageBox.Show("Bienvenido");
                FrmCorrida mcorrida = new FrmCorrida();
                mcorrida.ShowDialog();

            }
            else
            {
                MessageBox.Show("Acceso denegado");
            }
        }
    }
}
