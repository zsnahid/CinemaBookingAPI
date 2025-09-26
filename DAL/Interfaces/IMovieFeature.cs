using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF.Tables;

namespace DAL.Interfaces
{
    public interface IMovieFeature
    {
        List<Showtime> GetShowtimesByCinema(int cinemaId);
        List<Showtime> GetShowtimesForMovieAtCinema(int movieId, int cinemaId);
        Dictionary<Movie, List<Showtime>> GetShowtimesGroupedByMovie(int cinemaId);
    }
}
