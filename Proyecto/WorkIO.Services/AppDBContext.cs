using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using WorkIO.Models;

namespace WorkIO.Services
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Documentos> Documentos { get; set; }
        public DbSet<Referencia> Referencias { get; set; }
        public DbSet<Orden> Ordens { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public object Ordenes { get; set; }
    }
}
