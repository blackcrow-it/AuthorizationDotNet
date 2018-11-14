using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Areas.Identity.Data;

namespace WebApplication3.Controllers
{
    public class ManageUsersController : Controller
    {
        private readonly RoleManager<CustomizeRole> _roleManager;
        private readonly UserManager<CustomizeUser> _customizeManager;
        public ManageUsersController(RoleManager<CustomizeRole> roleManager, UserManager<CustomizeUser> customizeManager)
        {
            _roleManager = roleManager;
            _customizeManager = customizeManager;
        }
        // GET: ManageUsers
        public ActionResult Index()
        {
            IEnumerable<CustomizeUser> listUsers = _customizeManager.Users.Include(u => u.UserRoles).ThenInclude(ur => ur.Role).ToList();
            return View(listUsers);
        }

        // GET: ManageUsers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ManageUsers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ManageUsers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ManageUsers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ManageUsers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ManageUsers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ManageUsers/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}