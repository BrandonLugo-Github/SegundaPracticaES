using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundaPracticaES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        int cantidad = 0;
        Estudiantes[] arreglo;
        Estudiantes obj = new Estudiantes();
        //DialogBoxVentas venta = new DialogBoxVentas();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cantidad = int.Parse(txtcantidad.Text);
            arreglo = new Estudiantes[cantidad];
            txtcantidad.Clear();
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            textNombre.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i < cantidad )
            {
                obj.mostrar(listView1);
                arreglo[i] = new Estudiantes();
                arreglo[i].Matricula = int.Parse(txtMatricula.Text);
                arreglo[i].Nombre = textNombre.Text;
                arreglo[i].Edad = int.Parse(txtEdad.Text);
                arreglo[i].Semestre = int.Parse(txtSemestre.Text);
                arreglo[i].Carrera = txtCarrera.Text;
                txtMatricula.Clear();
                textNombre.Clear();
                txtEdad.Clear();
                txtCarrera.Clear();
                txtSemestre.Clear();
                textNombre.Focus();
                i++;
            }
            if (i == cantidad)
            {
                //Mostrar mensaje
                MessageBox.Show("El Arreglo esta lleno","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Information);
                //Limpiar lista previa a llenar
                listView1.Items.Clear();
                //listBox1.Items.Clear();
                //agregar datos al listbox
                for (int l = 0; l < cantidad; l++)
                {
                    listView1.Items.Add(arreglo[l] + "");
                    //obj.mostrar(listView1);
                   // listBox1.Items.Add(arreglo[l]);

                }
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
