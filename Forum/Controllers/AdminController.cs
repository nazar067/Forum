using Forum.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Controllers
{
    [Authorize]
    public class AdminController:Controller
    {
        ThemeContext context;
        public AdminController(ThemeContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.Themes.ToList());
        }
        public IActionResult Create(int? themeId)
        {
            if (themeId == null)
            {
                return View();
            }
            else
            {
                return View(context.Themes.FirstOrDefault(x => x.Id == themeId));
            }
        }
        [HttpPost]
        public IActionResult Create(Theme theme)
        {
            if (theme.Id == 0)
            {
                context.Themes.Add(theme);
            }
            else
            {
                context.Update(theme);
            }
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(int themeId)
        {
            var themeToDelete = context.Themes.Find(themeId);
            context.Themes.Remove(themeToDelete);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
