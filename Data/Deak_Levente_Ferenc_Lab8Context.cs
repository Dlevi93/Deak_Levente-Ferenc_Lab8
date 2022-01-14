using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Deak_Levente_Ferenc_Lab8.Models;

namespace Deak_Levente_Ferenc_Lab8.Data
{
    public class Deak_Levente_Ferenc_Lab8Context : DbContext
    {
        public Deak_Levente_Ferenc_Lab8Context (DbContextOptions<Deak_Levente_Ferenc_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Deak_Levente_Ferenc_Lab8.Models.Book> Book { get; set; }

        public DbSet<Deak_Levente_Ferenc_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Deak_Levente_Ferenc_Lab8.Models.Category> Category { get; set; }
    }
}
