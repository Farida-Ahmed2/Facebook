using HouseMata.ViewModels;

namespace HouseMata.Services
{
    public interface IReactService
    {
        void SaveReactionToDB(PostReact model, int userID);
    }
}