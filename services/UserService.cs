public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<int> RegisterUserAsync(UserRegistrationDto userDto)
    {
        var user = new User
        {
            Name = userDto.Name,
            Phone = userDto.Phone,
            Address = userDto.Address,
            CountryId = userDto.CountryId,
            DepartmentId = userDto.DepartmentId,
            MunicipalityId = userDto.MunicipalityId
        };

        return await _userRepository.RegisterUserAsync(user);
    }
}
