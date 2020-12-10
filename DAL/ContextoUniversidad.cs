using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using CesdeUniversity.Models;

namespace CesdeUniversity.DAL
{
    public class ContextoUniversidad : DbContext
    {
        public ContextoUniversidad() : base("ContextoUniversidad")
        {
        }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Curso> Cursos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}