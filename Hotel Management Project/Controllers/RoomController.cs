using Hotel_Management_Project.Models;
using Hotel_Management_Project.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Management_Project.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            RoomDAO rooms = new RoomDAO();

            return View(rooms.GetAllRoom());
        }

        public IActionResult ShowDetails(int RoomID)
        {
            RoomDAO room = new RoomDAO();
            RoomModel foundRoom = room.GetRoomByID(RoomID);
            return View(foundRoom);
        }
    }
}
