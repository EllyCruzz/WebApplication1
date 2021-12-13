using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using WebApplication1.Migrations.ContextoMigrations;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Models
{
    public class Contexto : DbContext
    {
        private readonly DbContextOptions _options;

        
        public DbSet<ClienteModel> Cliente { get; set; }
        public DbSet<SuporteModel> Suporte { get; set; }
        public DbSet<AgendaModel> Agenda { get; set; }


        //   public DbSet<DashboardViewModel> Dashboard { get; set; }

//        //INSERIR DADO NAS TABELAS
//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<ClienteModel>().HasData(
//                new ClienteModel
//                {

//                    IdCliente = 1,
//                    Nome = "Agatha Christie",
//                    Endereco = "England",
//                    Local = "FABRICA"
//                }
//            );

//            modelBuilder.Entity<SuporteModel>().HasData(

//            new SuporteModel
//            {
//                IdSuporte = 1,
//                Nome = "Suporte 1"
//            }
//            );
//            modelBuilder.Entity<SuporteModel>().HasKey(X => X.IdSuporte);
//            modelBuilder.Entity<Agenda>().HasData(
//                 new
//                 {
//                     IdAgenda = 1,
//                     IdCliente = 1,
//                     ClienteIdCliente = 1,
//                     IdSuporte = 1,
//                     SuporteIdCliente = 1,
//                     Horario = 1,
//                     Data = "2021-12-10",
//                     Status = 0
//                 }


//);
//        }
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
         //    Database.EnsureCreated();
            _options = options;
        }

        public Contexto()
        {
        }

        public IEnumerable<AgendaModel> GetAll()
        {


            using (var context = new Contexto())
            {
                return context.Agenda;
            }
        }

        //consertar
        public IEnumerable<DashboardViewModel> GetViewModels()
        {
            using (var context = new Contexto())
            {
                return (IEnumerable<DashboardViewModel>)context.Agenda;
            }
        }
    }
}