using DTOs;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IContracts
{
    internal interface IAuthentication
    {
        bool Login(LoginDTO LoginDto);
        void Register(NewsWriter newsWriter);
    }
}
