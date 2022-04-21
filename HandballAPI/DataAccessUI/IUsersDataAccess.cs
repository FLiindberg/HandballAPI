using HandballAPI.Model;
using System.Collections.Generic;

namespace HandballAPI.DataAccessUI
{
    public interface IUsersDataAccess
    {
        IEnumerable<User> GetUsers();
        User GetUserById(int userid);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int userid);
    }
}
