namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedBookingTimeToCreatedAt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bookings", "CreatedAt", c => c.DateTime(nullable: false));
            DropColumn("dbo.Bookings", "BookingTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bookings", "BookingTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Bookings", "CreatedAt");
        }
    }
}
