using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;
using WebApi.DTOModels;
using AutoMapper;
using WebApi.Interfaces;
using System.Linq;
using System.Threading;
using System;

namespace WebApi.Logic
{
    public class UserLogic : IUserLogic
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;
        public UserLogic(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<UserDTO>> GetUsers()
        {
            var users = await _context.Users.Include(p => p.Product).ToListAsync();
            var mappedUsers = _mapper.Map<List<User>,List<UserDTO>>(users);


            return mappedUsers;
        }

        public async Task<UserDTO> GetUser(Guid ID)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.ID == ID);
            var mappedUser = _mapper.Map<User, UserDTO>(user);

            return mappedUser;
        }

        public async Task CreateUser(UserDTO user)
        {
            var mappedUser = _mapper.Map<UserDTO, User>(user);

            if (user.Name == "chuj")
                throw new Exception("Nie możesz nazywać się chuj");

            _context.Users.Add(mappedUser);
            await _context.SaveChangesAsync();
        }

        public async Task EditUser(Guid ID, UserDTO updateuser)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.ID == ID);
            
            if(user == null)
                throw new Exception("Couldn't find user");

            user.Name = updateuser.Name ?? user.Name;
            user.Password = updateuser.Password ?? user.Password;

            await _context.SaveChangesAsync();
        }

        public async Task DeleteUser(Guid ID)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.ID == ID);

            _context.Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}
