using GenericRepository.Entities;
using GenericRepository.Services;
using Microsoft.EntityFrameworkCore;

namespace GenericRepository.Contexts
{
    public class AppDbContext
    {
        public DbSet <Student> Students { get; set; }
        public DbSet <Teacher> Teachers { get; set; }
        public DbSet <Group> Groups { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
}
