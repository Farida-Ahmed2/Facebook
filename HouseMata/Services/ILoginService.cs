using HouseMata.Models;
using HouseMata.ViewModels;

namespace HouseMata.Services
{
    public interface ILoginService
    {
        User IsValidUser(LoginViewModel model);
    }
}