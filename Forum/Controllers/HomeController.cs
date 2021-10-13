using Forum.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Controllers
{
    public class HomeController:Controller
    {
        ThemeContext context;
        //MessageContext msg_context;
        public HomeController(ThemeContext context)
        {
            this.context = context;
            //this.msg_context = msg_context;
        }
        public IActionResult Index()
        {
            var themes = context.Themes.ToList();
            return View(themes);
        }

        [HttpGet]
        public IActionResult Join(int? id, string title)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.Id = id;
            ViewBag.Title = title;
            var msg = context.Messages.Where(x => x.Themenames == title);
            return View(msg);
        }
        [HttpGet]
        public IActionResult Send(int? id, string title)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.Id = id;
            ViewBag.Themenames = title;
            return View();
        }
        [HttpPost]
        public IActionResult Send(Message message)
        {
            if (ModelState.IsValid)
            {
                while(context.Messages.Any(x => x.Id == message.Id))
                {
                    message.Id++;
                }
                context.Messages.Add(message);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(message);
            }
        }
    }
}
