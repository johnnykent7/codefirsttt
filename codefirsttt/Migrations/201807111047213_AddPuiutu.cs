namespace codefirsttt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPuiutu : DbMigration
    {
        public override void Up()
        {
            Sql("insert into angajatis(dataangajarii) values('2018-7-11')");
        }
        
        public override void Down()
        {
            DropTable("dbo.angajatis");
        }
    }
}
