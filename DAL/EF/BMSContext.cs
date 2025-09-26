using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF.Tables;

namespace DAL.EF
{
    public class BMSContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<MovieActor> MovieActors { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Screen> Screens { get; set; }
        public DbSet<Showtime> Showtimes { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<PromoCode> PromoCodes { get; set; }

        // A booking can have many tickets, and when a booking is deleted,
        // all associated tickets should also be deleted
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // A seat can be associated with many tickets over time,
            // but should be booked to a single ticket per showtime.
            modelBuilder
                .Entity<Ticket>()
                .HasIndex(t => new { t.SeatId, t.ShowtimeId })
                .IsUnique();

            modelBuilder
                .Entity<Ticket>()
                .HasRequired(t => t.Booking)
                .WithMany(b => b.Tickets)
                .HasForeignKey(t => t.BookingId)
                .WillCascadeOnDelete(true);

            // When a seat is deleted, the ticket should remain;
            // so that the ticket can be assigned to a new seat.
            modelBuilder
                .Entity<Ticket>()
                .HasRequired(t => t.Seat)
                .WithMany()
                .HasForeignKey(t => t.SeatId)
                .WillCascadeOnDelete(false);

            modelBuilder
                .Entity<Ticket>()
                .HasRequired(t => t.Showtime)
                .WithMany()
                .HasForeignKey(t => t.ShowtimeId)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}
