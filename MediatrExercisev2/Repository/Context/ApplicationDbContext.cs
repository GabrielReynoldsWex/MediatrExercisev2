using MediatrExercisev2.Domain.Entities.Customer;
using Microsoft.EntityFrameworkCore;

namespace MediatrExercisev2.Repository.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<CustomerClass> Customers { get; set; }
    }
}