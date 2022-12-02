using Estudiantes20200010.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Estudiantes.Data.Context;
 public class EstudiantesDbContext:DbContext,IEstudiantesDbContext
{
    public EstudiantesDbContext(DbContextOptions options):base(options)
    {
        
    }
    public virtual DbSet<Estudiante> Estudiantes { get; set; } = null!;
    public virtual DbSet<Carrera> Carreras { get; set; } = null!;
    public override int SaveChanges()
    {
        return base.SaveChanges();
    }
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }
}

public interface IEstudiantesDbContext
{
    public DbSet<Estudiante> Estudiantes {get; set;}
    public DbSet<Carrera> Carreras {get; set;}

    public int SaveChanges();
    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}