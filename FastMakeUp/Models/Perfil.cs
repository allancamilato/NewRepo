using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FastMakeUp.Models
{
    [Table("FL_PERFIL")]
    public class Perfil
    {

        //public Perfil()
        //{
        //    ListaDeUsuarios = new List<Usuario>();
        //}

        private int perfilId;

        [Key]
        [Column("ID")]
        public int PerfilId
        {
            get { return perfilId; }
            set { perfilId = value; }
        }

        private string nome;

        [Column("NOME")]
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private bool status;

        [Column("STATUS")]
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }


        /// <summary>
        /// Relacionamento One-To-Many
        /// </summary>
        public virtual ICollection<Usuario> Usuarios { get; set; }


    }
}