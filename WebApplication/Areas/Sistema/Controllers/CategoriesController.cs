using Layer_Business.BL;
using Layer_Support.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Areas.Sistema.Controllers
{
    public class CategoriesController : Controller
    {

        private CategoryBL CategoryBL = new CategoryBL();

        // GET: Sistema/Categories
        public async Task<ActionResult> Index()
        {
            try
            {
                var lst =await CategoryBL.GetAll();
                return View(lst);
            }
            catch (Exception ex)
            {

                ModelState.AddModelError("Error al intentar recuperar los datos, comuniquese con el administrador",ex.Message);
            }
            return View();
        }

        // GET: Sistema/Categories/Details/5
        public async Task<ActionResult> Details(int id)
        {
            try
            {
                var category =await CategoryBL.GetById(id);
                 return View(category);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al intentar recuperar la informacion del registro,comuniquese conel administrador", ex.Message);
            }
            return View();
        }

        // GET: Sistema/Categories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sistema/Categories/Create
        [HttpPost]
        public async Task<ActionResult> Create(Category category)
        {
            try
            {
                try
                {
                    if (ModelState.IsValid)
                    {
                        await CategoryBL.Create(category);
                        return RedirectToAction("Index");

                    }

                    
                }
                catch (Exception ex)
                {

                    ModelState.AddModelError("Error al intentar guardar el registro, comuniquese con el administrador", ex.Message);
                }
                    
                return View(category);
               
            }
            catch
            {
                return View();
            }
        }

        // GET: Sistema/Categories/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            try
            {
                var category = await CategoryBL.GetById(id);
                return View(category);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al intentar recuperar la informacion del registro,comuniquese conel administrador", ex.Message);
            }
            return View();
        }

        // POST: Sistema/Categories/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(int id, Category category)
        {
            try
            {
                var model = await CategoryBL.GetById(id);

                if (id!=category.Id)
                {
                    return HttpNotFound();
                }

                await CategoryBL.Edit(category);


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sistema/Categories/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sistema/Categories/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
