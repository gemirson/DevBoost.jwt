using System;

namespace DevBoost.JWT.Model
{
    public class RefreshToken
    {
        public string Username { get; set; }
        public string Token { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}