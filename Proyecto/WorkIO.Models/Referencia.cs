using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkIO.Models
{
    public class Referencia: BaseEntity
    {
        [Display(Prompt = "Nombre de la empresa")]
        public string NomEmpresa { get; set; }
        [Display(Name = "Telefono de la empresa", Prompt = "10 digitos")]
        public string Telefono { get; set; }
        [Display(Prompt = "Direccion")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Nombre del jefe is required")]
        [Display(Prompt = "Nombre del jefe")]
        public string NomJefe { get; set; }
        [Display(Prompt = "Puesto del jefe")]
        public string PuestoJefe { get; set; }
        [Required(ErrorMessage = "Nombre del informante is required")]
        [Display(Prompt = "Nombre del informante")]
        public string NomInformante { get; set; }
        [Display(Prompt = "Puesto del informante")]
        public string PuestoInformante {get; set; }
        [Display(Prompt = "Puesto del candidato")]
        public string PuestoCandidato { get; set; }
        [Display(Name = "Sueldo mensual", Prompt = "Valores reales")]
        public int SueldoMensual { get; set; }
        [Display(Prompt = "Inicio de labores")]
        public string InicioLabores { get; set; }
        [Display(Prompt = "Fin de labores")]
        public string FinLabores{ get; set; }
        [Required(ErrorMessage = "Motivos is required")]
        [Display(Prompt = "Motivos")]
        public string Motivo { get; set; }
        [Display(Prompt = "Contrato")]
        public string Contrato { get; set; }
        [Display(Prompt = "Funcion del puesto")]
        public string Funcion { get; set; }

        // Agregamos la navegabilidad 
        public int CandidatoID { get; set; }
        public Candidato Candidato { get; set; }
    }
}
