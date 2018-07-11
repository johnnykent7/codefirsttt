namespace codefirsttt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDateTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Angajatis", "DataAngajarii", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Angajatis", "DataAngajarii", c => c.DateTime(nullable: false));
        }
    }
}
