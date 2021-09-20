using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LyzerClass.Web.Data
{
    public partial class Video
    {
        public Video()
        {
            Encuesta = new HashSet<Encuesta>();
        }

        public int Idvideo { get; set; }
        public int Idhorarioasignatura { get; set; }
        public int? Idencuesta { get; set; }
        public int? Tonalidad { get; set; }
        public int? Volumen { get; set; }
        public int? Velocidad { get; set; }
        public int? Introduccion { get; set; }
        public int? Dudas { get; set; }
        public int? Desarrollo { get; set; }
        public int? Conclusion { get; set; }
        public int? Tiempo { get; set; }
        public int? Tiemposinsilencios { get; set; }
        public string Comentariodirector { get; set; }
        public string Comentariodocente { get; set; }

        public virtual Encuesta IdencuestaNavigation { get; set; }
        public virtual HorarioAsignatura IdhorarioasignaturaNavigation { get; set; }
        public virtual ICollection<Encuesta> Encuesta { get; set; }
    }
}
