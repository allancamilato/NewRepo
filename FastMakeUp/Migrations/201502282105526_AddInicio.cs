namespace FastMakeUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInicio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FL_CARTAO_DE_CREDITO",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        NUMERO_DO_CARTAO = c.String(),
                        MES = c.String(),
                        ANO = c.String(),
                        CODIGO = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FL_USUARIO", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.FL_USUARIO",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NOME = c.String(maxLength: 50),
                        DT_NASCIMENTO = c.DateTime(nullable: false),
                        DT_CADASTRO = c.DateTime(nullable: false),
                        DT_ALTERACAO = c.DateTime(nullable: false),
                        STATUS = c.Boolean(nullable: false),
                        CHAVE_ACESSO = c.String(),
                        LOGIN = c.String(),
                        SENHA = c.String(),
                        Perfil_PerfilId = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FL_PERFIL", t => t.Perfil_PerfilId)
                .Index(t => t.Perfil_PerfilId);
            
            CreateTable(
                "dbo.FL_CONTATO",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        CELULAR = c.String(),
                        TELEFONE_1 = c.String(),
                        TELEFONE_2 = c.String(),
                        EMAIL = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FL_USUARIO", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.FL_ENDERECO",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        LOGRADOURO = c.String(maxLength: 80),
                        NUMERO = c.String(),
                        COMPLEMENTO = c.String(),
                        BAIRRO = c.String(),
                        CEP = c.String(),
                        CIDADE = c.String(),
                        UF = c.String(),
                        PAIS = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FL_USUARIO", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.FL_PERFIL",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NOME = c.String(),
                        STATUS = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FL_CARTAO_DE_CREDITO", "ID", "dbo.FL_USUARIO");
            DropForeignKey("dbo.FL_USUARIO", "Perfil_PerfilId", "dbo.FL_PERFIL");
            DropForeignKey("dbo.FL_ENDERECO", "ID", "dbo.FL_USUARIO");
            DropForeignKey("dbo.FL_CONTATO", "ID", "dbo.FL_USUARIO");
            DropIndex("dbo.FL_ENDERECO", new[] { "ID" });
            DropIndex("dbo.FL_CONTATO", new[] { "ID" });
            DropIndex("dbo.FL_USUARIO", new[] { "Perfil_PerfilId" });
            DropIndex("dbo.FL_CARTAO_DE_CREDITO", new[] { "ID" });
            DropTable("dbo.FL_PERFIL");
            DropTable("dbo.FL_ENDERECO");
            DropTable("dbo.FL_CONTATO");
            DropTable("dbo.FL_USUARIO");
            DropTable("dbo.FL_CARTAO_DE_CREDITO");
        }
    }
}
