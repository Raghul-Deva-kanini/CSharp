using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialMedia.data;
using SocialMedia.Models;

namespace SocialMedia.Repositories.User_Services
{
    public class UserServices:IUserServices
    {
        public DataDBContext _dataDBContext;

        public UserServices(DataDBContext dataDBContext)
        {
            _dataDBContext = dataDBContext;
        }

        public async Task<List<User>?> GetUsers()
        {
            var user = await _dataDBContext.Users.ToListAsync();
            return user;
        }

        public async Task<User> GetUsers(int id)
        {
            var user = await _dataDBContext.Users.FindAsync(id);
            if (user is null)
            {
                return null;
            }
            return user;
        }

        public async Task<List<User>> PutUser(int id, User user)
        {
            var users = await _dataDBContext.Users.FindAsync(id);
            if (users is null)
            {
                return null;
            }
            users.UserId = user.UserId;
            users.UserName = user.UserName;
            users.UserEmail = user.UserEmail;
            users.UserPhone = user.UserPhone;
            users.Age = user.Age;

            await _dataDBContext.SaveChangesAsync();
            return await _dataDBContext.Users.ToListAsync();   
        }

        public async Task<List<User>> PostUser(User user)
        {
            _dataDBContext.Users.Add(user);
            await _dataDBContext.SaveChangesAsync();
            return await _dataDBContext.Users.ToListAsync();
            
        }

        public async Task<List<User>> DeleteUser(int id)
        {
            var user = _dataDBContext.Users.Find(id);
            _dataDBContext.Remove(user);
            await _dataDBContext.SaveChangesAsync();
            return await _dataDBContext.Users.ToListAsync();
        }
        //Temp
        
        public IEnumerable<UserPost> GetPostDetails()
        {
            //Working with multiple tables using LINQ JOin
            var post = (from p in _dataDBContext.Posts
                        join u in _dataDBContext.Users on p.UserId equals u.UserId
                        select new UserPost
                        {
                            UserName = u.UserName,
                            Title = p.Title,
                            Description = p.Description
                        }).ToList();
            return post;
        }

        public int GetUserCount()
        {
            /*var count = from user in _dataDBContext.Users group user by user.UserId into u select u.Count();
            return count;*/

            int count = _dataDBContext.Users.Count();
            return count;
        }


    }
}
