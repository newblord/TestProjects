using Business.Interfaces.Repositories;
using Business.SqlClient.Models;
using Business.SqlClient.Repositories;
using InsecureMindsMVC.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;

namespace InsecureMindsMVC.Controllers
{
    public class RoomController : Controller
    {
        private IRoomRepository RoomRepository;
        private IExpansionRepository ExpansionRepository;
        private IPickTypeRepository PickTypeRepository;
        private ICardRepository CardRepository;
        private IRoomCardRepository RoomCardRepository;
        private IHouseRuleRepository HouseRuleRepository;

        public RoomController(IRoomRepository roomRepository,
                              IExpansionRepository expansionRepo,
                              IPickTypeRepository pickTypeRepo,
                              ICardRepository cardRepository,
                              IRoomCardRepository roomCardRepository,
                              IHouseRuleRepository houseRuleRepository)
        {
            RoomRepository = roomRepository;
            ExpansionRepository = expansionRepo;
            PickTypeRepository = pickTypeRepo;
            CardRepository = cardRepository;
            RoomCardRepository = roomCardRepository;
            HouseRuleRepository = houseRuleRepository;
        }

        // GET: Room
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RoomSettings()
        {
            var model = new RoomSettingsModel()
            {
                Expansions = ExpansionRepository.GetExpansions(),
                PickTypes = PickTypeRepository.GetPickTypes().Where(x => x.Type != "None"),
                HouseRules = HouseRuleRepository.GetHouseRules()
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult CreateGame(int[] pickTypeIds, int[] expansionPackIds, int[] houseRuleIds)
        {
            var cards = CardRepository.GetCards(pickTypeIds, expansionPackIds);

            var r = new Random();

            var blackCards = cards.Where(x => x.CardTypeId == Business.Enums.CardType.Black).OrderBy(x => r.Next()).ToList();
            var whiteCards = cards.Where(x => x.CardTypeId == Business.Enums.CardType.White).OrderBy(x => r.Next()).ToList();

            var room = RoomRepository.CreateRoom();

            RoomCardRepository.CreateRoomCards(room, blackCards, whiteCards);

            return Json(new { result = "Redirect", url = Url.Action("JoinGame", "Room") });
        }

        [HttpPost]
        public ActionResult ViewCards(int expansionId)
        {
            var model = new ViewCardsModel()
            {
                Expansion = ExpansionRepository.GetExpansion(expansionId),
                Cards = CardRepository.GetCards(expansionId)
            };

            return PartialView(model);
        }
    }
}