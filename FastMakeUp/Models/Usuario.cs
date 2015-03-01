using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FastMakeUp.Models
{
    [Table("FL_USUARIO")]
    public class Usuario
    {
        private int usuarioId;

        [Key]
        [Column("ID")]
        public int UsuarioId
        {
            get { return usuarioId; }
            set { usuarioId = value; }
        }

        private string nome;

        [Column("NOME")]
        [MaxLength(50), MinLength(2)]
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private DateTime dtNascimento;

        [Column("DT_NASCIMENTO")]
        public DateTime DtNascimento
        {
            get { return dtNascimento; }
            set { dtNascimento = value; }
        }


        private DateTime dtCadastro;

        [Column("DT_CADASTRO")]
        public DateTime DtCadastro
        {
            get { return dtCadastro; }
            set { dtCadastro = value; }
        }


        private DateTime dtAlteracao;

        [Column("DT_ALTERACAO")]
        public DateTime DtAlteracao
        {
            get { return dtAlteracao; }
            set { dtAlteracao = value; }
        }


        private bool status;

        [Column("STATUS")]
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }


        private string chaveAcesso;

        [Column("CHAVE_ACESSO")]
        public string ChaveAcesso
        {
            get { return chaveAcesso; }
            set { chaveAcesso = value; }
        }


        private string login;

        [Column("LOGIN")]
        public string Login
        {
            get { return login; }
            set { login = value; }
        }


        private string senha;

        [Column("SENHA")]
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }





        /// <summary>
        /// Relacionamento One-To-One
        /// </summary>
        public virtual Endereco Endereco { get; set; }

        /// <summary>
        /// Relacionamento One-To-One
        /// </summary>
        public virtual Contato Contato { get; set; }

        /// <summary>
        /// Relacionamento One-To-One
        /// </summary>
        public virtual CartaoDeCredito CartaoDeCredito { get; set; }

        /// <summary>
        /// Relacionamento One-To-Many
        /// </summary>
        public virtual Perfil Perfil { get; set; }











    }
}