namespace CG171105_CR150934_desafio01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Pruebaforanea : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CuentaBancaria",
                c => new
                    {
                        idcuentabanc = c.Int(nullable: false, identity: true),
                        idcliente = c.Int(nullable: false),
                        Moneda = c.String(nullable: false, maxLength: 300),
                    })
                .PrimaryKey(t => t.idcuentabanc)
                .ForeignKey("dbo.Cliente", t => t.idcliente, cascadeDelete: true)
                .Index(t => t.idcliente);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CuentaBancaria", "idcliente", "dbo.Cliente");
            DropIndex("dbo.CuentaBancaria", new[] { "idcliente" });
            DropTable("dbo.CuentaBancaria");
        }
    }
}
