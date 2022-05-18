using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HouseMata.Models;
using HouseMata.Services;

namespace HouseMata.Services
{   
    public class RequestService : IRequestService
    {
        DataContext DataBase = new DataContext();

        public List<Request> ListOfUserRequest(int id)
        {
            List<Request> ListOfUserRequest = new List<Request>();
            var MyAccount = DataBase.Requests.Include(c => c.User1).Where(x => x.Receiver_ID == id).ToList();
            ListOfUserRequest = MyAccount;
            return (ListOfUserRequest);

        }

        public Friend SearchInUserFriend(int SenderID, int ReceiverID)
        {
            var UserRequests = DataBase.Friends.Where(a => a.friendID == ReceiverID); //returns a single item.
            var SpecificRequestToDelete = UserRequests.Where(a => a.userID == SenderID).FirstOrDefault();
            if (SpecificRequestToDelete != null)
                return SpecificRequestToDelete;
            else
                return null;
        }

        public Request SearchRecord(int SenderID, int ReceiverID)
        {
            var UserRequests = DataBase.Requests.Where(a => a.Receiver_ID == ReceiverID); //returns a single item.
            var SpecificRequestToDelete = UserRequests.Where(a => a.Sender_ID == SenderID).FirstOrDefault();
            if (SpecificRequestToDelete != null)
                return SpecificRequestToDelete;
            else
                return null;
        }

        public void CheckDbRecors(Friend FreiendRecord, Request RequestRecord , int SenderID , int ReceiverID)
        {
            try
            {
                if (FreiendRecord == null)
                {
                    if (RequestRecord == null)
                    {
                        Request NewRequest = new Request();
                        NewRequest.Receiver_ID = ReceiverID;
                        NewRequest.Sender_ID = SenderID;
                        DataBase.Requests.Add(NewRequest);
                        DataBase.SaveChanges();
                    }
                }
            }

            catch (Exception ex) { }
        }

        public void AddFriendsToDb(Request record ,int SenderID, int ReceiverID)
        {
            Friend ReceiverAddToFriend = new Friend();
            ReceiverAddToFriend.userID = record.Receiver_ID;
            ReceiverAddToFriend.friendID = record.Sender_ID;
            DataBase.Friends.Add(ReceiverAddToFriend);
            //save in inverse to appear in friend list for each of them
            Friend SenderAddToFriend = new Friend();
            SenderAddToFriend.userID = record.Sender_ID;
            SenderAddToFriend.friendID = record.Receiver_ID;
            DataBase.Friends.Add(SenderAddToFriend);

            DataBase.Requests.Remove(record);
            DataBase.SaveChanges();
        }
        public void DeleteFromRequest(Request record)
        {
            DataBase.Requests.Remove(record);
            DataBase.SaveChanges();

        }

    }
}