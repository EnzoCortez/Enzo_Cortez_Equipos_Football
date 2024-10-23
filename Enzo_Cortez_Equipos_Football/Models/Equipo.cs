﻿using System.ComponentModel.DataAnnotations;

namespace Enzo_Cortez_Equipos_Football.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }  // Identificador único del equipo
        public string Nombre { get; set; }  // Nombre del equipo
        public string Ciudad { get; set; }  // Ciudad donde pertenece el equipo
        public int Titulos { get; set; }  // Cantidad de títulos ganados
        public bool AceptaExtranjeros { get; set; }  // Si acepta jugadores extranjeros

        // Relación con Jugadores
        public ICollection<Jugador> Jugadores { get; set; }
    }

}