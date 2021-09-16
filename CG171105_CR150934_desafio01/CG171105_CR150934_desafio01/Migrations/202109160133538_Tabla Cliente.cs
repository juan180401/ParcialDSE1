namespace CG171105_CR150934_desafio01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablaCliente : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        idcliente = c.Int(nullable: false, identity: true),
                        Nombres = c.String(nullable: false, maxLength: 300),
                        Primer_Apellido = c.String(nullable: false, maxLength: 200),
                        Segundo_Apellido = c.String(nullable: false, maxLength: 200),
                        Telefono = c.Int(nullable: false),
                        Correo = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.idcliente);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cliente");
        }
    }
}
