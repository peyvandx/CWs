using App.Domain.Core.Librarian.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Librarian.AppServices
{
    public interface ILibrarianAppService
    {
        public void CreateLibrarian(LibrarianDto librarianDto);
        public void UpdateLibrarian(LibrarianDto updatedLibrarianDto);
    }
}
