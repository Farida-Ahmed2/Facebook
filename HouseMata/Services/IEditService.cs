using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HouseMata.Models;
using HouseMata.ViewModels;

namespace HouseMata.Services
{
    public interface IEditService
    {
       User ViewEdit(int userId);
       void SaveEdit(User userE, int userId);
    }

}