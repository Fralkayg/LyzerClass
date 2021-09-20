using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LyzerClass.Web.Data
{
    public partial class TipoAsignatura
    {
        public TipoAsignatura()
        {
            Asignatura = new HashSet<Asignatura>();
        }

        public int Idtipoasignatura { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Asignatura> Asignatura { get; set; }
    }
}
