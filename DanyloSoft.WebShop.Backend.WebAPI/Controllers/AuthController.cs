using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DanyloSoft.WebShop.Backend.WebAPI.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DanyloSoft.WebShop.Backend.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        public ActionResult<TokenDto> Login([FromBody] LoginDto dto)
        {
            //Peter's magic!!!
            if ("bruh".Equals(dto.Username) && "bruh".Equals(dto.Password))
            {
                return Ok(new TokenDto(){JwtToken = "well done"});
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}