using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MecanicaWeb.Models
{
    public class MecanicaWebContext : DbContext
    {
        public MecanicaWebContext (DbContextOptions<MecanicaWebContext> options)
            : base(options)
        {
        }
        public DbSet<MecanicaWeb.Models.Agenda> Agenda { get; set; }
        public DbSet<MecanicaWeb.Models.Atendimento> Atendimento { get; set; }
        public DbSet<MecanicaWeb.Models.Cliente> Cliente { get; set; }
        public DbSet<MecanicaWeb.Models.Profissional> Profissional { get; set; }

    }
}
