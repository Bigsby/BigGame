using System.Collections.Generic;

namespace BigGame.Objects
{
    public class User
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string DisplayName { get; set; }
        public ICollection<UserAccount> Accounts { get; set; }
    }
}
