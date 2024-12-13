using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalGrupo1.Models
{
    public class Tarea
    {
        public string Nombre { get; set; }
        public string Estado { get; set; } = "Por hacer";

        public Tarea(string nombre)
        {
            Nombre = nombre;
        }
    }

}
