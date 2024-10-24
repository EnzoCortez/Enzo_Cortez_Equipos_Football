using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Enzo_Cortez_Equipos_Football.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }  // Identificador único del equipo
        [MaxLength(300)]
        public string Nombre { get; set; }  // Nombre del equipo
        public string Ciudad { get; set; }  // Ciudad donde pertenece el equipo

        [Required]
        public int Titulos { get; set; }  // Cantidad de títulos ganados
        public bool AceptaExtranjeros { get; set; }  // Si acepta jugadores extranjeros

        // Relación con Jugadores
        
        public ICollection<Jugador>? Jugadores { get; set; }
        public Estadio? Estadio { get; set; }

        [ForeignKey("Estadio")]
        public int IdEstadio { get; set; }
    }

}
