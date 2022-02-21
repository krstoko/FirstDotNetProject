using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstDotNetProject.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }

        public byte[] PasswordHas { get; set; }

        public byte[] PasswordSalt { get; set; }

        public List<Character> Characters { get; set; }
    }
}