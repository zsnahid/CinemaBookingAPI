namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        ActorId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 8000, unicode: false),
                    })
                .PrimaryKey(t => t.ActorId);
            
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        BookingId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ShowtimeId = c.Int(nullable: false),
                        BookingTime = c.DateTime(nullable: false),
                        TotalPrice = c.Double(nullable: false),
                        Status = c.Int(nullable: false),
                        QrCode = c.String(maxLength: 255, unicode: false),
                        PromoCodeId = c.Int(),
                    })
                .PrimaryKey(t => t.BookingId)
                .ForeignKey("dbo.PromoCodes", t => t.PromoCodeId)
                .ForeignKey("dbo.Showtimes", t => t.ShowtimeId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.ShowtimeId)
                .Index(t => t.PromoCodeId);
            
            CreateTable(
                "dbo.PromoCodes",
                c => new
                    {
                        PromoCodeId = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 50, unicode: false),
                        DiscountType = c.Int(nullable: false),
                        DiscountValue = c.Double(nullable: false),
                        ExpiryDate = c.DateTime(nullable: false, storeType: "date"),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PromoCodeId)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.Showtimes",
                c => new
                    {
                        ShowtimeId = c.Int(nullable: false, identity: true),
                        MovieId = c.Int(nullable: false),
                        ScreenId = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ShowtimeId)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .ForeignKey("dbo.Screens", t => t.ScreenId, cascadeDelete: true)
                .Index(t => t.MovieId)
                .Index(t => t.ScreenId);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 8000, unicode: false),
                        Synopsis = c.String(unicode: false, storeType: "text"),
                        Director = c.String(maxLength: 8000, unicode: false),
                        RuntimeMinutes = c.Int(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false, storeType: "date"),
                        PosterUrl = c.String(maxLength: 8000, unicode: false),
                    })
                .PrimaryKey(t => t.MovieId);
            
            CreateTable(
                "dbo.MovieActors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MovieId = c.Int(nullable: false),
                        ActorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Actors", t => t.ActorId, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .Index(t => t.MovieId)
                .Index(t => t.ActorId);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        MovieId = c.Int(nullable: false),
                        Rating = c.Int(nullable: false),
                        ReviewText = c.String(unicode: false, storeType: "text"),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReviewId)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.MovieId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 255, unicode: false),
                        Password = c.String(nullable: false, maxLength: 255, unicode: false),
                        UserName = c.String(maxLength: 255, unicode: false),
                        IsAdmin = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .Index(t => t.Email, unique: true);
            
            CreateTable(
                "dbo.Screens",
                c => new
                    {
                        ScreenId = c.Int(nullable: false, identity: true),
                        CinemaId = c.Int(nullable: false),
                        ScreenNumber = c.Int(nullable: false),
                        Capacity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ScreenId)
                .ForeignKey("dbo.Cinemas", t => t.CinemaId, cascadeDelete: true)
                .Index(t => t.CinemaId);
            
            CreateTable(
                "dbo.Cinemas",
                c => new
                    {
                        CinemaId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255, unicode: false),
                        Location = c.String(nullable: false, maxLength: 255, unicode: false),
                        City = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.CinemaId);
            
            CreateTable(
                "dbo.Seats",
                c => new
                    {
                        SeatId = c.Int(nullable: false, identity: true),
                        ScreenId = c.Int(nullable: false),
                        RowNumber = c.String(nullable: false, maxLength: 8000, unicode: false),
                        SeatNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SeatId)
                .ForeignKey("dbo.Screens", t => t.ScreenId, cascadeDelete: true)
                .Index(t => t.ScreenId);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        TicketId = c.Int(nullable: false, identity: true),
                        BookingId = c.Int(nullable: false),
                        SeatId = c.Int(nullable: false),
                        ShowtimeId = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TicketId)
                .ForeignKey("dbo.Bookings", t => t.BookingId, cascadeDelete: true)
                .ForeignKey("dbo.Seats", t => t.SeatId)
                .ForeignKey("dbo.Showtimes", t => t.ShowtimeId)
                .Index(t => t.BookingId)
                .Index(t => new { t.SeatId, t.ShowtimeId }, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", "UserId", "dbo.Users");
            DropForeignKey("dbo.Tickets", "ShowtimeId", "dbo.Showtimes");
            DropForeignKey("dbo.Tickets", "SeatId", "dbo.Seats");
            DropForeignKey("dbo.Tickets", "BookingId", "dbo.Bookings");
            DropForeignKey("dbo.Bookings", "ShowtimeId", "dbo.Showtimes");
            DropForeignKey("dbo.Showtimes", "ScreenId", "dbo.Screens");
            DropForeignKey("dbo.Seats", "ScreenId", "dbo.Screens");
            DropForeignKey("dbo.Screens", "CinemaId", "dbo.Cinemas");
            DropForeignKey("dbo.Showtimes", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.Reviews", "UserId", "dbo.Users");
            DropForeignKey("dbo.Reviews", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.MovieActors", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.MovieActors", "ActorId", "dbo.Actors");
            DropForeignKey("dbo.Bookings", "PromoCodeId", "dbo.PromoCodes");
            DropIndex("dbo.Tickets", new[] { "SeatId", "ShowtimeId" });
            DropIndex("dbo.Tickets", new[] { "BookingId" });
            DropIndex("dbo.Seats", new[] { "ScreenId" });
            DropIndex("dbo.Screens", new[] { "CinemaId" });
            DropIndex("dbo.Users", new[] { "Email" });
            DropIndex("dbo.Reviews", new[] { "MovieId" });
            DropIndex("dbo.Reviews", new[] { "UserId" });
            DropIndex("dbo.MovieActors", new[] { "ActorId" });
            DropIndex("dbo.MovieActors", new[] { "MovieId" });
            DropIndex("dbo.Showtimes", new[] { "ScreenId" });
            DropIndex("dbo.Showtimes", new[] { "MovieId" });
            DropIndex("dbo.PromoCodes", new[] { "Code" });
            DropIndex("dbo.Bookings", new[] { "PromoCodeId" });
            DropIndex("dbo.Bookings", new[] { "ShowtimeId" });
            DropIndex("dbo.Bookings", new[] { "UserId" });
            DropTable("dbo.Tickets");
            DropTable("dbo.Seats");
            DropTable("dbo.Cinemas");
            DropTable("dbo.Screens");
            DropTable("dbo.Users");
            DropTable("dbo.Reviews");
            DropTable("dbo.MovieActors");
            DropTable("dbo.Movies");
            DropTable("dbo.Showtimes");
            DropTable("dbo.PromoCodes");
            DropTable("dbo.Bookings");
            DropTable("dbo.Actors");
        }
    }
}
