using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.DTOs;
using BLL.Services;

namespace Application.Controllers
{
    [RoutePrefix("api/movie")]
    public class MovieController : ApiController
    {
        [HttpGet]
        [Route("all")]
        public HttpResponseMessage Get()
        {
            var movies = MovieService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, movies);
        }

        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage Get(int id)
        {
            var movie = MovieService.Get(id);
            if (movie == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Movie not found!");
            }
            return Request.CreateResponse(HttpStatusCode.OK, movie);
        }

        [HttpPost]
        [Route("create")]
        public HttpResponseMessage Create(MovieDTO movie)
        {
            try
            {
                var res = MovieService.Create(movie);
                if (res)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Movie added successfully");
                }
                else
                {
                    return Request.CreateErrorResponse(
                        HttpStatusCode.BadRequest,
                        "Failed to add movie!"
                    );
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("{id}/update")]
        public HttpResponseMessage Update(MovieDTO movie)
        {
            try
            {
                var res = MovieService.Update(movie);
                if (res)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Movie updated successfully");
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Movie not found!");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}/delete")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var res = MovieService.Delete(id);
                if (res)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Movie deleted successfully");
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Movie not found!");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
