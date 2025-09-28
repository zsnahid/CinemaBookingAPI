namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedStatusFromTicket : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Seats", "Status", c => c.Int(nullable: false));
            DropColumn("dbo.Tickets", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tickets", "Status", c => c.Int(nullable: false));
            DropColumn("dbo.Seats", "Status");
        }
    }
}
