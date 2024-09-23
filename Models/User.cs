public class User
{
    public int UserId { get; set; }
    public string Name { get; set; } = string.Empty; // Initialize with default value
    public string Phone { get; set; } = string.Empty; // Initialize with default value
    public string Address { get; set; } = string.Empty; // Initialize with default value
    public int CountryId { get; set; }
    public int DepartmentId { get; set; }
    public int MunicipalityId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
