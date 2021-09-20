using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LyzerClass.Web.Data
{
    public partial class Docente
    {
        public Docente()
        {
            Asignatura = new HashSet<Asignatura>();
        }

        public int Iddocente { get; set; }
        public int Idcolegio { get; set; }
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public DateTime Fechanacimiento { get; set; }

        public virtual Colegio IdcolegioNavigation { get; set; }
        public virtual ICollection<Asignatura> Asignatura { get; set; }
    }
}
