using DevBoost.JWT.Model;
using System.Collections.Generic;

namespace DevBoost.JWT.Repositorio
{
    public class InMemoryContext
    {
        public ISet<User> Users { get; } = new HashSet<User>();
        public ISet<RefreshToken> RefreshTokens { get; } = new HashSet<RefreshToken>();
    }
}
