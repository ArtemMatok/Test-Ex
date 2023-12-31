﻿using Test_Ex.Models;

namespace Test_Ex.Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUserById(int id);
        
        bool Create(User user);
        bool Update(User user); 
        bool Delete(User user);
        bool Save();

    }
}
