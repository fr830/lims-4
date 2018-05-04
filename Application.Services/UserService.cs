﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Services.Interfaces;
using Domain.Model.Entities;
using Domain.Services;

namespace Application.Services
{
    public class UserService : IUserService
    {
        private IRepository<User> userRepository;
        public UserService(IRepository<User> rep)
        {
            userRepository = rep;
        }
        public IEnumerable<User> GetListOfActiveUsers()
        {
            return userRepository.GetAll();
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetListOfAllUsers()
        {
            return userRepository.GetAll();
            throw new NotImplementedException();
        }
    }
}