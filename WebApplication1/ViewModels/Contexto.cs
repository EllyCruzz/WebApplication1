using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    public class Contexto : DbContext
    {
        private readonly DbContextOptions _options;

        public DbSet<ClienteModel> Cliente { get; set; }
        public DbSet<SuporteModel> Suporte { get; set; }
        public DbSet<AgendaModel> Agenda { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            // Database.EnsureCreated();
            _options = options;
        }

      public IEnumerable<AgendaModel> GetAll()
       {
           using (var context = new Contexto())
            {
              
               return context.Agenda;
            }
        }

        public Contexto()
        {
        }
    }
}