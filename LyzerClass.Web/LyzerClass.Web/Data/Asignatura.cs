using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LyzerClass.Web.Data
{
    public partial class Asignatura
    {
        public Asignatura()
        {
            HorarioAsignatura = new HashSet<HorarioAsignatura>();
        }

        public int Idasignatura { get; set; }
        public int Idtipoasignatura { get; set; }
        public int Iddocente { get; set; }
        public int Idcurso { get; set; }
        public DateTime Ano { get; set; }

        public virtual Curso IdcursoNavigation { get; set; }
        public virtual Docente IddocenteNavigation { get; set; }
        public virtual TipoAsignatura IdtipoasignaturaNavigation { get; set; }
        public virtual ICollection<HorarioAsignatura> HorarioAsignatura { get; set; }
    }
}
