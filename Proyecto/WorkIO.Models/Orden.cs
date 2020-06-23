using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkIO.Models
{
    public class Orden: BaseEntity
    {

        // Definimos nuestras referencias
        [Display(Name = "Empresa")]
        [Required(ErrorMessage = "Empresa is required.")]
        [ForeignKey("Empresa")]
        public int EmpresaID { get; set; }
        public Empresa Empresa { get; set; }

        [Display(Name = "Candidato")]
        [Required(ErrorMessage = "Candidato is required.")]
        [ForeignKey("Candidato")]
        public int CandidatoID { get; set; }
        public Candidato Candidato { get; set; }

        //Navegavilidad
    }
}
