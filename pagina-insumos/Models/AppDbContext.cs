﻿using Microsoft.EntityFrameworkCore;

namespace pagina_insumos.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Insumo> Insumos { get; set; }
    }
}
