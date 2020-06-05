using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabjoEntregar
{
    class CAlumnos
    {
        string nombre;
        int edad;
        char sexo;
        bool estudianteTec;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public bool EstudianteTec
        {
            get { return estudianteTec; }
            set { estudianteTec = value; }
        }

        public CAlumnos()
        {
            nombre = string.Empty;
            edad = 0;
            sexo = ' ';
            estudianteTec = false;
        }

        public CAlumnos(string n, int e, char s, bool t)
        {
            nombre = n;
            edad = e;
            sexo = s;
            estudianteTec = t;
        }
    }
}
