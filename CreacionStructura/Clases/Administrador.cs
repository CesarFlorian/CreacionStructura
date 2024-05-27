using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionStructura.Clases
{
    public class Administrador : Docente
    {
        public Administrador(string nombre, int edad, string puesto) : base(nombre, edad, puesto) { }

        public override void MostrarInformacion()
        {
            
        }
    }

}
