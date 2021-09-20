using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LyzerClass.Web.Data
{
    public partial class HorarioAsignatura
    {
        public HorarioAsignatura()
        {
            Video = new HashSet<Video>();
        }

        public int Idhorarioasignatura { get; set; }
        public int Idasignatura { get; set; }
        public string Dia { get; set; }
        public DateTime Hora { get; set; }

        public virtual Asignatura IdasignaturaNavigation { get; set; }
        public virtual ICollection<Video> Video { get; set; }
    }
}
