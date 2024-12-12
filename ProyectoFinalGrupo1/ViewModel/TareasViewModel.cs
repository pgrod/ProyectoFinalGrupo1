using ProyectoFinalGrupo1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalGrupo1.ViewModel
{
    public class TareasViewModel
    {
        private readonly List<Tareas> tareas = new List<Tareas>();

        public void EditarTarea(Tareas tareas)
        {
            var tareaCreada = tareas.Find(t => t.Id == tareas.Id);
            if (tareaCreada != null)
            {
                tareaCreada.Tarea = tareas.Tarea;
                tareaCreada.Descripcion = tareas.Descripcion;
                tareaCreada.Estado = tareas.Estado;
            }
        }

        public void RemoveTarea(int Id)
        {
            var tareas = tareas.Find(tareas=> tareas.Id == Id);
            if (tareas != null)
            {
                tareas.Remove(tareas);
            }
        }
    }
}
