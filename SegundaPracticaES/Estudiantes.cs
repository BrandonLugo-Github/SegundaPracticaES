using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundaPracticaES
{
    class Estudiantes
    {
        string nombre;
        int matricula;
        int edad;
        int semestre;
        string carrera;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
      

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public int Semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }


        public override string ToString()
        {
            return matricula + "," + nombre + "," + edad + "," + semestre + "," + carrera;
        }

        public void mostrar(ListView caja)
        {
            
             
            ListViewItem datos = new ListViewItem(nombre);
            datos.SubItems.Add(matricula + "");
            datos.SubItems.Add(edad + "");
            datos.SubItems.Add(semestre + "");
            datos.SubItems.Add(carrera);
            caja.Items.Add(datos);

        }



    }
}
