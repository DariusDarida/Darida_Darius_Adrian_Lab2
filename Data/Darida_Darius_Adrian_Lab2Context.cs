using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Darida_Darius_Adrian_Lab2.Models;

namespace Darida_Darius_Adrian_Lab2.Data
{
    public class Darida_Darius_Adrian_Lab2Context : DbContext
    {
        public Darida_Darius_Adrian_Lab2Context (DbContextOptions<Darida_Darius_Adrian_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Darida_Darius_Adrian_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Darida_Darius_Adrian_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
