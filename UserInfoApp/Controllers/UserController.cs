using Microsoft.AspNetCore.Mvc;
using UserInfoApp.Models;
using System.Collections.Generic;

namespace UserInfoApp.Controllers
{
    public class UserController : Controller
    {
        private static List<UserInfo> users = new List<UserInfo>();

        public IActionResult Index()
        {
            return View(users);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserInfo user)
        {
            user.Id = users.Count + 1;
            users.Add(user);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var user = users.Find(u => u.Id == id);
            if (user != null)
            {
                users.Remove(user);
            }
            return RedirectToAction("Index");
        }
    }
}
