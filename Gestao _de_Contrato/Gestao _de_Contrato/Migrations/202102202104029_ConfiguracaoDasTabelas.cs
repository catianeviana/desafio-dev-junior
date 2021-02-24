namespace Gestao__de_Contrato.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConfiguracaoDasTabelas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contratos",
                c => new
                    {
                        ContratoId = c.Int(nullable: false, identity: true),
                        Objeto = c.String(maxLength: 40),
                        IdEmpresaContratante = c.Int(nullable: false),
                        IdEmpresaContratada = c.Int(nullable: false),
                        Status = c.String(maxLength:50),
                        Descricao_do_Objeto = c.String(),
                        Datacontrato = c.DateTime(),
                        Carencia = c.DateTime(nullable: false),
                        Vigencia = c.DateTime(),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Prazo = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ContratoId)
                .ForeignKey("dbo.Empresas", t => t.IdEmpresaContratante, cascadeDelete: true)
                .Index(t => t.IdEmpresaContratante);
            
            CreateTable(
                "dbo.Empresas",
                c => new
                    {
                        EmpresaId = c.Int(nullable: false, identity: true),
                        NomeRazaoSocial = c.String(maxLength: 50),
                        Cnpj = c.String(maxLength: 30),
                        Endereco = c.String(maxLength: 50),
                        Telefone = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.EmpresaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contratos", "IdEmpresaContratante", "dbo.Empresas");
            DropIndex("dbo.Contratos", new[] { "IdEmpresaContratante" });
            DropTable("dbo.Empresas");
            DropTable("dbo.Contratos");
        }
    }
}
