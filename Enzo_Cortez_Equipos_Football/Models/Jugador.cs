using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Enzo_Cortez_Equipos_Football.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }  // Identificador único del jugador
        public string Nombre { get; set; }  // Nombre completo del jugador
        public string Posicion { get; set; }  // Posición en el campo (ej: delantero, defensa)
        public int Edad { get; set; }  // Edad del jugador

        // Relación con Equipo
        
        public int EquipoId { get; set; }
        public Equipo? Equipo { get; set; }  // Equipo al que pertenece el jugador
    }

}
