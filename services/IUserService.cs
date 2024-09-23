using System.Threading.Tasks;

public interface IUserService
{
    Task<int> RegisterUserAsync(UserRegistrationDto userDto);
}
