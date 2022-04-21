﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using HandballAPI.Data;
using HandballAPI.Model;

namespace HandballAPI.DataAccessUI
{
    public class UsersDataAccess : IUsersDataAccess
    {
        private readonly HDbContext _hDbContext;

        public UsersDataAccess(HDbContext hDbContext)
        {
            _hDbContext = hDbContext;
        }

        //Get Method
        public IEnumerable<User> GetUsers()
        {
            return _hDbContext.Users.ToList();
        }

        //Get By Id
        public User GetUserById(int userid)
        {
            return _hDbContext.Users.AsNoTracking().Single(p => p.UserId == userid);
        }

        //Add Method
        public void AddUser(User user)
        {
            _hDbContext.Users.Add(user);

            var b = _hDbContext.Users.SingleOrDefault(p => p.UserId == user.UserId);

            _hDbContext.SaveChanges();
        }

        //Update Method
        public void UpdateUser(User user)
        {
            var b = _hDbContext.Users.SingleOrDefault(p => p.UserId == user.UserId);

            b.CloneIt(user);

            _hDbContext.SaveChanges();
        }

        //Delete Method
        public void DeleteUser(int userid)
        {
            var b = _hDbContext.Users.SingleOrDefault(p => p.UserId == userid);

            _hDbContext.Users.Remove(b);

            _hDbContext.SaveChanges();
        }
    }
}