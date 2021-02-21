using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using WebApi.DTOModels;

namespace WebApi.Interfaces
{
    public interface IUserLogic
    {
        Task<List<UserDTO>> GetUsers();
        Task<UserDTO> GetUser(Guid ID);
        Task CreateUser(UserDTO user);
        Task EditUser(Guid ID, UserDTO updateUser);
        Task DeleteUser(Guid ID);
    }
}
