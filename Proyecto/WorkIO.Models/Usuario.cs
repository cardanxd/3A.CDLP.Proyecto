using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkIO.Models
{
    public class Usuario:BaseEntity
    {
        [Required]
        [MinLength(6, ErrorMessage ="User Name should at contain 4 character")]
        public string UserName { get; set; }
        [Required]
        [MinLength(6, ErrorMessage = "Password should at contain 3 character")]
        public string Password { get; set; }

        // Definimos nuestras referencias
        [Display(Name = "Empresa")]
        [ForeignKey("Empresa")]
        public int EmpresaID { get; set; }
        public Empresa Empresa { get; set; }

        [Display(Name = "Candidato")]
        [ForeignKey("Candidato")]
        public int CandidatoID { get; set; }
        public Candidato Candidato { get; set; }

        [Display(Name = "Orden")]
        [ForeignKey("Orden")]
        public int OrdenID { get; set; }
        public Orden Orden { get; set; }

        //Navegavilidad
        public Persona Persona { get; set; }
    }
}
