using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CG171105_CR150934_desafio01.Models
{
    public class Transacciones
    {
        [Key]
        public int idtransaccion { get; set; }

        // Clave Externa
        [ForeignKey("CuentaBancaria")]
        public int idCuentaBancaria { get; set; }

        // Objeto que representa la clave externa.
        [ForeignKey("idCuentaBancaria")]
        public virtual CuentaBancaria CuentaBancaria { get; set; }


        // Clave Externa
        [ForeignKey("TipoTransaccion")]
        public int Tipo_Transaccion { get; set; }

        // Objeto que representa la clave externa.
        [ForeignKey("idtransaccion")]
        public virtual TipoTransaccion TipoTransaccion { get; set; }


      
        [Required(ErrorMessage = "Campo Monto requerido")]
        public float Monto { get; set; }

        [StringLength(300)]
        [Required(ErrorMessage = "Campo Estado requerido")]
        public string Estado { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaTransaccion { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaAplicacion { get; set; }
    }
}