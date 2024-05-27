using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionStructura.Clases
{
    public abstract class Empleado : MiembroDeLaComunidad
    {
        public string Puesto { get; set; }

        public Empleado(string nombre, int edad, string puesto) : base(nombre, edad)
        {
            Puesto = puesto;
        }
    }

}
