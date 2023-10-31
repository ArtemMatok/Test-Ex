using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test_Ex.Data;
using Test_Ex.Models;
using Test_Ex.Repository;

namespace Test_Ex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("GetAllUsers")]
        public async Task<IEnumerable<User>> GetAllUser()
        {
            return await _userRepository.GetAllUsers();
        }

        [HttpPost("Create")]
        public User Crete(User user)
        {
            _userRepository.Create(user);
            return user;    
        }

        [HttpPut("Update/{id}")]
        public async Task<User> Update(int id, User user)
        {
            var updateUser = await _userRepository.GetUserById(id);
            updateUser.Name = user.Name;
            updateUser.Email = user.Email;  
            updateUser.Phone = user.Phone;
            _userRepository.Update(updateUser);
            return updateUser;
        }

        [HttpDelete("Delete/{id}")]
        public async Task<ActionResult<User>> Delete(int id)
        {
            var userDelete =await  _userRepository.GetUserById(id);
            _userRepository.Delete(userDelete);
            return Ok("Deleted");

        }

    }
}
