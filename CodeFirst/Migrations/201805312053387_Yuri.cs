namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Yuri : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Gakuseis",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Namae = c.String(),
                        Seibetsu = c.String(),
                        Tanjoubi = c.DateTime(nullable: false),
                        Juusho = c.String(),
                        GakuseiKoudo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GakuseiKulasus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Gakusei_Id = c.Long(),
                        Kulasu_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Gakuseis", t => t.Gakusei_Id)
                .ForeignKey("dbo.Kulasus", t => t.Kulasu_Id)
                .Index(t => t.Gakusei_Id)
                .Index(t => t.Kulasu_Id);
            
            CreateTable(
                "dbo.Kulasus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Koudo = c.String(),
                        Namae = c.String(),
                        JugyouRyou = c.Double(nullable: false),
                        GakuseiSuo = c.Int(nullable: false),
                        Koushi_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Koushis", t => t.Koushi_Id)
                .Index(t => t.Koushi_Id);
            
            CreateTable(
                "dbo.Koushis",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        SenseiKoudo = c.String(),
                        Namae = c.String(),
                        Seibetsu = c.String(),
                        Tanjoubi = c.DateTime(nullable: false),
                        Juusho = c.String(),
                        DenwaBango = c.String(),
                        Kulasu_Id = c.Int(),
                        Kulasu_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kulasus", t => t.Kulasu_Id)
                .ForeignKey("dbo.Kulasus", t => t.Kulasu_Id1)
                .Index(t => t.Kulasu_Id)
                .Index(t => t.Kulasu_Id1);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Koushis", "Kulasu_Id1", "dbo.Kulasus");
            DropForeignKey("dbo.Kulasus", "Koushi_Id", "dbo.Koushis");
            DropForeignKey("dbo.Koushis", "Kulasu_Id", "dbo.Kulasus");
            DropForeignKey("dbo.GakuseiKulasus", "Kulasu_Id", "dbo.Kulasus");
            DropForeignKey("dbo.GakuseiKulasus", "Gakusei_Id", "dbo.Gakuseis");
            DropIndex("dbo.Koushis", new[] { "Kulasu_Id1" });
            DropIndex("dbo.Koushis", new[] { "Kulasu_Id" });
            DropIndex("dbo.Kulasus", new[] { "Koushi_Id" });
            DropIndex("dbo.GakuseiKulasus", new[] { "Kulasu_Id" });
            DropIndex("dbo.GakuseiKulasus", new[] { "Gakusei_Id" });
            DropTable("dbo.Koushis");
            DropTable("dbo.Kulasus");
            DropTable("dbo.GakuseiKulasus");
            DropTable("dbo.Gakuseis");
        }
    }
}
