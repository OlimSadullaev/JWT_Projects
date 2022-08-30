namespace JWTWebApit
{
    public class User
    {
        internal object RefreshToken;

        public string Username { get; set; } = string.Empty;


        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
