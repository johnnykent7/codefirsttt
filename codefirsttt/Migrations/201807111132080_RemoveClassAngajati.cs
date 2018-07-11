namespace codefirsttt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveClassAngajati : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.People", "Angajati_ID", "dbo.Angajatis");
            DropIndex("dbo.People", new[] { "Angajati_ID" });
            DropColumn("dbo.People", "Angajati_ID");
            DropTable("dbo.Angajatis");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Angajatis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DataAngajarii = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.People", "Angajati_ID", c => c.Int());
            CreateIndex("dbo.People", "Angajati_ID");
            AddForeignKey("dbo.People", "Angajati_ID", "dbo.Angajatis", "ID");
        }
    }
}
