﻿using Microsoft.EntityFrameworkCore;

namespace mf_dev_backend.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Veiculo> Veiculos { get; set; }

        public DbSet<Consumo> Consumos { get; set; }

    }
}
