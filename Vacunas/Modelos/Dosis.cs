using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Vacunas.Modelos
{
    public partial class Dosis
    {
        public int Id { get; set; }
        public string CedulaPersona { get; set; }
        public int VacunaId { get; set; }
        public DateTime Fecha { get; set; }
        public int ProvinciaId { get; set; }
    }
}
