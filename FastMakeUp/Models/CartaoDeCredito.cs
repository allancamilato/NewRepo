using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FastMakeUp.Models
{
    [Table("FL_CARTAO_DE_CREDITO")]
    public class CartaoDeCredito
    {

        private int cartaoDeCreditoId;

        [Key, ForeignKey("Usuario")]
        [Column("ID")]
        public int CartaoDeCreditoId
        {
            get { return cartaoDeCreditoId; }
            set { cartaoDeCreditoId = value; }
        }

        private string numeroDoCartao;

        [Column("NUMERO_DO_CARTAO")]
        public string NumeroDoCartao
        {
            get { return numeroDoCartao; }
            set { numeroDoCartao = value; }
        }

        private string mes;

        [Column("MES")]
        public string Mes
        {
            get { return mes; }
            set { mes = value; }
        }

        private string ano;

        [Column("ANO")]
        public string Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        private string codigo;

        [Column("CODIGO")]
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }



        /// <summary>
        /// Relacionamento One-To-Many
        /// </summary>
        public virtual Usuario Usuario { get; set; }



    }
}