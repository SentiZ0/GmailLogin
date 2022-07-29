using GmailLoginAPI.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.HttpSys;

namespace GmailLoginAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public ActionResult<Text> ViewMessage()
        {
            var text = new Text();

            text.TextMessage = "Jest dobrze w chuj";

            return Ok(text);
        }
    }
}
