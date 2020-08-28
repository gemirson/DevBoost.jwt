using DevBoost.JWT.Model;
using System.Collections.Generic;
using System.Linq;

namespace DevBoost.JWT.Service
{
    public  class UserRepository:IUserRepository
    {
        private List<User> users;
        public UserRepository()
        {
            users = new List<User>();
        }
       
        public  void Add(int id, string username, string password, string role) {
            users.Add(new User { Id = id, Username = username, Password = password, Role = role});
        }
        public  User Get(string username, string password)
        {           
            users.Add(new User { Id = 1, Username = "jose",  Password = "jose",  Role = "manager" });
            users.Add(new User { Id = 2, Username = "paulo", Password = "paulo", Role = "employee" });
            users.Add(new User { Id = 3, Username = "mauro", Password = "mauro", Role = "manager" });
            users.Add(new User { Id = 4, Username = "pedro", Password = "pedro", Role = "employee" });
            return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == x.Password).FirstOrDefault();
        }
    }
}
