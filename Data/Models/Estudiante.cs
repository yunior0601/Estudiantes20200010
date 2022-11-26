using System.ComponentModel.DataAnnotations;

namespace Estudiantes20200010.Data.Models;

public class Estudiante
{
    [Key]
    public int EstudiantesID { get; set; }
    public string Nombre { get; set; } = null!;
    public string Apellido { get; set; } = null!;
    public string Matricula { get; set; } = null!;

     public DateTime FechadeNacimiento{ get; set; }
    public string Carrera{ get; set; } = null!;

}