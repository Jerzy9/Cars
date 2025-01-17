﻿using Cars.Configuration;
using Cars.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Repositories
{
    public class UserDao : IUserDao
    {

        private readonly ApplicationDbContext _dbcontext;
        public UserDao(ApplicationDbContext db)
        {
            _dbcontext = db;
        }

        public User addUser(User user)
        {
            _dbcontext.Add(user);
            _dbcontext.SaveChanges();
            return user;
        }

        public User editUserById(User user)
        {
            var result = _dbcontext.Information_Users.FirstOrDefault(u => u.id == user.id);
            if (result != null)
            {
                result.name = user.name;
                result.surname = user.surname;
                result.dateOfBirth = user.dateOfBirth;
                result.position = user.position;
                result.email = user.email;
                result.username = user.username;
                _dbcontext.SaveChanges();
                return result;
            }
            return null;
        }

        public List<User> getAllUsers()
        {
            return _dbcontext.Information_Users.OrderBy(u => u.position).ToList();
        }

        public User getUserById(int id)
        {
            return _dbcontext.Information_Users.Where(u => u.id == id).FirstOrDefault();
        }

        public bool removeUserById(int id)
        {
            var result = _dbcontext.Information_Users.FirstOrDefault(u => u.id == id);
            if (result != null)
            {
                _dbcontext.Information_Users.Remove(result);
                _dbcontext.SaveChanges();
                return true;
            }
            return false;
        }

        public int usersLength()
        {
            return getAllUsers().Count;
        }
        public User getUserByEmail(string email)
        {
            return _dbcontext.Information_Users.FirstOrDefault(u => u.email == email);
        }
    }
}
