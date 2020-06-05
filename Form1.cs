using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TrabjoEntregar
{
    public partial class Form1 : Form
    {
        string nom, carr, arroz;
        int eda, semes;
        char sex;
        bool estu;

        public Form1()
        {
            InitializeComponent();
        }
        CAlumnos X()
        {
            CAlumnos y = new CAlumnos(txbNombre.Text, Convert.ToInt32(txbEdad.Text), Convert.ToChar(txbSexo.Text), estu);
            return y;
        }

        CAlumnosTec M()
        {
            CAlumnosTec z = new CAlumnosTec(Convert.ToInt32(txbSemestre.Text), txbCarrera.Text);
            return z;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (rbtnSi.Checked == true)
            {
                estu = true;
                txbCarrera.Enabled = true;
                txbSemestre.Enabled = true;
                btnEnviSeg.Enabled = true;
            }
            else
            {
                estu = false;
                txbCarrera.Enabled = false;
                txbSemestre.Enabled = false;
                btnEnviSeg.Enabled = false;
            }

            CAlumnos i;
            i = X();
            nom = i.Nombre;
            eda = i.Edad;
            sex = i.Sexo;
            estu = i.EstudianteTec;


            if (rbtnSi.Checked == true)
            {

            }
            else
            {
                GuardarDatos();
                Limpiar();
            }

        }

        private void btnEnviSeg_Click(object sender, EventArgs e)
        {
            CAlumnosTec j;
            j = M();
            carr = j.Carrera;
            semes = j.Semestre;
            GuardarDatos();
            Limpiar();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File (.txt) | *.txt";
            if (sfd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
            {
                foreach (ListViewItem item in lstv.Items)
                {

                    await tw.WriteLineAsync(item.SubItems[0].Text + "," + item.SubItems[1].Text + "," + item.SubItems[2].Text + "," + item.SubItems[3].Text + "," + item.SubItems[4].Text + "," + item.SubItems[5].Text);

                }
                MessageBox.Show("Datos guardados.");
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog path = new OpenFileDialog();
            if (path.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            arroz = path.FileName;
            Holi(arroz);
        }

        private void Limpiar()
        {
            txbNombre.Clear();
            txbEdad.Clear();
            txbSexo.Clear();
            rdbtnNo.Checked = false;
            rbtnSi.Checked = false;
            txbCarrera.Clear();
            txbSemestre.Clear();
            txbCarrera.Enabled = false;
            txbSemestre.Enabled = false;
            btnEnviSeg.Enabled = false;
        }

        private void GuardarDatos()
        {
            ListViewItem lvi = new ListViewItem(txbNombre.Text);
            lvi.SubItems.Add(txbEdad.Text);
            lvi.SubItems.Add(txbSexo.Text);
            lvi.SubItems.Add(Convert.ToString(estu));
            
            if (rbtnSi.Checked == true)
            {
                lvi.SubItems.Add(txbSemestre.Text);
                lvi.SubItems.Add(txbCarrera.Text);
            }
            else
            {
                lvi.SubItems.Add("???");
                lvi.SubItems.Add("???");
            }
            lstv.Items.Add(lvi);
        }

        private void Holi(string filePath)
        {
            ListViewItem lvi;
            string[] lineas = File.ReadAllLines(filePath);
            if (lineas.Length > 0)
            {
                for (int i=0; i < lineas.Length; i++)
                {
                    string[] palabras = lineas[i].Split(',');
                    lvi = new ListViewItem(palabras[0]);
                    for (int j=1; j<palabras.Length; j++)
                    {
                        lvi.SubItems.Add(palabras[j]);
                    }
                    lstv.Items.Add(lvi);
                }
            }
        }
    }
}
