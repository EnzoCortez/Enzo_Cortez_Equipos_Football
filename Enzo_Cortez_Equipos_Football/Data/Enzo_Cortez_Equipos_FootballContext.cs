using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Enzo_Cortez_Equipos_Football.Models;

namespace Enzo_Cortez_Equipos_Football.Data
{
    public class Enzo_Cortez_Equipos_FootballContext : DbContext
    {
        public Enzo_Cortez_Equipos_FootballContext (DbContextOptions<Enzo_Cortez_Equipos_FootballContext> options)
            : base(options)
        {
        }

        public DbSet<Enzo_Cortez_Equipos_Football.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<Enzo_Cortez_Equipos_Football.Models.Estadio> Estadio { get; set; } = default!;
        public DbSet<Enzo_Cortez_Equipos_Football.Models.Jugador> Jugador { get; set; } = default!;
    }
}
