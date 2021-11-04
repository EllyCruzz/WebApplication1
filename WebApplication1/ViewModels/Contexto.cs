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
        private readonly DbContextOptions _options;

        public DbSet<DashboardViewModel> Dashboard { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            // Database.EnsureCreated();
            _options = options;
        }
    }
}