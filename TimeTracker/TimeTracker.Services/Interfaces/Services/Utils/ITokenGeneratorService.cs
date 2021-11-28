namespace TimeTracker.Services.Interfaces.Services.Utils
{
    public interface ITokenGeneratorService
    {
        string GenerateToken(int userId);
    }
}
