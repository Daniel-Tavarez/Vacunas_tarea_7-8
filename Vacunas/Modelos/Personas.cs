using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Vacunas.Modelos
{
    public partial class Personas
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int ProvinciaId { get; set; }
    }
}
