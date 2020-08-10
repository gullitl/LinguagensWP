using Asp.LinguagensWP.Models;
using Microsoft.EntityFrameworkCore;

namespace LinguagensWP.DataAccess {
    public class AppDbContext : DbContext {
        public virtual DbSet<Employee> Employees { get; set; }

        public AppDbContext(DbContextOptions options) : base(options) {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            base.OnConfiguring(options);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
        }

    }
}
