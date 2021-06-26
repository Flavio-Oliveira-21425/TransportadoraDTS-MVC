using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Transportadora.Models
{
    public class Encomendas
    {
        ///<summary>
        ///Id da Encomenda
        /// </summary>
        [Key] 
        public int Id { get; set; }

        ///<summary>
        ///Nome da Encomenda
        /// </summary>
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatorio")]
        public string Nome { get; set; }

        ///<summary>
        ///Tipo da Encomenda
        /// </summary>
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatorio")]
        public string Tipo { get; set; }

        ///<summary>
        ///Descrição da Encomenda
        /// </summary>
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatorio")]
        public string Descricao { get; set; }

        ///<summary>
        ///Morada da Encomenda
        /// </summary>
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatorio")]
        public string Morada { get; set; }

        ///<summary>
        ///Codigo Postal da Encomenda
        /// </summary>
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatorio")]
        public string CodPostal { get; set; }

        ///<summary>
        ///Data de Envio da Encomenda
        /// </summary>
        public DateTime DataEnvio { get; set; }

        ///<summary>
        ///Data de Entrega da Encomenda
        /// </summary>
        public DateTime DataEntrega { get; set; }

        ///<summary>
        ///Estado da Encomenda
        /// </summary>
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatorio")]
        public string Estado { get; set; }

        ///<summary>
        ///Altura da Encomenda
        /// </summary>
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatorio")]
        public float Altura { get; set; }

        ///<summary>
        ///Largura da Encomenda
        /// </summary>
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatorio")]
        public float Largura { get; set; }

        ///<summary>
        ///Comprimento da Encomenda
        /// </summary>
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatorio")]
        public float Comprimento { get; set; }

        ///<summary>
        ///Peso da Encomenda
        /// </summary>
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatorio")]
        public Decimal Peso { get; set; }

        ///<summary>
        ///Chave estrangeira do Id do Cliente
        /// </summary>
        [ForeignKey(nameof(Cliente))]
        public int IdCliente { get; set; }
        public Clientes Cliente { get; set; }
    }
}