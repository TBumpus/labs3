using coffeeShopRegistrationLab.Data;
using coffeeShopRegistrationLab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace coffeeShopRegistrationLab.Controllers
{
    public class UserController : Controller
    {
        //to go to a list instead
        
        //public List<User> Users { get; set; } = new List<User>();

        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<User> userList = await _context.Users.ToListAsync();

            return View(userList);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);

            if(user == null)
            {
                return NotFound();
            }

            return View(user);
        }

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Email,Password")] User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction("Summary", user);
            }
            return View(user);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FindAsync(id);
            if(user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Email,Password")] User user)
        {
            if (id != user.Id)
            {
                return NotFound(user);
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(x => x.Id == id);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            if(user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.Users.FindAsync(id);

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Summary(User user)
        {
            return View(user);
        }
    }
}
