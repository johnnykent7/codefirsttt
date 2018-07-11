namespace codefirsttt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteManincaRasaritColumn : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.People", "ManincaRasarita");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "ManincaRasarita", c => c.Boolean(nullable: false));
        }
    }
}
