using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkIO.Models
{
    public class Empresa
    {
        [Required(ErrorMessage = "Nombre de la empresa is required")]

        [Display(Prompt = "Nombre de la empresa")]

        public string NomEmpresa { get; set; }
        [Required(ErrorMessage = "Nombre del contacto is required")]

        [Display(Prompt = "Nombre del contacto")]
        public string NomContacto { get; set; }
        [Required(ErrorMessage = "Numero del contacto is required")]

        [Display(Name = "Numero del contacto", Prompt = "10 digitos")]

        public string NumContacto { get; set; }
        [Required(ErrorMessage = "Email is required")]

        [Display(Prompt = "Email")]

        public string Email { get; set; }
        [Display(Prompt = "Direccion")]

        public string Direccion { get; set; }

        // Agregamos la navegabilidad
        public ICollection<Candidato> Candidato { get; set; }
        public ICollection<Orden> Orden { get; set; }
    }
}
