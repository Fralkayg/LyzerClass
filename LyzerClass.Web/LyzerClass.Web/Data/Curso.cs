using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LyzerClass.Web.Data
{
    public partial class Curso
    {
        public Curso()
        {
            Asignatura = new HashSet<Asignatura>();
        }

        public int Idcurso { get; set; }
        public int Idcolegio { get; set; }
        public string Descripcion { get; set; }
        public string Paralelo { get; set; }

        public virtual Colegio IdcolegioNavigation { get; set; }
        public virtual ICollection<Asignatura> Asignatura { get; set; }
    }
}
