
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Esquema.Model
{
    public class Persona
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]

        public String? DatosPerson { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]


        public String? CedulaPerson { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]

        public DateTime? FechaPerson { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]

        public String? SexoPerson { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]

        public String? DireccionPerson { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]

        public Boolean estado { get; set; }

        public int AdoptanteID { get; set; }

        public Adoptante? Adoptante { get; set; }
    }

    public class Adoptante
    {
        public int Id { get; set; }

        public int Id_Persona { get; set; }

        public int Id_Entrega { get; set; }

        public int Id_Mascota { get; set; }

        public int Id_Operacion { get; set; }

        public String? ReferenciaAdoptante { get; set; }

        public String? LugarEntrega { get; set; }

        public DateTime? FechaEntrega { get; set; }

        public Boolean estado { get; set; }

    }
}
