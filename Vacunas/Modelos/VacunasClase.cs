using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Vacunas.Modelos
{
    public partial class VacunasClase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int DosisNecesarias { get; set; }
        public int DiasEntreDosis { get; set; }
    }
}
