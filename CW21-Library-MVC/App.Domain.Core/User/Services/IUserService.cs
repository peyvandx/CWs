using App.Domain.Core.User.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.User.Services
{
    public interface IUserService
    {
        public void CreateLibrarian(UserDto userDto);
        public void UpdateLibrarian(UserDto updatedUserDto);
    }
}
