using Domain.Entities;
using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;

namespace Database.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    // Mapeia a entidade Product para a tabela Products
    public DbSet<Product> Products { get; set; }

    // Configura o modelo com fluentAPI
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configurar a classe Notification como uma entidade sem chave primária
        modelBuilder.Ignore<Notification>();

        // Aplica as configs nas entidades
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}
