using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estudiantes20200010.Data.Models;

public class Carrera
{
    public Carrera()
    {

    }
    [Key]
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;
}