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

        [Required(ErrorMessage = "Sexo is required.")]
        [Display(Name = "Sexo", Prompt = "Escoga una opcion")]
        public string Sexo { get; set; }

        [Display(Prompt = "Fecha de nacimiento")]
        public string FNacimiento { get; set; }

        [Display(Prompt = "Lugar de nacimiento")]
        public string LNacimiento { get; set; }

        [Required(ErrorMessage = "Edad is required.")]
        [Display(Prompt = "Edad")]
        public int Edad { get; set; }

        [Display(Prompt = "Estado civil")]
        public string ECivil { get; set; }

        [Display(Prompt = "Nacionalidad")]
        public string Nacionalidad { get; set; }

        // Definimos nuestras referencias
        [Display(Name = "Empresa")]
        [Required(ErrorMessage = "Empresa is required.")]
        [ForeignKey("Empresa")]
        public int EmpresaID { get; set; }
        public Empresa Empresa { get; set; }

        // Agregamos la navegabilidad 
        public ICollection<Orden> Ordens { get; set; }
        public Documentos Documento { get; set; }

        public Referencia Referencia { get; set; }

    }
}
