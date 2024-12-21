﻿using Entities;

namespace Services
{
    public interface IUserService
    {
        Task<User> AddUser(User user);
        int checkPasswordStrength(string password);
        Task<User> getUserById(int id);
        Task<User> loginUser(string email, string password);
        Task updateUser(int id, User userToUpdate);
    }
}