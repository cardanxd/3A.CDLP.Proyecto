using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkIO.Models
{
    public class Documentos: BaseEntity
    {
        [Display(Name = "Id")]
        public int DocumentoID { get; set; }
        [Display(Prompt = "Visa")]
        public bool? Visa { get; set; }

        [Display(Prompt = "Cartilla")]
        public bool? Cartilla { get; set; }

        [Display(Prompt = "Curp")]
        public string Curp { get; set; }

        [Display(Prompt = "Imss")]
        public string Imss { get; set; }

        [Display(Prompt = "RFC")]
        public string Rfc { get; set; }

        [Display(Prompt = "Antecedentes")]
        public bool? Antecedentes { get; set; }

        [Display(Prompt = "Pasaporte")]
        public bool? Pasaporte { get; set; }

        [Display(Prompt = "Licencia")]
        public bool? Licencia { get; set; }

        [Display(Prompt = "INE")]
        public bool? Ine { get; set; }

        // Definimos nuestras referencias
        [Display(Name = "Candidato")]
        [Required(ErrorMessage = "Candidato is required.")]
        [ForeignKey("Candidato")]
        public int CandidatoID { get; set; }
        public Candidato Candidato { get; set; }
    }
}
