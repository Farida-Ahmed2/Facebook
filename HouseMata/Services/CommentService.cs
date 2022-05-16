using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HouseMata.Models;
using HouseMata.ViewModels;

namespace HouseMata.Services
{
    public class CommentService : ICommentService
    {
        private DataContext _context = null;

        public CommentService()
        {
            _context = new DataContext();
        }
        public void SaveCommentToDB(PostComment _commentField, int _userID)
        {
            User _user = _context.Users.Find(_userID);
            Comment _comment = new Comment();
            _comment.writerID = _userID;
            _comment.postID = _commentField._postID;
            _comment.content = _commentField._content;
            _context.Comments.Add(_comment);
            _context.SaveChanges();
        }
    }
}