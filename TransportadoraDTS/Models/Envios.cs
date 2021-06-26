using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Transportadora.Models
{
    public class Envios
    {
        ///<summary>
        ///Id do Envio
        /// </summary>
        [Key]
        public int Id { get; set; }
        ///<summary>
        ///Custo do Envio
        /// </summary>
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatorio")]
        public Decimal Custo { get; set; }
        ///<summary>
        ///Data Prevista da entrega do  do Envio
        /// </summary>
        public DateTime DataPretvista { get; set; }

        ///<summary>
        ///Chave estrangeira do Id da Encomenda
        /// </summary>
        [ForeignKey(nameof(Encomenda))]
        public int IdEncomenda { get; set; }
        public Encomendas Encomenda { get; set; }

        ///<summary>
        ///Chave estrangeira do Id do Cliente
        /// </summary>
        [ForeignKey(nameof(Cliente))]
        public int IdCliente { get; set; }
        public Clientes Cliente { get; set; }

        ///<summary>
        ///Chave estrangeira do Id do Funcionario
        /// </summary>
        [ForeignKey(nameof(Funcionario))]
        public int IdTransportador { get; set; }
        public Funcionarios Funcionario { get; set; }
    }
}