using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkIO.Models
{
    public class Documentos: BaseEntity
    {

        [Required(ErrorMessage = "Nombre is required.")]
        [Display(Prompt = "Nombre del documento")]
        public string NombreDocumento { get; set; }

        // Definimos nuestras referencias
        [Display(Name = "Candidato")]
        [Required(ErrorMessage = "Candidato is required.")]
        [ForeignKey("Candidato")]
        public int CandidatoID { get; set; }
    }
}
