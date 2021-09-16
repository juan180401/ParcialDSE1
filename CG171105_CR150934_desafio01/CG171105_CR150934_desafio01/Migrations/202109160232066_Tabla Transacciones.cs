namespace CG171105_CR150934_desafio01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablaTransacciones : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transacciones",
                c => new
                    {
                        idtransaccion = c.Int(nullable: false, identity: true),
                        idCuentaBancaria = c.Int(nullable: false),
                        Tipo_Transaccion = c.Int(nullable: false),
                        Monto = c.Single(nullable: false),
                        Estado = c.String(nullable: false, maxLength: 300),
                        FechaTransaccion = c.DateTime(nullable: false),
                        FechaAplicacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.idtransaccion)
                .ForeignKey("dbo.CuentaBancaria", t => t.idCuentaBancaria, cascadeDelete: true)
                .ForeignKey("dbo.TipoTransaccion", t => t.Tipo_Transaccion, cascadeDelete: true)
                .Index(t => t.idCuentaBancaria)
                .Index(t => t.Tipo_Transaccion);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transacciones", "Tipo_Transaccion", "dbo.TipoTransaccion");
            DropForeignKey("dbo.Transacciones", "idCuentaBancaria", "dbo.CuentaBancaria");
            DropIndex("dbo.Transacciones", new[] { "Tipo_Transaccion" });
            DropIndex("dbo.Transacciones", new[] { "idCuentaBancaria" });
            DropTable("dbo.Transacciones");
        }
    }
}
