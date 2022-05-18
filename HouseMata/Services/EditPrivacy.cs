using HouseMata.Models;
using HouseMata.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HouseMata.Services
{
    public class EditPrivacy : IEditPrivacy
    {
        private DataContext db = null;

        public EditPrivacy()
        {
            db = new DataContext();
        }
        public void Edit(EditPostPrivacy model)
        {
            Post post = db.Posts.SingleOrDefault(x => model.userID == x.userID && x.postID == model.postID);
            post.privacyType = model.typeOfPrivacy;
            db.Entry(post).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return;
        }
    }
}