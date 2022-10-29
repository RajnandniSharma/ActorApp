using ActorsApp.Models;
using Microsoft.AspNetCore.Mvc;
using ActorsApp.Service;
namespace ActorsApp.Controllers
{
    public class ActorController : Controller
    {
       
        public IActionResult Index()
        {
            InMemoryDatabase context = new InMemoryDatabase();
            List<Actor> actorList = context.getAllActor();
            return View(actorList);
        }
    }
}
