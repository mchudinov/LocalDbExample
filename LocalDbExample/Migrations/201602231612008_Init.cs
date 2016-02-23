namespace LocalDbExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Widget",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sum = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Widget");
        }
    }
}
