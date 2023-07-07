using SocialMedia.Models;

namespace SocialMedia.Repositories.User_Services
{
    public interface IUserServices
    {
        Task<List<User>?> GetUsers();

        Task<User> GetUsers(int id);

        Task<List<User>> PutUser(int id, User user);

        Task<List<User>> PostUser(User user);

        Task<List<User>> DeleteUser(int id);

        IEnumerable<UserPost> GetPostDetails();

        //IEnumerable<User> GetUserCount();
        public int GetUserCount();

    }
}
