using HouseMata.ViewModels;

namespace HouseMata.Services
{
    public interface ICommentService
    {
        void SaveCommentToDB(PostComment model, int userID);
    }
}