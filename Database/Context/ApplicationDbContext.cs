using Domain;
using Microsoft.EntityFrameworkCore;

namespace Database.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    // Mapeia a entidade Product para a tabela Products
    public DbSet<Product> Products { get; set; }

    // Permite configurar o modelo com fluentAPI
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Aplica as configs nas entidades
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }

    internal void UpdateAsync<T>(T entity) where T : class
    {
        throw new NotImplementedException();
    }
}
