using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkIO.Models
{
    public class Orden: BaseEntity
    {
        [Display(Name = "Id")]
        public int OrdenID { get; set; }

        // Definimos nuestras referencias
        [Display(Name = "Empresa y Candidato")]
        [Required(ErrorMessage = "Empresa y Candidato is required.")]
        [ForeignKey("Empresa y Candidato")]
        public int EmpresaID { get; set; }
        public Empresa Empresa { get; set; }
        public int CandidatoID { get; set; }
        public Candidato Candidato { get; set; }

    }
}
