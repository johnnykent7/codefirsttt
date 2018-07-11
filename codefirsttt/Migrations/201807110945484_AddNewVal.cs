namespace codefirsttt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewVal : DbMigration
    {
        public override void Up()
        {
            Sql("update  people set angajati_id=1 where age=20");
        }

        public override void Down()
        {
            DropTable("dbo.people");
        }
    }
}
