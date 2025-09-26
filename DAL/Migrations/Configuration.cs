namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DAL.EF.Tables;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.EF.BMSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.EF.BMSContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            // Seed Users
            //context.Users.AddOrUpdate(
            //    u => u.Email,
            //    new User
            //    {
            //        Email = "admin@cinema.com",
            //        Password = "admin123",
            //        UserName = "Administrator",
            //        IsAdmin = true,
            //        CreatedAt = DateTime.Now.AddMonths(-6),
            //    },
            //    new User
            //    {
            //        Email = "john.doe@email.com",
            //        Password = "password123",
            //        UserName = "John Doe",
            //        IsAdmin = false,
            //        CreatedAt = DateTime.Now.AddMonths(-3),
            //    },
            //    new User
            //    {
            //        Email = "jane.smith@email.com",
            //        Password = "password123",
            //        UserName = "Jane Smith",
            //        IsAdmin = false,
            //        CreatedAt = DateTime.Now.AddMonths(-2),
            //    },
            //    new User
            //    {
            //        Email = "mike.wilson@email.com",
            //        Password = "password123",
            //        UserName = "Mike Wilson",
            //        IsAdmin = false,
            //        CreatedAt = DateTime.Now.AddMonths(-1),
            //    }
            //);

            //// Seed Actors
            //context.Actors.AddOrUpdate(
            //    a => a.Name,
            //    new Actor { Name = "Leonardo DiCaprio" },
            //    new Actor { Name = "Kate Winslet" },
            //    new Actor { Name = "Morgan Freeman" },
            //    new Actor { Name = "Brad Pitt" },
            //    new Actor { Name = "Scarlett Johansson" },
            //    new Actor { Name = "Robert Downey Jr." },
            //    new Actor { Name = "Chris Evans" },
            //    new Actor { Name = "Tom Hanks" },
            //    new Actor { Name = "Meryl Streep" },
            //    new Actor { Name = "Denzel Washington" }
            //);

            //// Seed Movies
            //context.Movies.AddOrUpdate(
            //    m => m.Title,
            //    new Movie
            //    {
            //        Title = "Titanic",
            //        Synopsis =
            //            "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic.",
            //        Director = "James Cameron",
            //        RuntimeMinutes = 194,
            //        ReleaseDate = new DateTime(1997, 12, 19),
            //        PosterUrl = "https://example.com/posters/titanic.jpg",
            //    },
            //    new Movie
            //    {
            //        Title = "The Shawshank Redemption",
            //        Synopsis =
            //            "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
            //        Director = "Frank Darabont",
            //        RuntimeMinutes = 142,
            //        ReleaseDate = new DateTime(1994, 9, 23),
            //        PosterUrl = "https://example.com/posters/shawshank.jpg",
            //    },
            //    new Movie
            //    {
            //        Title = "Avengers: Endgame",
            //        Synopsis =
            //            "After the devastating events of Avengers: Infinity War, the universe is in ruins.",
            //        Director = "Anthony Russo, Joe Russo",
            //        RuntimeMinutes = 181,
            //        ReleaseDate = new DateTime(2019, 4, 26),
            //        PosterUrl = "https://example.com/posters/endgame.jpg",
            //    },
            //    new Movie
            //    {
            //        Title = "Forrest Gump",
            //        Synopsis =
            //            "The presidencies of Kennedy and Johnson, the Vietnam War, and other historical events unfold from the perspective of an Alabama man.",
            //        Director = "Robert Zemeckis",
            //        RuntimeMinutes = 142,
            //        ReleaseDate = new DateTime(1994, 7, 6),
            //        PosterUrl = "https://example.com/posters/forrest-gump.jpg",
            //    }
            //);

            //// Save changes to get generated IDs
            //context.SaveChanges();

            //// Seed MovieActors (many-to-many relationship)
            //var titanic = context.Movies.First(m => m.Title == "Titanic");
            //var shawshank = context.Movies.First(m => m.Title == "The Shawshank Redemption");
            //var endgame = context.Movies.First(m => m.Title == "Avengers: Endgame");
            //var forrestGump = context.Movies.First(m => m.Title == "Forrest Gump");

            //var leonardo = context.Actors.First(a => a.Name == "Leonardo DiCaprio");
            //var kate = context.Actors.First(a => a.Name == "Kate Winslet");
            //var morgan = context.Actors.First(a => a.Name == "Morgan Freeman");
            //var robert = context.Actors.First(a => a.Name == "Robert Downey Jr.");
            //var chris = context.Actors.First(a => a.Name == "Chris Evans");
            //var tomHanks = context.Actors.First(a => a.Name == "Tom Hanks");

            //context.MovieActors.AddOrUpdate(
            //    ma => new { ma.MovieId, ma.ActorId },
            //    new MovieActor { MovieId = titanic.MovieId, ActorId = leonardo.ActorId },
            //    new MovieActor { MovieId = titanic.MovieId, ActorId = kate.ActorId },
            //    new MovieActor { MovieId = shawshank.MovieId, ActorId = morgan.ActorId },
            //    new MovieActor { MovieId = endgame.MovieId, ActorId = robert.ActorId },
            //    new MovieActor { MovieId = endgame.MovieId, ActorId = chris.ActorId },
            //    new MovieActor { MovieId = forrestGump.MovieId, ActorId = tomHanks.ActorId }
            //);

            //// Seed Cinemas
            //context.Cinemas.AddOrUpdate(
            //    c => c.Name,
            //    new Cinema
            //    {
            //        Name = "Grand Cinema",
            //        Location = "123 Main Street",
            //        City = "New York",
            //    },
            //    new Cinema
            //    {
            //        Name = "Starlight Theater",
            //        Location = "456 Broadway Avenue",
            //        City = "Los Angeles",
            //    },
            //    new Cinema
            //    {
            //        Name = "Metro Multiplex",
            //        Location = "789 Oak Street",
            //        City = "Chicago",
            //    }
            //);

            //context.SaveChanges();

            //// Seed Screens
            //var grandCinema = context.Cinemas.First(c => c.Name == "Grand Cinema");
            //var starlightTheater = context.Cinemas.First(c => c.Name == "Starlight Theater");
            //var metroMultiplex = context.Cinemas.First(c => c.Name == "Metro Multiplex");

            //context.Screens.AddOrUpdate(
            //    s => new { s.CinemaId, s.ScreenNumber },
            //    new Screen
            //    {
            //        CinemaId = grandCinema.CinemaId,
            //        ScreenNumber = 1,
            //        Capacity = 120,
            //    },
            //    new Screen
            //    {
            //        CinemaId = grandCinema.CinemaId,
            //        ScreenNumber = 2,
            //        Capacity = 80,
            //    },
            //    new Screen
            //    {
            //        CinemaId = starlightTheater.CinemaId,
            //        ScreenNumber = 1,
            //        Capacity = 150,
            //    },
            //    new Screen
            //    {
            //        CinemaId = starlightTheater.CinemaId,
            //        ScreenNumber = 2,
            //        Capacity = 100,
            //    },
            //    new Screen
            //    {
            //        CinemaId = metroMultiplex.CinemaId,
            //        ScreenNumber = 1,
            //        Capacity = 200,
            //    }
            //);

            //context.SaveChanges();

            //// Seed Seats
            //var screen1 = context.Screens.First(s =>
            //    s.CinemaId == grandCinema.CinemaId && s.ScreenNumber == 1
            //);
            //var screen2 = context.Screens.First(s =>
            //    s.CinemaId == grandCinema.CinemaId && s.ScreenNumber == 2
            //);

            //// Create seats for Screen 1 (10 rows, 12 seats per row)
            //for (char row = 'A'; row <= 'J'; row++)
            //{
            //    for (int seat = 1; seat <= 12; seat++)
            //    {
            //        context.Seats.AddOrUpdate(
            //            s => new
            //            {
            //                s.ScreenId,
            //                s.RowNumber,
            //                s.SeatNumber,
            //            },
            //            new Seat
            //            {
            //                ScreenId = screen1.ScreenId,
            //                RowNumber = row.ToString(),
            //                SeatNumber = seat,
            //            }
            //        );
            //    }
            //}

            //// Create seats for Screen 2 (8 rows, 10 seats per row)
            //for (char row = 'A'; row <= 'H'; row++)
            //{
            //    for (int seat = 1; seat <= 10; seat++)
            //    {
            //        context.Seats.AddOrUpdate(
            //            s => new
            //            {
            //                s.ScreenId,
            //                s.RowNumber,
            //                s.SeatNumber,
            //            },
            //            new Seat
            //            {
            //                ScreenId = screen2.ScreenId,
            //                RowNumber = row.ToString(),
            //                SeatNumber = seat,
            //            }
            //        );
            //    }
            //}

            //context.SaveChanges();

            //// Seed Showtimes
            //var today = DateTime.Today;
            //var tomorrow = today.AddDays(1);

            //context.Showtimes.AddOrUpdate(
            //    st => new
            //    {
            //        st.MovieId,
            //        st.ScreenId,
            //        st.StartTime,
            //    },
            //    new Showtime
            //    {
            //        MovieId = titanic.MovieId,
            //        ScreenId = screen1.ScreenId,
            //        StartTime = today.AddHours(14), // 2:00 PM
            //        EndTime = today.AddHours(14).AddMinutes(194), // Runtime + buffer
            //        Price = 12.99f,
            //    },
            //    new Showtime
            //    {
            //        MovieId = shawshank.MovieId,
            //        ScreenId = screen1.ScreenId,
            //        StartTime = today.AddHours(19), // 7:00 PM
            //        EndTime = today.AddHours(19).AddMinutes(142),
            //        Price = 10.99f,
            //    },
            //    new Showtime
            //    {
            //        MovieId = endgame.MovieId,
            //        ScreenId = screen2.ScreenId,
            //        StartTime = tomorrow.AddHours(15), // 3:00 PM tomorrow
            //        EndTime = tomorrow.AddHours(15).AddMinutes(181),
            //        Price = 15.99f,
            //    },
            //    new Showtime
            //    {
            //        MovieId = forrestGump.MovieId,
            //        ScreenId = screen2.ScreenId,
            //        StartTime = tomorrow.AddHours(20), // 8:00 PM tomorrow
            //        EndTime = tomorrow.AddHours(20).AddMinutes(142),
            //        Price = 11.99f,
            //    }
            //);

            //// Seed Promo Codes
            //context.PromoCodes.AddOrUpdate(
            //    pc => pc.Code,
            //    new PromoCode
            //    {
            //        Code = "WELCOME10",
            //        DiscountType = DiscountType.PERCENT,
            //        DiscountValue = 10.0f,
            //        ExpiryDate = DateTime.Today.AddMonths(3),
            //        IsActive = true,
            //    },
            //    new PromoCode
            //    {
            //        Code = "SAVE5",
            //        DiscountType = DiscountType.FIXED,
            //        DiscountValue = 5.0f,
            //        ExpiryDate = DateTime.Today.AddMonths(2),
            //        IsActive = true,
            //    },
            //    new PromoCode
            //    {
            //        Code = "EXPIRED",
            //        DiscountType = DiscountType.PERCENT,
            //        DiscountValue = 20.0f,
            //        ExpiryDate = DateTime.Today.AddDays(-30),
            //        IsActive = false,
            //    }
            //);

            //context.SaveChanges();

            //// Seed Bookings
            //var johnDoe = context.Users.First(u => u.Email == "john.doe@email.com");
            //var janeSmith = context.Users.First(u => u.Email == "jane.smith@email.com");
            //var titanicShowtime = context.Showtimes.First(st => st.MovieId == titanic.MovieId);
            //var endgameShowtime = context.Showtimes.First(st => st.MovieId == endgame.MovieId);
            //var welcomePromo = context.PromoCodes.First(pc => pc.Code == "WELCOME10");

            //context.Bookings.AddOrUpdate(
            //    b => new
            //    {
            //        b.UserId,
            //        b.ShowtimeId,
            //        b.BookingTime,
            //    },
            //    new Booking
            //    {
            //        UserId = johnDoe.UserId,
            //        ShowtimeId = titanicShowtime.ShowtimeId,
            //        BookingTime = DateTime.Now.AddDays(-2),
            //        TotalPrice = 23.38f, // 2 tickets * 12.99 * 0.9 (10% discount)
            //        Status = BookingStatus.CONFIRMED,
            //        QrCode = "QR001",
            //        PromoCodeId = welcomePromo.PromoCodeId,
            //    },
            //    new Booking
            //    {
            //        UserId = janeSmith.UserId,
            //        ShowtimeId = endgameShowtime.ShowtimeId,
            //        BookingTime = DateTime.Now.AddHours(-5),
            //        TotalPrice = 15.99f,
            //        Status = BookingStatus.PENDING,
            //        QrCode = "QR002",
            //        PromoCodeId = null,
            //    }
            //);

            //context.SaveChanges();

            //// Seed Tickets
            //var johnBooking = context.Bookings.First(b => b.UserId == johnDoe.UserId);
            //var janeBooking = context.Bookings.First(b => b.UserId == janeSmith.UserId);
            //var seatA1 = context.Seats.First(s =>
            //    s.ScreenId == screen1.ScreenId && s.RowNumber == "A" && s.SeatNumber == 1
            //);
            //var seatA2 = context.Seats.First(s =>
            //    s.ScreenId == screen1.ScreenId && s.RowNumber == "A" && s.SeatNumber == 2
            //);
            //var seatB5Screen2 = context.Seats.First(s =>
            //    s.ScreenId == screen2.ScreenId && s.RowNumber == "B" && s.SeatNumber == 5
            //);

            //context.Tickets.AddOrUpdate(
            //    t => new
            //    {
            //        t.BookingId,
            //        t.SeatId,
            //        t.ShowtimeId,
            //    },
            //    new Ticket
            //    {
            //        BookingId = johnBooking.BookingId,
            //        SeatId = seatA1.SeatId,
            //        ShowtimeId = titanicShowtime.ShowtimeId,
            //        Status = TicketStatus.BOOKED,
            //    },
            //    new Ticket
            //    {
            //        BookingId = johnBooking.BookingId,
            //        SeatId = seatA2.SeatId,
            //        ShowtimeId = titanicShowtime.ShowtimeId,
            //        Status = TicketStatus.BOOKED,
            //    },
            //    new Ticket
            //    {
            //        BookingId = janeBooking.BookingId,
            //        SeatId = seatB5Screen2.SeatId,
            //        ShowtimeId = endgameShowtime.ShowtimeId,
            //        Status = TicketStatus.BOOKED,
            //    }
            //);

            //// Seed Reviews
            //context.Reviews.AddOrUpdate(
            //    r => new { r.UserId, r.MovieId },
            //    new Review
            //    {
            //        UserId = johnDoe.UserId,
            //        MovieId = titanic.MovieId,
            //        Rating = 5,
            //        ReviewText =
            //            "Absolutely fantastic movie! The story, acting, and cinematography are all top-notch.",
            //        CreatedAt = DateTime.Now.AddDays(-1),
            //    },
            //    new Review
            //    {
            //        UserId = janeSmith.UserId,
            //        MovieId = shawshank.MovieId,
            //        Rating = 5,
            //        ReviewText =
            //            "One of the best movies ever made. Morgan Freeman's narration is perfect.",
            //        CreatedAt = DateTime.Now.AddHours(-12),
            //    },
            //    new Review
            //    {
            //        UserId = johnDoe.UserId,
            //        MovieId = endgame.MovieId,
            //        Rating = 4,
            //        ReviewText =
            //            "Great conclusion to the Marvel saga. A bit long but worth every minute.",
            //        CreatedAt = DateTime.Now.AddHours(-6),
            //    }
            //);

            //context.SaveChanges();
        }
    }
}
