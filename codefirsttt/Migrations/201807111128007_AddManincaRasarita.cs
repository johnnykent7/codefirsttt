namespace codefirsttt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddManincaRasarita : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "ManincaRasarita", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "ManincaRasarita");
        }
    }
}
