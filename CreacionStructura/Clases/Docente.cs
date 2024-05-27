using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionStructura.Clases
{
        public abstract class Docente : Empleado
        {
            public Docente(string nombre, int edad, string puesto) : base(nombre, edad, puesto) { }
        }

    
}
