using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CG171105_CR150934_desafio01.Models
{
    public class Cliente
    {

        [Key]
        public int idcliente { get; set; }

        [StringLength(300)]
        [Required(ErrorMessage = "Campo Nombres requerido")]
        public string Nombres { get; set; }



        [StringLength(200)]
        [Required(ErrorMessage = "Campo Primer Apellido requerido")]
        public string Primer_Apellido { get; set; }



        [StringLength(200)]
        [Required(ErrorMessage = "Campo Segundo Apellido requerido")]
        public string Segundo_Apellido { get; set; }

        [Required(ErrorMessage = "Campo Telefono requerido")]
        public int Telefono { get; set; }


        [StringLength(250)]
        [EmailAddress(ErrorMessage = "El correo no cumple con el formato correcto")]
        public string Correo { get; set; }

    }
}