namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedQrCodeInTicket : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "QrCode", c => c.String(maxLength: 255, unicode: false));
            DropColumn("dbo.Bookings", "QrCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bookings", "QrCode", c => c.String(maxLength: 255, unicode: false));
            DropColumn("dbo.Tickets", "QrCode");
        }
    }
}
