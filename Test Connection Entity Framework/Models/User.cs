using System;
using System.Collections.Generic;

#nullable disable

namespace Test_Connection_Entity_Framework.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
