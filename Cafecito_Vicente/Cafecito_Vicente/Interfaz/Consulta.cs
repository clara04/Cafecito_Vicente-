using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cafecito_Vicente.Datos;
using Cafecito_Vicente.Logica;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;

namespace Cafecito_Vicente.Interfaz
{
    public partial class Frmconsulta : Form
    {
        public Frmconsulta()
        {
            InitializeComponent();
            ControlCorrida mControl = new ControlCorrida();

            try
            {
                Tbuscar.DataSource = mControl.consultarCorrida();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frmconsulta_Activated(object sender, EventArgs e)
        {
            

        }

        private void Btngenerar_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter write = PdfWriter.GetInstance(doc, new FileStream("Reporte.pdf", FileMode.Create));
            doc.Open();
            PdfPTable table = new PdfPTable(Tbuscar.Columns.Count);
            table.AddCell(new Phrase("id"));
            table.AddCell(new Phrase("origen"));
            table.AddCell(new Phrase("destino"));
            table.AddCell(new Phrase("hora"));
            table.AddCell(new Phrase("fecha"));
            table.HeaderRows = 1;

            for (int i = 0; i < Tbuscar.Columns.Count; i++)
            {
                for (int j = 0; j < Tbuscar.Columns.Count; j++)
                {
                    {
                        if (Tbuscar[j, i].Value != null)
                        {
                            table.AddCell(new Phrase(Tbuscar[j, i].Value.ToString()));
                        }

                    }
                }
            }
            doc.Add(table);
            doc.Close();
            Process.Start("Reporte.pdf");

        }






        private void Btnimprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter write = PdfWriter.GetInstance(doc, new FileStream("C:/Users/Ivette Cerrillo/Documents/Ingeniería de Software/Axel-Clara/Cafecito_Vicente-/Reporte/Reporte.pdf", FileMode.Create));
                doc.Open();
                PdfPTable table = new PdfPTable(Tbuscar.Columns.Count);
                for (int j = 0; j < Tbuscar.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(Tbuscar.Columns[1].HeaderText));
                }
                table.HeaderRows = 1;
                for (int i = 0; i < Tbuscar.Rows.Count; i++)
                {
                    for (int k = 0; k < Tbuscar.Columns.Count; k++)
                    {
                        if (Tbuscar[k, i].Value != null)
                        {
                            table.AddCell(new Phrase(Tbuscar[k, i].Value.ToString()));
                        }
                    }
                }
                doc.Add(table);
                MessageBox.Show("Reporte generado");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al imprimir");
            }
        }

        private void Btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ControlCorrida mControlCorrida = new ControlCorrida();
                {
                    Tbuscar.DataSource = null;
                    Tbuscar.DataSource = mControlCorrida.consultarCorrida(Txtid.Text);
                    Tbuscar.Refresh();
                    

                }
            }

            catch (Exception)
            {
                MessageBox.Show("Error al buscar.");
            }
        }




        private void Tbuscar_MouseClick(object sender, MouseEventArgs e)
        {
            int ID = (int)Tbuscar.SelectedRows[0].Cells[0].Value;
            Txtid.Text = Tbuscar.SelectedRows[0].Cells[1].Value.ToString();


        }

        private void btnconsul_Click(object sender, EventArgs e)
        {

        }
    }
}


        
    
    

