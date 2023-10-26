using Microsoft.EntityFrameworkCore;

public class ECommerceDbContext:DbContext{
public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options):base(options)
{
    
}
public DbSet<Student>? Students { get; set; }
public DbSet<Product> Products { get; set; }
public DbSet<Material> Materials{get;set;}
public DbSet<Calisan> Calisans{get;set;}
public DbSet<CalisanAdresi> CalisanAdresis{get;set;}

}