using System.Threading.Tasks;

public interface IUserRepository
{
    Task<int> RegisterUserAsync(User user);
}
