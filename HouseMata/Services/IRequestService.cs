using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HouseMata.Models;

namespace HouseMata.Services
{
    public interface IRequestService
    {
        List<Request> ListOfUserRequest(int id);
        Friend SearchInUserFriend(int SenderID, int ReceiverID);
        Request SearchRecord(int SenderID, int ReceiverID);
        void CheckDbRecors(Friend FreiendRecord, Request RequestRecord, int SenderID, int ReceiverID);
        void AddFriendsToDb(Request record, int SenderID, int ReceiverID);
        void DeleteFromRequest(Request record);
    }
}
