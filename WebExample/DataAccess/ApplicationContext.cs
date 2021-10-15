using Microsoft.EntityFrameworkCore;
using WebExample.Models;

namespace WebExample.DataAccess
{
    public class ApplicationContext : DbContext 
    {
        public ApplicationContext() : base()
        {

        }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }
        //Classes used for Code First approach
        public DbSet<Human> Humans { get; set; } = null!;
        public DbSet<Car> Cars { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=VACHMIRLAPTOP;Initial Catalog=HumanCar; Integrated Security=True;");
        }
      //  partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
