using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HouseMata.Models;
using HouseMata.ViewModels;

namespace HouseMata.Services
{
    public class ReactService : IReactService
    {
        private DataContext _context = null;

        public ReactService()
        {
            _context = new DataContext();
        }
        public void SaveReactionToDB(PostReact _reactionField, int _userID)
        {
            User _user = _context.Users.Find(_userID);
            React _react = new React();
            _react.userID = _userID;
            _react.postID = _reactionField._postID;
            _react.typeOfReact = _reactionField._reaction;
            _context.Reacts.Add(_react);
            _context.SaveChanges();
        }
    }
}