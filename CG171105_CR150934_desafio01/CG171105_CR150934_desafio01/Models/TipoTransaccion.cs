using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CG171105_CR150934_desafio01.Models
{
    public class TipoTransaccion
    {
        [Key]
        public int idtransaccion { get; set; }

        [StringLength(300)]
        [Required(ErrorMessage = "Campo Tipo Transaccion requerido")]
        public string Tipo_Transaccion { get; set; }

    }
}