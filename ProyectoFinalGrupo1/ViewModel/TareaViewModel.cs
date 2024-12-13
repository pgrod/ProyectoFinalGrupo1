using ProyectoFinalGrupo1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProyectoFinalGrupo1.ViewModel
{
    public class TareaViewModel:BindableObject
    {
        private ObservableCollection<Tarea> tarea;

        public ObservableCollection<Tarea> Tarea
        {
            get => tarea;
            set
            {
                tarea = value;
                OnPropertyChanged();
            }
        }

        private string NuevaTarea;

        public string Nuevatarea
        {
            get => NuevaTarea;
            set
            {
                NuevaTarea = value;
                OnPropertyChanged();
            }
        }

        public ICommand AgregarTareaCommand { get; }
        public ICommand RemoveTareaCommand { get; }
        public ICommand EditarEstadoCommand { get; }

        public TareaViewModel()
        {
            Tarea = new ObservableCollection<Tarea>();

            AgregarTareaCommand = new Command(AgregarTarea);
            RemoveTareaCommand = new Command<Tarea>(RemoveTarea);
            EditarEstadoCommand = new Command<Tarea>(EditarEstado);
        }

        private void AgregarTarea()
        {
            if (!string.IsNullOrEmpty(NuevaTarea))
            {
                Tarea.Add(new Models.Tarea(Nuevatarea));
                NuevaTarea = string.Empty;
                OnPropertyChanged(nameof(Nuevatarea));
            }
        }

        private void RemoveTarea(Tarea tarea)
        {
            Tarea.Remove(tarea);
        }

        private string estado;
        public string Estado
        {
            get => estado;
            set
            {
                estado = value;
                OnPropertyChanged();
            }
        }

        public string Nombre { get; set; }

        public TareaViewModel(string nombre)
        {
            Nombre = nombre;
            Estado = "Por hacer";
        }

        private void EditarEstado(Tarea tarea)
        {
            if (tarea != null)
            {
                if (tarea.Estado == "Por hacer")
                    tarea.Estado = "En progreso";
                else if (tarea.Estado == "En progreso")
                    tarea.Estado = "Finalizada";
                else
                    tarea.Estado = "Por hacer";
            }
        }
    }
}
