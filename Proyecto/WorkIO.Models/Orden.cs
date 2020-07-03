using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkIO.Models
{
    public class Orden: BaseEntity
    {
        [Required(ErrorMessage = "Nombre is required")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El tipo de contrato is required")]
        [Display(Name = "Tipo de contrato")]
        public string TipoContrato { get; set; }

        [Required(ErrorMessage = "Fecha limite is required")]
        [Display(Name = "Fecha limite")]
        public string FechaLimite { get; set; }




        public int EmpresaID { get; set; }
        public Empresa Empresa { get; set; }

       
        public ICollection<Candidato> Candidatos { get; set; }
    }
}
