using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yakuza.Api.Data;

namespace Yakuza.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly YakuzaDbContext dbContext;

        public CharacterController(YakuzaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var characters = dbContext.Characters.ToList();
            return Ok(characters);
        }
    }
}
