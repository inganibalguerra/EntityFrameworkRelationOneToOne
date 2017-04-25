namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migracion1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Expedientes",
                c => new
                    {
                        ExpedienteId = c.Int(nullable: false),
                        Nombre = c.String(),
                        Identificacion = c.String(),
                        Cuantia = c.Single(nullable: false),
                        ObligacionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ExpedienteId)
                .ForeignKey("dbo.Obligacions", t => t.ExpedienteId)
                .Index(t => t.ExpedienteId);
            
            CreateTable(
                "dbo.Obligacions",
                c => new
                    {
                        ObligacionId = c.Int(nullable: false, identity: true),
                        Cuantia = c.Single(nullable: false),
                        ExpedienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ObligacionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Expedientes", "ExpedienteId", "dbo.Obligacions");
            DropIndex("dbo.Expedientes", new[] { "ExpedienteId" });
            DropTable("dbo.Obligacions");
            DropTable("dbo.Expedientes");
        }
    }
}
