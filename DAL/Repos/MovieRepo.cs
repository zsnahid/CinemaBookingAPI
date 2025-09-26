using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
using DAL.EF.Tables;
using DAL.Interfaces;

namespace DAL.Repos
{
    internal class MovieRepo : IRepo<Movie, int, bool>
    {
        BMSContext db;

        public MovieRepo()
        {
            db = new BMSContext();
        }

        public bool Create(Movie obj)
        {
            db.Movies.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var existingMovie = db.Movies.Find(id);
            if (existingMovie == null)
            {
                return false;
            }
            db.Movies.Remove(existingMovie);
            return db.SaveChanges() > 0;
        }

        public List<Movie> Get()
        {
            return db.Movies.ToList();
        }

        public Movie Get(int id)
        {
            return db.Movies.Find(id);
        }

        public bool Update(Movie obj)
        {
            var existingMovie = db.Movies.Find(obj.MovieId);
            if (existingMovie == null)
            {
                return false;
            }
            existingMovie.Title = obj.Title;
            existingMovie.Synopsis = obj.Synopsis;
            existingMovie.Director = obj.Director;
            existingMovie.RuntimeMinutes = obj.RuntimeMinutes;
            existingMovie.ReleaseDate = obj.ReleaseDate;
            existingMovie.PosterUrl = obj.PosterUrl;

            return db.SaveChanges() > 0;
        }
    }
}
