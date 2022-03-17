using Microsoft.EntityFrameworkCore;
using ProEventos.API.models;

namespace ProEventos.API.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Evento> Eventos { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options){ }
    }
}