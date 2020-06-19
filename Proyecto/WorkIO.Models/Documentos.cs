using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkIO.Models
{
    public class Documentos: BaseEntity
    {
        [Display(Prompt = "Visa")]

        public Boolean Visa { get; set; }
        [Display(Prompt = "Cartilla")]

        public Boolean Cartilla { get; set; }
        [Display(Prompt = "Curp")]

        public string Curp { get; set; }
        [Display(Prompt = "Imss")]

        public string Imss { get; set; }
        [Display(Prompt = "RFC")]

        public string Rfc { get; set; }
        [Display(Prompt = "Antecedentes")]

        public Boolean Antecedentes { get; set; }
        [Display(Prompt = "Pasaporte")]

        public Boolean Pasaporte { get; set; }
        [Display(Prompt = "Licencia")]

        public Boolean Licencia { get; set; }
        [Display(Prompt = "INE")]

        public Boolean Ine { get; set; }

        // Definimos nuestras referencias
        [Display(Name = "Candidato")]
        [Required(ErrorMessage = "Candidato is required.")]
        [ForeignKey("Candidato")]
        public string Nombre { get; set; }
        public Candidato Candidato { get; set; }
    }
}
