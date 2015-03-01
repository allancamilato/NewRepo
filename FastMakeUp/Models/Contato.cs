using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FastMakeUp.Models
{
    [Table("FL_CONTATO")]
    public class Contato
    {

        private int contatoId;

        [Key, ForeignKey("Usuario")]
        [Column("ID")]
        public int ContatoId
        {
            get { return contatoId; }
            set { contatoId = value; }
        }

        private string celular;

        [Column("CELULAR")]
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        private string telefone1;

        [Column("TELEFONE_1")]
        public string Telefone1
        {
            get { return telefone1; }
            set { telefone1 = value; }
        }

        private string telefone2;

        [Column("TELEFONE_2")]
        public string Telefone2
        {
            get { return telefone2; }
            set { telefone2 = value; }
        }

        private string email;

        [Column("EMAIL")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        /// <summary>
        /// Relacionamento One-To-Many
        /// </summary>
        public virtual Usuario Usuario { get; set; }


    }
}