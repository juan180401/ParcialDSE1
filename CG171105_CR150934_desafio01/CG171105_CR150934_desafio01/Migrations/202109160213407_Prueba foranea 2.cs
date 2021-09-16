namespace CG171105_CR150934_desafio01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Pruebaforanea2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.CuentaBancaria", name: "idcuentabancaria", newName: "Tipo");
            RenameIndex(table: "dbo.CuentaBancaria", name: "IX_idcuentabancaria", newName: "IX_Tipo");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.CuentaBancaria", name: "IX_Tipo", newName: "IX_idcuentabancaria");
            RenameColumn(table: "dbo.CuentaBancaria", name: "Tipo", newName: "idcuentabancaria");
        }
    }
}
