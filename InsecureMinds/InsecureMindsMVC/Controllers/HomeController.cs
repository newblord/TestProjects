using Business.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsecureMindsMVC.Controllers
{
    public class HomeController : Controller
    {
        private IRoomRepository RoomRepository;

        public HomeController(IRoomRepository roomRepository)
        {
            RoomRepository = roomRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int? id)
        {
            if (!id.HasValue)
            {
                return Json(new { result = "Error", errormsg = "Enter a room number to join." });
            }

            var room = RoomRepository.GetRoom(id.Value);

            if (room == null)
            {
                return Json(new { result = "Error", errormsg = "Unable to find room." });
            }
            else
            {
                return Json(new { result = "Redirect", url = Url.Action("Index", "Room", new { Id = id.Value }) });
            }
        }
    }
}