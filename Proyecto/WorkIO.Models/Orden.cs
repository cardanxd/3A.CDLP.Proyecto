using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkIO.Models
{
    public class Orden: BaseEntity
    {
        public int ID { get; set; }

        // Definimos nuestras referencias
        [Display(Name = "Empresa")]
        [Required(ErrorMessage = "Empresa is required.")]
        [ForeignKey("Empresa")]
        public string NomEmpresa { get; set; }
        public Empresa empresa { get; set; }

        [Display(Name = "Candidato")]
        [Required(ErrorMessage = "Candidato is required.")]
        [ForeignKey("Candidato")]
        public string Nombre { get; set; }
        public Candidato Candidato { get; set; }

    }
}
