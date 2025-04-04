namespace Application.Common.Interfaces
{
    public interface IUserRoleRepository
    {
        Task<List<string>> GetUserRoleAsync(Guid userId);
    }
}
