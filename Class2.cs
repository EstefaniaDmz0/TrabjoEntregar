using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabjoEntregar
{
    class CAlumnosTec : CAlumnos
    {
        string carrera;
        int semestre;

        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }

        public int Semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }

        public CAlumnosTec()
        {
            carrera = string.Empty;
            semestre = 0;
        }

        public CAlumnosTec(int sem, string c)
        {
            carrera = c;
            semestre = sem;
        }
    }
}
