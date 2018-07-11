namespace codefirsttt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add2PersoneNoi : DbMigration
    {
        public override void Up()
        {
            Sql("insert into people(name,age,angajati_id) values('puiutttu',24,2), ('povidla',20,1)");
        }
        
        public override void Down()
        {
            DropTable("dbo.people");
        }
    }
}
