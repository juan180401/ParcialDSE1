using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CG171105_CR150934_desafio01.Models
{
    public class CuentaBancaria
    {
        [Key]
        public int idcuentabanc { get; set; }

        // Clave Externa
        [ForeignKey("Cliente")]
        public int idcliente { get; set; }

        // Objeto que representa la clave externa.
        [ForeignKey("idcliente")]
        public virtual Cliente Cliente { get; set; }


        [StringLength(300)]
        [Required(ErrorMessage = "Campo Moneda requerido")]
        public string Moneda { get; set; }

        // Clave Externa
        [ForeignKey("TipoCuentaBancaria")]
        public int Tipo { get; set; }

        // Objeto que representa la clave externa.
        [ForeignKey("idCuentaBancaria")]
        public virtual TipoCuentaBancaria TipoCuentaBancaria { get; set; }

    }
}