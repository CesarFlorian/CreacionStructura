using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionStructura.Clases
{
   
   
        public class Maestro : Docente
        {
            public string Materia { get; set; }

            public Maestro(string nombre, int edad, string puesto, string materia) : base(nombre, edad, puesto)
            {
                Materia = materia;
            }

            public override void MostrarInformacion()
            {
                
            }
        }
}

