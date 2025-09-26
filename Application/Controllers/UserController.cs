using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.DTOs;
using BLL.Services;

namespace Application.Controllers
{
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        [HttpGet]
        [Route("all")]
        public HttpResponseMessage Get()
        {
            var users = UserService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, users);
        }

        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage Get(int id)
        {
            var user = UserService.Get(id);

            if (user == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "User not found!");
            }
            return Request.CreateResponse(HttpStatusCode.OK, user);
        }

        [HttpPost]
        [Route("register")]
        public HttpResponseMessage Create(UserDTO user)
        {
            try
            {
                var result = UserService.Create(user);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(
                    HttpStatusCode.InternalServerError,
                    "Failed to create user!"
                );
            }
        }

        [HttpPut]
        [Route("{id}/email")]
        public HttpResponseMessage UpdateEmail(int id, EmailUpdateDTO obj)
        {
            try
            {
                var result = UserService.UpdateEmail(id, obj.Email);
                if (result)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Email updated successfully");
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "User not found!");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(
                    HttpStatusCode.InternalServerError,
                    "Failed to update email!"
                );
            }
        }

        [HttpPut]
        [Route("{id}/password")]
        public HttpResponseMessage UpdatePassword(int id, PasswordUpdateDTO obj)
        {
            try
            {
                var result = UserService.UpdatePassword(id, obj.Password);
                if (result)
                {
                    return Request.CreateResponse(
                        HttpStatusCode.OK,
                        "Password updated successfully"
                    );
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "User not found!");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(
                    HttpStatusCode.InternalServerError,
                    "Failed to update password!"
                );
            }
        }

        [HttpPut]
        [Route("{id}/username")]
        public HttpResponseMessage UpdateUsername(int id, UsernameUpdateDTO obj)
        {
            try
            {
                var result = UserService.UpdateUserName(id, obj.UserName);
                if (result)
                {
                    return Request.CreateResponse(
                        HttpStatusCode.OK,
                        "Username updated successfully"
                    );
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "User not found!");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(
                    HttpStatusCode.InternalServerError,
                    "Failed to update username!"
                );
            }
        }
    }
}
