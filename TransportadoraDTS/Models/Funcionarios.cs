using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Transportadora.Models
{
    public class Funcionarios
    {
        ///<summary>
        ///Id do Funcionario
        /// </summary>
        [Key]
        public int Id { get; set; }
        ///<summary>
        ///Nome do Funcionario
        /// </summary>
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatorio")]
        public string Nome { get; set; }
        ///<summary>
        ///Nif do Funcionario
        /// </summary>
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatorio")]
        public string Nif { get; set; }
        ///<summary>
        ///Telefone do Funcionario
        /// </summary>
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatorio")]
        public string Telefone { get; set; }
        ///<summary>
        ///Morada do Funcionario
        /// </summary>
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatorio")]
        public string Morada { get; set; }
        ///<summary>
        ///Codigo Postal do Funcionario
        /// </summary>
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatorio")]
        public string CodPostal { get; set; }
        ///<summary>
        ///Email do Funcionario
        /// </summary>
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatorio")]
        [EmailAddress]
        public string Email { get; set; }
        ///<summary>
        ///Função ou Cargo do Funcionario
        /// </summary>
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatorio")]
        public string Funcao { get; set; }
    }
}