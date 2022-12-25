using Microsoft.EntityFrameworkCore;

public class Context:DbContext
{

    public DbSet<Tbl_Teacher> tbl_Teachers { get; set; }
    public DbSet<Tbl_Student> tbl_Students { get; set; }
    public DbSet<Tbl_Personel> tbl_Personels { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=School;Trusted_Connection=True;");
    }
    
    
    
}