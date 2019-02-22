
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auth.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Auth.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository auth;
        public AuthController(IAuthRepository auth) : base()
        {
            this.auth = auth;

        }

    }
}