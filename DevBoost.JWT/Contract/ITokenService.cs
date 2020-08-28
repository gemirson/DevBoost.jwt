using DevBoost.JWT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBoost.JWT.Service
{
    public interface ITokenService
    {
        JsonWebToken CreateJWT(User user);
    }
}
