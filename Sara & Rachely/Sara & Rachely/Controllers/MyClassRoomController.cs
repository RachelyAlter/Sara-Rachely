using Microsoft.AspNetCore.Mvc;
using Sara___Rachely;
namespace Sara___Rachely.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MyClassRoomController : Controller
    {
        Classroom Classroom { get; set; }

    }
}
