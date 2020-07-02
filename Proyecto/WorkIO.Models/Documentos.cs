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
        public string Nombre { get; set; }
 
        public int CandidatoID { get; set; }
        public Candidato Candidato { get; set; }
    }
}
