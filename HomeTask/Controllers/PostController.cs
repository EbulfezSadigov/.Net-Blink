using HomeTask.DAL;
using HomeTask.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTask.Controllers
{
    public class PostController : Controller
    {
        private readonly AppDbContext db;

        public PostController(AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult Details(int id)
        {
            return View(db.Posts.Find(id));
        }

        
    }
}
