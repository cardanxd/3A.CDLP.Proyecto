using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkIO.Models
{
    public class Persona:BaseEntity
    {
        [Required]
        [MinLength(3, ErrorMessage ="Nombre should containt at least 3 character")]
        public string Nombre { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Nombre should containt at least 2 character")]
        public string Apellido { get; set; }

        public string Telefono { get; set; }
        public string Email { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

    }
}
