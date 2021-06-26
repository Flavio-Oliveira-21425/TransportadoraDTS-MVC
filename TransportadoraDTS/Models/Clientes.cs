using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Transportadora.Models
{
    public class Clientes
    {
        ///<summary>
        ///Id dos Cliente
        /// </summary>
        [Key]
        public int Id { get; set; }

        ///<summary>
        ///Nome do Cliente
        /// </summary>
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatorio")]
        public string Nome { get; set; }

        ///<summary>
        ///Nif do Cliente
        /// </summary>
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatorio")]
        public string NIF { get; set; }

        ///<summary>
        ///Telefone do Cliente
        /// </summary>
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatorio")]
        public string Telefone { get; set; }

        ///<summary>
        ///Morada do Cliente
        /// </summary>
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatorio")]
        public string Morada { get; set; }

        ///<summary>
        ///Codigo Postal do Cliente
        /// </summary>
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatorio")]
        public string CodPostal { get; set; }

        ///<summary>
        ///Email do Cliente
        /// </summary>
        [Required (ErrorMessage ="Este campo é de preenchimento obrigatorio")]
        [EmailAddress]
        public string Email { get; set; }

        ///<summary>
        ///Lista de Encomendas do Cliente
        /// </summary>
        [Display(Name = "Lista de Encomendas")]
        public ICollection <Encomendas> ListaEncomendas { get; set; }
    }
}