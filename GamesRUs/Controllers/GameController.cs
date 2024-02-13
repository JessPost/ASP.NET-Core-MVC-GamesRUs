using GamingStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace GamingStore.Controllers
{
    public class GameController : Controller
    {
        //need access to context
        private readonly GameContext _db;

        //constructor
        public GameController(GameContext db)
        {
            _db = db;
        }

        //Read all or many
        //list of video games
        [HttpGet]
        public IActionResult Index()
        {
            //read a list 
            var displayData = _db.Games.ToList();
            return View(displayData);
        }

        //read one - details
        //async and await is just standard and you should always use it
        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            //grab details
            var getDetails = await _db.Games.FindAsync(id);
            return View(getDetails);
        }

        //Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Game game)
        {
            //error handling
            if (ModelState.IsValid)
            {
                //access database and add to list
                _db.Add(game);
                //save changes 
                await _db.SaveChangesAsync();
                //show list
                return RedirectToAction("Index");
            }
            //if not valid return view
            return View(game);
        }

        //UPDATE
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            //does id exist
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            //find id in database
            var getDetails = await _db.Games.FindAsync(id);

            return View(getDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Game game)
        {
            //error handling
            if (ModelState.IsValid)
            {
                //access database and updates database
                _db.Update(game);
                //save changes 
                await _db.SaveChangesAsync();
                //show list
                return RedirectToAction("Index");
            }
            //if not valid return view
            return View(game);
        }

        //DELETE
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            //does id exist
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            //find id in database
            var getDetails = await _db.Games.FindAsync(id);

            return View(getDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            //find id in database
            var getDetails = await _db.Games.FindAsync(id);
            //remove from database
            _db.Remove(getDetails);
            //save 
            await _db.SaveChangesAsync();
            //return to list 
            return RedirectToAction("Index");
        }



        /*  public IActionResult Index()
          {
              return View();
          }

          public ViewResult GameList()
          {
              return View();
          }

          [HttpGet]
          public ViewResult GameForm() 
          {
              return View();
          }

          [HttpPost]
          public ViewResult GameForm(Game game)
          {
              if(ModelState.IsValid)
              {
                  Repository.AddGame(game);
                  return View("GameList", Repository.ListOfGames);
              }
              else
              {
                  return View();
              }
          }
        */
    }
}
