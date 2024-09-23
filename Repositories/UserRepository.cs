using Dapper;
using Npgsql;
using System.Data;
using System.Threading.Tasks;

public class UserRepository : IUserRepository
{
    private readonly string _connectionString;

    public UserRepository(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DefaultConnection");
    }

    public async Task<int> RegisterUserAsync(User user)
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            var parameters = new DynamicParameters();
            parameters.Add("@p_name", user.Name);
            parameters.Add("@p_phone", user.Phone);
            parameters.Add("@p_address", user.Address);
            parameters.Add("@p_country_id", user.CountryId);
            parameters.Add("@p_department_id", user.DepartmentId);
            parameters.Add("@p_municipality_id", user.MunicipalityId);
            parameters.Add("@p_user_id", dbType: DbType.Int32, direction: ParameterDirection.Output);

            await connection.ExecuteAsync("sp_register_user", parameters, commandType: CommandType.StoredProcedure);

            return parameters.Get<int>("@p_user_id");
        }
    }
}
