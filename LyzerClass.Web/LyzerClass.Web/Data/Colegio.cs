using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LyzerClass.Web.Data
{
    public partial class Colegio
    {
        public Colegio()
        {
            Curso = new HashSet<Curso>();
            Director = new HashSet<Director>();
            Docente = new HashSet<Docente>();
        }

        public int Idcolegio { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        public virtual ICollection<Curso> Curso { get; set; }
        public virtual ICollection<Director> Director { get; set; }
        public virtual ICollection<Docente> Docente { get; set; }
    }
}
