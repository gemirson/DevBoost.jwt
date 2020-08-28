using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBoost.JWT.Model
{
    public class JsonWebToken
    {
        public string AccessToken { get; set; }
        public RefreshToken RefreshToken { get; set; }
        public string TokenType { get; set; } = "bearer";
        public long ExpiresIn { get; set; }
    }
}
