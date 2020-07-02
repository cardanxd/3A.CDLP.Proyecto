using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkIO.Models
{
    public class Candidato: BaseEntity
    {
        
        [Required(ErrorMessage = "Nombre is required.")]
        [Display(Prompt = "Nombre del candidato")]
        public string Nombre { get; set; }

        [Display(Name = "Sexo", Prompt = "Escoga una opcion")]
        public string Sexo { get; set; }

        [Display(Prompt = "Fecha de nacimiento")]
        public DateTime? FNacimiento { get; set; }

        [Display(Prompt = "Lugar de nacimiento")]
        
        public string LNacimiento { get; set; }
        [Display(Prompt = "Edad")]
        public int Edad { get; set; }

        [Display(Prompt = "Estado civil")]
        public string ECivil { get; set; }

        [Display(Prompt = "Nacionalidad")]
        public string Nacionalidad { get; set; }


        public ICollection<Documentos> Documentos { get; set; }

        public ICollection<Referencia> Referencias { get; set; }

        
        public int OrdenID { get; set; }
        public Orden Orden { get; set; }

    }
}
