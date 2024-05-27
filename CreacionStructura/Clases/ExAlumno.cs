using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionStructura.Clases
{
    public class ExAlumno : MiembroDeLaComunidad
    {
        public int AñoDeGraduacion { get; set; }

        public ExAlumno(string nombre, int edad, int añoDeGraduacion) : base(nombre, edad)
        {
            AñoDeGraduacion = añoDeGraduacion;
        }

        public override void MostrarInformacion()
        {
            
        }
    }

}
