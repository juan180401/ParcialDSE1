namespace CG171105_CR150934_desafio01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tablas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoCuentaBancaria",
                c => new
                    {
                        idcuentabancaria = c.Int(nullable: false, identity: true),
                        Tipo_Cuenta_Bancaria = c.String(nullable: false, maxLength: 300),
                        Activo = c.String(nullable: false, maxLength: 5),
                    })
                .PrimaryKey(t => t.idcuentabancaria);
            
            CreateTable(
                "dbo.TipoTransaccion",
                c => new
                    {
                        idtransaccion = c.Int(nullable: false, identity: true),
                        Tipo_Transaccion = c.String(nullable: false, maxLength: 300),
                    })
                .PrimaryKey(t => t.idtransaccion);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TipoTransaccion");
            DropTable("dbo.TipoCuentaBancaria");
        }
    }
}
