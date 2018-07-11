namespace codefirsttt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class insertppl : DbMigration
    {
        public override void Up()
        {
            Sql("insert into people(name,age) values('povidla',20)");
        }
        
        public override void Down()
        {
            Sql("delete from people where name='povidla'");
        }
    }
}
