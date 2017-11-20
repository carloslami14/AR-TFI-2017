namespace GestorProyectoWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Nota",
                c => new
                    {
                        IdNota = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Fecha = c.DateTime(nullable: false),
                        Tarea_IdTarea = c.Int(),
                    })
                .PrimaryKey(t => t.IdNota)
                .ForeignKey("dbo.Tarea", t => t.Tarea_IdTarea)
                .Index(t => t.Tarea_IdTarea);
            
            CreateTable(
                "dbo.Tarea",
                c => new
                    {
                        IdTarea = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 30),
                        Descripcion = c.String(nullable: false, maxLength: 300),
                        FechaInicio = c.DateTime(nullable: false),
                        FechaFin = c.DateTime(nullable: false),
                        Avance = c.Int(nullable: false),
                        Proyecto_Id = c.Int(),
                        Tarea_IdTarea = c.Int(),
                    })
                .PrimaryKey(t => t.IdTarea)
                .ForeignKey("dbo.Proyecto", t => t.Proyecto_Id)
                .ForeignKey("dbo.Tarea", t => t.Tarea_IdTarea)
                .Index(t => t.Proyecto_Id)
                .Index(t => t.Tarea_IdTarea);
            
            CreateTable(
                "dbo.Proyecto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        FechaInicio = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        IdUsuario = c.Int(nullable: false, identity: true),
                        NombreUsuario = c.String(),
                        Nombre = c.String(),
                        Contraseña = c.String(),
                        TipoUsuario = c.Int(nullable: false),
                        Proyecto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.IdUsuario)
                .ForeignKey("dbo.Proyecto", t => t.Proyecto_Id)
                .Index(t => t.Proyecto_Id);
            
            CreateTable(
                "dbo.Recurso",
                c => new
                    {
                        IdRecurso = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Precio = c.Single(nullable: false),
                        Descripcion = c.String(),
                        TipoRecurso = c.Int(),
                        Cantidad = c.Int(),
                        TipoRecurso1 = c.Int(),
                        Cantidad1 = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.IdRecurso);
            
            CreateTable(
                "dbo.Tarea_Recurso",
                c => new
                    {
                        IdTarea = c.Int(nullable: false),
                        IdRecurso = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IdTarea, t.IdRecurso })
                .ForeignKey("dbo.Tarea", t => t.IdTarea, cascadeDelete: true)
                .ForeignKey("dbo.Recurso", t => t.IdRecurso, cascadeDelete: true)
                .Index(t => t.IdTarea)
                .Index(t => t.IdRecurso);
            
            CreateTable(
                "dbo.Tarea_Usuario",
                c => new
                    {
                        IdTarea = c.Int(nullable: false),
                        IdUsuario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IdTarea, t.IdUsuario })
                .ForeignKey("dbo.Tarea", t => t.IdTarea, cascadeDelete: true)
                .ForeignKey("dbo.Usuario", t => t.IdUsuario, cascadeDelete: true)
                .Index(t => t.IdTarea)
                .Index(t => t.IdUsuario);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tarea_Usuario", "IdUsuario", "dbo.Usuario");
            DropForeignKey("dbo.Tarea_Usuario", "IdTarea", "dbo.Tarea");
            DropForeignKey("dbo.Tarea", "Tarea_IdTarea", "dbo.Tarea");
            DropForeignKey("dbo.Tarea_Recurso", "IdRecurso", "dbo.Recurso");
            DropForeignKey("dbo.Tarea_Recurso", "IdTarea", "dbo.Tarea");
            DropForeignKey("dbo.Usuario", "Proyecto_Id", "dbo.Proyecto");
            DropForeignKey("dbo.Tarea", "Proyecto_Id", "dbo.Proyecto");
            DropForeignKey("dbo.Nota", "Tarea_IdTarea", "dbo.Tarea");
            DropIndex("dbo.Tarea_Usuario", new[] { "IdUsuario" });
            DropIndex("dbo.Tarea_Usuario", new[] { "IdTarea" });
            DropIndex("dbo.Tarea_Recurso", new[] { "IdRecurso" });
            DropIndex("dbo.Tarea_Recurso", new[] { "IdTarea" });
            DropIndex("dbo.Usuario", new[] { "Proyecto_Id" });
            DropIndex("dbo.Tarea", new[] { "Tarea_IdTarea" });
            DropIndex("dbo.Tarea", new[] { "Proyecto_Id" });
            DropIndex("dbo.Nota", new[] { "Tarea_IdTarea" });
            DropTable("dbo.Tarea_Usuario");
            DropTable("dbo.Tarea_Recurso");
            DropTable("dbo.Recurso");
            DropTable("dbo.Usuario");
            DropTable("dbo.Proyecto");
            DropTable("dbo.Tarea");
            DropTable("dbo.Nota");
        }
    }
}
