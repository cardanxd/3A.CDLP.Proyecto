using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkIO.Models
{
    public class Orden: BaseEntity
    {
        public int EmpresaID { get; set; }
        public Empresa Empresa { get; set; }

       
        public ICollection<Candidato> Candidatos { get; set; }
    }
}
