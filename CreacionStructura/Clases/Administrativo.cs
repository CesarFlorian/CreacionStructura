using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionStructura.Clases
{
    public class Administrativo : Empleado
    {
        public Administrativo(string nombre, int edad, string puesto) : base(nombre, edad, puesto) { }

        public override void MostrarInformacion()
        {
            
        }
    }

}
