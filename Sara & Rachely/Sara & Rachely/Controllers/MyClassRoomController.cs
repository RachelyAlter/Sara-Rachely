using Microsoft.AspNetCore.Mvc;
using Sara___Rachely;
namespace Sara___Rachely.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MyClassRoomController : Controller
    {
        Classroom Classroom { get; set; }
        [HttpDelete("{name}")]
        public List<string> deleteFirstStudent(string name)
        {
            Classroom.students.Remove(name);
            return Classroom.students.ToList();
        }
        [HttpGet]
        public string getString()
        {
            return "the best classroom ever weith the cutest girls!!!!!!!! ";
        }

    }
}
