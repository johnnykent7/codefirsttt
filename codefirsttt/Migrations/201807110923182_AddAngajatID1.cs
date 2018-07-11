namespace codefirsttt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAngajatID1 : DbMigration
    {
        public override void Up()
        {
            Sql("insert into angajatis(dataangajarii) values(2011-12-18)");
        }
        
        public override void Down()
        {
            Sql("delete from angajatis where dataangajarii=2011-12-18");
        }
    }
}
