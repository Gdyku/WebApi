using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.DTOModels;
using WebApi.Interfaces;
using System;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserLogic _userLogic;
        public UserController(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }
        [HttpGet("getusers")]
        public async Task<List<UserDTO>> GetUsersAsync()
        {
            return await _userLogic.GetUsers();
        }

        [HttpGet("getuser/{id}")]
        public async Task<UserDTO> GetUserAsync(Guid ID)
        {
            return await _userLogic.GetUser(ID);
        }

        [HttpPost]
        public async Task CrateUserAsync(UserDTO user)
        {
            await _userLogic.CreateUser(user);
        }
        
        [HttpPut]
        public async Task EditUserAsync(Guid ID, UserDTO user)
        {
            await _userLogic.EditUser(ID, user);
        }

        [HttpDelete]
        public async Task DeleteUserAsync(Guid ID)
        {
            await _userLogic.DeleteUser(ID);
        }
    }
}
