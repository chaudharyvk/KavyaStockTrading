namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StockTRading : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RegisterUsers",
                c => new
                    {
                        RegisterUser_ID = c.Int(nullable: false, identity: true),
                        EmailId = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.RegisterUser_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RegisterUsers");
        }
    }
}
