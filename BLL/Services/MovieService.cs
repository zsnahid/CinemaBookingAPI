using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Tables;

namespace BLL.Services
{
    public class MovieService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Movie, MovieDTO>().ReverseMap();
                cfg.CreateMap<Showtime, ShowtimeDTO>()
                    .ForMember(dest => dest.MovieTitle, opt => opt.MapFrom(src => src.Movie.Title))
                    .ForMember(
                        dest => dest.ScreenNumber,
                        opt => opt.MapFrom(src => src.Screen.ScreenNumber)
                    )
                    .ForMember(
                        dest => dest.CinemaName,
                        opt => opt.MapFrom(src => src.Screen.Cinema.Name)
                    );
            });
            return new Mapper(config);
        }

        public static List<MovieDTO> Get()
        {
            var movies = DataAccessFactory.MovieData().Get();
            return GetMapper().Map<List<MovieDTO>>(movies);
        }

        public static MovieDTO Get(int id)
        {
            var movie = DataAccessFactory.MovieData().Get(id);
            return GetMapper().Map<MovieDTO>(movie);
        }

        public static bool Create(MovieDTO obj)
        {
            var movie = GetMapper().Map<Movie>(obj);
            return DataAccessFactory.MovieData().Create(movie);
        }

        public static bool Update(MovieDTO obj)
        {
            var movie = GetMapper().Map<Movie>(obj);
            return DataAccessFactory.MovieData().Update(movie);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.MovieData().Delete(id);
        }

        // Returns all showtimes for all movies at a specific cinema location
        public static List<ShowtimeDTO> GetShowtimesByCinema(int cinemaId)
        {
            var showtimes = DataAccessFactory.MovieFeature().GetShowtimesByCinema(cinemaId);
            return GetMapper().Map<List<ShowtimeDTO>>(showtimes);
        }

        // Returns showtimes for a specific movie at a specific cinema location
        public static List<ShowtimeDTO> GetShowtimesForMovieAtCinema(int movieId, int cinemaId)
        {
            var showtimesByMovie = DataAccessFactory
                .MovieFeature()
                .GetShowtimesForMovieAtCinema(movieId, cinemaId);
            return GetMapper().Map<List<ShowtimeDTO>>(showtimesByMovie);
        }

        // Returns showtimes grouped by movie
        public static List<MovieShowtimesDTO> GetShowtimesGroupedByMovie(int cinemaId)
        {
            var groupedShowtimes = DataAccessFactory
                .MovieFeature()
                .GetShowtimesGroupedByMovie(cinemaId);
            var result = new List<MovieShowtimesDTO>();

            foreach (var item in groupedShowtimes)
            {
                result.Add(
                    new MovieShowtimesDTO
                    {
                        Movie = GetMapper().Map<MovieDTO>(item.Key),
                        Showtimes = GetMapper().Map<List<ShowtimeDTO>>(item.Value),
                    }
                );
            }
            return result;
        }
    }
}
