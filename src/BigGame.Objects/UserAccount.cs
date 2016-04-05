namespace BigGame.Objects
{
    public class UserAccount
    {
        public string UserUsername { get; set; }
        public User User { get; set; }
        public string Account { get; set; }
        public int ProviderId { get; set; }
        public IdentityProvider Provider { get; set; }
    }
}
