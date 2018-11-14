using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Areas.Identity.Data;

namespace WebApplication3.Controllers
{
    public class ManageRolesController : Controller
    {
        private readonly RoleManager<CustomizeRole> _roleManager;

        public ManageRolesController(RoleManager<CustomizeRole> roleManager)
        {
            _roleManager = roleManager;
        }
        // GET: ManageRoles
        public ActionResult Index()
        {
            return View(_roleManager.Roles.ToList());
        }

        // GET: ManageRoles/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ManageRoles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ManageRoles/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string name)
        {
            try
            {
                var result = _roleManager.CreateAsync(new CustomizeRole(name)).Result;

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ManageRoles/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ManageRoles/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync(string id, string name)
        {
            try
            {
                var role = await _roleManager.FindByIdAsync(id);
                if (role != null)
                {
                    role.Name = name;
                    var result = await _roleManager.UpdateAsync(role);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ManageRoles/Delete/5
        public async Task<ActionResult> DeleteAsync(string id)
        {
            try
            {
                var role = await _roleManager.FindByIdAsync(id);
                if (role != null)
                {
                    var result = await _roleManager.DeleteAsync(role);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: ManageRoles/Delete/5
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