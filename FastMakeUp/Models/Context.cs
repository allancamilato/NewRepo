using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FastMakeUp.Models
{
    public class Context: DbContext
    {


        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Perfil> Perfil { get; set; }
        public virtual DbSet<Endereco> Endereco { get; set; }
        public virtual DbSet<Contato> Contato { get; set; }
        public virtual DbSet<CartaoDeCredito> CartaoDeCredito { get; set; }
       




        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configure domain classes using Fluent API here

            //base.OnModelCreating(modelBuilder);
        }


    }
}