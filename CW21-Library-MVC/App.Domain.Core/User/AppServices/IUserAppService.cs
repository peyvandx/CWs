using App.Domain.Core.Librarian.DTOs;
using App.Domain.Core.User.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.User.AppServices
{
    public interface IUserAppService
    {
        public void CreateLibrarian(UserDto userDto);
        public void UpdateLibrarian(UserDto updatedUserDto);
    }
}
