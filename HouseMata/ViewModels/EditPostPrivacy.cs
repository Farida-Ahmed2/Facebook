using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HouseMata.ViewModels
{
    public class EditPostPrivacy
    {
        public int postID { get; set; }
        public int userID { get; set; }
        public int typeOfPrivacy { get; set; }
    }
}