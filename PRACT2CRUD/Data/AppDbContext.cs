using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PRACT2CRUD.Models;

namespace PRACT2CRUD.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Asignaturas> Asignaturas { get; set; } = default!;
        public DbSet<PRACT2CRUD.Models.Estudiantes> Estudiantes { get; set; } = default!;
    }
}
