using TimeTracker.Services.Interfaces.Services.Utils;

namespace TimeTracker.Services.Services.Utils
{
    public class HashService : IHashService
    {
        public string HashPassword(string password)
        {
            var passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            return passwordHash;
        }

        public bool Validate(string password, string passwordHash)
        {
            var verified = BCrypt.Net.BCrypt.Verify(password, passwordHash);
            return verified;
        }
    }
}
