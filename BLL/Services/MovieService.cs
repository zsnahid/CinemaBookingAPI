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
    }
}
