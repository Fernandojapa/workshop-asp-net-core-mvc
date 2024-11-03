using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FazendaUrbana.Models
{
    public class FazendaUrbanaContext : DbContext
    {
        public FazendaUrbanaContext (DbContextOptions<FazendaUrbanaContext> options)
            : base(options)
        {
        }

        public DbSet<FazendaUrbana.Models.Department> Department { get; set; }
    }
}
