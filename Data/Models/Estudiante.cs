using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estudiantes20200010.Data.Models;

public class Estudiante
{
    [Key]
    public int EstudiantesID { get; set; }
    public string Nombre { get; set; } = null!;
    public string Apellido { get; set; } = null!;
    public string Matricula { get; set; } = null!;
    public DateTime FechadeNacimiento   { get; set; }
    public int CarreraId { get; set; }
    public virtual Carrera? Carrera { get; set; }
}