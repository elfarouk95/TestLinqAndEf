using Microsoft.EntityFrameworkCore;


namespace WinFormsApp11
{
    public class Repo : DbContext
    {
        protected  override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Test.db");
        }


        public DbSet<Student> students { get; set; }
        public DbSet<Plaing> plaings { get; set; }
    }
}
