using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FastMakeUp.Models
{
    [Table("FL_ENDERECO")]
    public class Endereco
    {

        private int enderecoId;

        [Key, ForeignKey("Usuario")]
        [Column("ID")]
        public int EnderecoId
        {
            get { return enderecoId; }
            set { enderecoId = value; }
        }


        private string logradouro;

        [Column("LOGRADOURO")]
        [MaxLength(80), MinLength(5)]
        public string Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }



        private string numero;

        [Column("NUMERO")]
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }



        private string complemento;

        [Column("COMPLEMENTO")]
        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }



        private string bairro;

        [Column("BAIRRO")]
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }



        private string cEP;

        [Column("CEP")]
        public string CEP
        {
            get { return cEP; }
            set { cEP = value; }
        }



        private string cidade;

        [Column("CIDADE")]
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }



        private string uF;

        [Column("UF")]
        public string UF
        {
            get { return uF; }
            set { uF = value; }
        }



        private string pais;

        [Column("PAIS")]
        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }



        /// <summary>
        /// Relacionamento One-To-Many
        /// </summary>
        public virtual Usuario Usuario { get; set; }


    }
}