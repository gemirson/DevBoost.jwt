﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBoost.JWT.Model
{
    public class User
    {
        private readonly IList<string> _roles = new List<string>();
        private readonly IList<string> _permissions = new List<string>();

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }


        public IEnumerable<string> Roles => _roles;
        public IEnumerable<string> Permissions => _permissions;

        bool Validate() {
            return this.Username == string.Empty || this.Password == string.Empty;
        }


    }
}
