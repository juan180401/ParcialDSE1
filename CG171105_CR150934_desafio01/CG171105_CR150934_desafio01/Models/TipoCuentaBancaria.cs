using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CG171105_CR150934_desafio01.Models
{
    public class TipoCuentaBancaria
    {
        [Key]
        public int idcuentabancaria { get; set; }

        [StringLength(300)]
        [Required(ErrorMessage = "Campo Tipo cuenta bancaria requerido")]
        public string Tipo_Cuenta_Bancaria { get; set; }

        [StringLength(5)]
        [Required(ErrorMessage = "Si: activo  No: No activo, Campo Activo requerido")]
        public string Activo { get; set; }

    }
}