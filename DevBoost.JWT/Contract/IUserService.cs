using DevBoost.JWT.Helper;
using DevBoost.JWT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBoost.JWT.Contract
{
    public interface IUserService
    {
        Task<Response> Authentication(User user);
    }
}
