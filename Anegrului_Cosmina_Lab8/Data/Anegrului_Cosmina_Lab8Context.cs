using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Anegrului_Cosmina_Lab8.Models;

namespace Anegrului_Cosmina_Lab8.Data
{
    public class Anegrului_Cosmina_Lab8Context : DbContext
    {
        public Anegrului_Cosmina_Lab8Context (DbContextOptions<Anegrului_Cosmina_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Anegrului_Cosmina_Lab8.Models.Book> Book { get; set; }

        public DbSet<Anegrului_Cosmina_Lab8.Models.Publisher> Publisher { get; set; }
    }
}
