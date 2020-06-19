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
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Candidato> Candidato { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Persona> Persona { get; set; }


    }
}
