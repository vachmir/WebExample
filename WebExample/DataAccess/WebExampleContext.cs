using Microsoft.EntityFrameworkCore;
using WebExample.Models;

namespace WebExample.DataAccess
{
    public partial class WebExampleContext:DbContext
    {
        public WebExampleContext()
        {

        }
        public WebExampleContext(DbContextOptions<WebExampleContext> options) 
            : base(options)
        {
        }
        //Classes used for Code First approach
        public DbSet<Human> Humans { get; set; } = null!; 
        public DbSet<Car> Cars { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=VACHMIRLAPTOP;Initial Catalog=DeleteMe; Integrated Security=True;");
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
