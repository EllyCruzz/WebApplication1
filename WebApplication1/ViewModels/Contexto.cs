using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace WebApplication1.ViewModels
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
         
            Database.EnsureCreated();
        }

        public DbSet<DashboardViewModel> Dashboard { get; set; }
    }


}