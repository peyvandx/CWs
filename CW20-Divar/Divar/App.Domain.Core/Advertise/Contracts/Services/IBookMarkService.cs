﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Advertise.Contracts.Services
{
    public interface IBookMarkService
    {
        void AddToBookMarksList(Advertise.Entities.Advertise advertise, User.Entities.User user);
        void RemoveFromBookMarksList(Advertise.Entities.Advertise advertise, User.Entities.User user);
    }
}
