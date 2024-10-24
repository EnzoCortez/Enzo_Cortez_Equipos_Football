using System.ComponentModel.DataAnnotations;

namespace Enzo_Cortez_Equipos_Football.Models
{
    public class Estadio
    {
        [Key]
        public int Id { get; set; }  // Identificador único del estadio
        public string Direccion { get; set; }  // Dirección física del estadio
        public string Ciudad { get; set; }  // Ciudad donde se encuentra el estadio
        [Range(0,4400)]
        public int Capacidad { get; set; }  // Capacidad máxima de espectadores

        

    }

}
