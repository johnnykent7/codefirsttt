namespace codefirsttt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeColum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Ani", c => c.Int(nullable: false));
            Sql("update people set ani=age ");
            DropColumn("dbo.People", "Age");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "Age", c => c.Int(nullable: false));
            Sql("update people set age=ani ");

            DropColumn("dbo.People", "Ani");
        }
    }
}
