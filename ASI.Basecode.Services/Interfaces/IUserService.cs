using ASI.Basecode.Data.Models;
using ASI.Basecode.Services.ServiceModels;
using System;
using static ASI.Basecode.Resources.Constants.Enums;

namespace ASI.Basecode.Services.Interfaces
{
    public interface IUserService
    {
        LoginResult AuthenticateUser(Guid userid, string password, ref User user);
        void AddUser(UserViewModel model, Guid executedBy);
    }
}
