using JBrick.BL.EquipmentGuide;
using JBrick.Client.Web.Core.Controllers;
using JBrick.Contracts.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JBrick.Client.Web.EquipmentGuide.Controllers
{
    public class EquipmentGuideController : ECIControllerBase
    {
        ICooperRatingBusinessService _service;
        string _uowImplementation = "";

        public EquipmentGuideController(ICooperRatingBusinessService service)
        {
            _service = service;

            ViewBag.UoWProvider = string.Format("The current Unit of Work impelmentation is {0}", _service.GetUnitOfWorkProviderType());
        }

        // GET: EquipmentGuide
        public ActionResult Index()
        {
            var model = _service.FetchAllCooperRating();

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var model = _service.FetchCooperRating(id);
            return View(model);
        }

        // GET: EquipmentGuide/Create
        public ActionResult Create()
        {
            var model = new CooperRatingModel();
            return View(model);
        }

        // POST: EquipmentGuide/Create
        [HttpPost]
        public ActionResult Create(CooperRatingModel model)
        {
            try
            {
                _service.CreateCooperRating(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EquipmentGuide/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _service.FetchCooperRating(id);
            return View(model);
        }

        // POST: EquipmentGuide/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, CooperRatingModel model)
        {
            try
            {
                _service.UpdateCooperRating(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EquipmentGuide/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _service.FetchCooperRating(id);
            return View(model);
        }

        // POST: EquipmentGuide/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, CooperRatingModel model)
        {
            try
            {
                _service.DeleteCooperRating(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
