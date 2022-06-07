using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace truYum.Controllers
{
    public class MenuItemsController : Controller
    {
        private TruYumContext _context;

        public MenuItemsController()
        {
            _context = new TruYumContext();
        }

        public ActionResult Index(bool? isAdmin)
        {
            var model = _context.MenuItems.Include(m => m.Category).ToList();

            if (isAdmin == true)
            {
                return View("IndexAdmin", model);
            }

            return View(model);
        }

        public ActionResult Admin()
        {
            return RedirectToAction("Index", "Menu", new { isAdmin = true });
        }

        public ActionResult Create()
        {
            var categories = _context.Categories.ToList();
            var viewModel = new MenuItemViewModel
            {
                Categories = categories
            };

            return View("MenuItemForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var menuItem = _context.MenuItems.Find(id);
            if (menuItem is null) { return View("Error"); }

            var viewModel = new MenuItemViewModel()
            {
                MenuItem = menuItem,
                Categories = _context.Categories.ToList()
            };

            return View("MenuItemForm", viewModel);
        }

        [HttpPost]
        public ActionResult Modify(MenuItem menuItem)
        {
            if (menuItem.Id == 0)
            {
                _context.MenuItems.Add(menuItem);
            }
            else
            {
                var menuIteminDb = _context.MenuItems.Find(menuItem.Id);

                if (menuIteminDb is null) { return View("Error"); }

                menuIteminDb.Name = menuItem.Name;
                menuIteminDb.Price = menuItem.Price;
                menuIteminDb.Active = menuItem.Active;
                menuIteminDb.DateOfLauch = menuItem.DateOfLauch;
                menuIteminDb.CategoryId = menuItem.CategoryId;
                menuIteminDb.FreeDelivery = menuItem.FreeDelivery;
            }
            _context.SaveChanges();

            return RedirectToAction("Admin", "Menu");
        }
    }
}
