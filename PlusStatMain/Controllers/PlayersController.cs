using DataTypes;
using Microsoft.AspNetCore.Mvc;

namespace PlusStatMain.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayersController : Controller
    {
        [HttpGet]
        public List<PlayerInfo> GetPlayers()
        {
            return new List<PlayerInfo>();
        }

        [HttpGet("{playerID}")]
        public PlayerInfo GetPlayer(int playerID)
        {
            return new PlayerInfo();
        }
    }
}
