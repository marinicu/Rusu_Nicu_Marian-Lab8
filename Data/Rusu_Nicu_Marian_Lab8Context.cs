using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rusu_Nicu_Marian_Lab8.Models;

namespace Rusu_Nicu_Marian_Lab8.Data
{
    public class Rusu_Nicu_Marian_Lab8Context : DbContext
    {
        public Rusu_Nicu_Marian_Lab8Context (DbContextOptions<Rusu_Nicu_Marian_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Rusu_Nicu_Marian_Lab8.Models.Book> Book { get; set; }

        public DbSet<Rusu_Nicu_Marian_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Rusu_Nicu_Marian_Lab8.Models.Category> Category { get; set; }
    }
}
