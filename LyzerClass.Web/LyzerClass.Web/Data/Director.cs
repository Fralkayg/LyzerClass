using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LyzerClass.Web.Data
{
    public partial class Director
    {
        public int Iddirector { get; set; }
        public int Idcolegio { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }

        public virtual Colegio IdcolegioNavigation { get; set; }
    }
}
