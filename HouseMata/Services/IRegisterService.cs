using HouseMata.Models;
using HouseMata.ViewModels;
using System.Web;

namespace HouseMata.Services
{
    public interface IRegisterService 
    {
        void SaveUserToDB(SignUpViewModel model);
    }
}