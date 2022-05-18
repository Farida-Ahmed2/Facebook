using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HouseMata.Models;
using HouseMata.Services;

namespace HouseMata.Controllers
{
    public class RequestsController : Controller
    {
        DataContext DataBase = new DataContext();
        IRequestService UserRequest = new RequestService();
        // GET: Requests

        public ActionResult viewRequest(int id)
        {
            id = Convert.ToInt32(Session["uId"]);
            List<Request> ListOfUserRequests = UserRequest.ListOfUserRequest(id);
            ViewBag.ID = id; //which user account 
            return View(ListOfUserRequests);
        }


        public ActionResult RejectRequest(int SenderID, int ReceiverID)
        {
            var record = UserRequest.SearchRecord(SenderID, ReceiverID);
            UserRequest.DeleteFromRequest(record);
            return RedirectToAction("viewRequest", new { id = ReceiverID });
        }

        public ActionResult AcceptRequest(int SenderID, int ReceiverID)
        {
            var record = UserRequest.SearchRecord(SenderID, ReceiverID);
            UserRequest.AddFriendsToDb(record, SenderID, ReceiverID);
            return RedirectToAction("viewRequest", new { id = ReceiverID });
        }

       

        public ActionResult SendFriendRequest()
        {
            int SenderID = Convert.ToInt32(Session["uId"]);
            int ReceiverID = Convert.ToInt32(Session["Id"]);
            var FreiendRecord = UserRequest.SearchInUserFriend(SenderID, ReceiverID);
            var RequestRecord = UserRequest.SearchRecord(SenderID, ReceiverID);
            UserRequest.CheckDbRecors(FreiendRecord, RequestRecord, SenderID, ReceiverID);
            return RedirectToAction("viewPosts", "Profile", Session["Id"] = ReceiverID);
        }




    }
}