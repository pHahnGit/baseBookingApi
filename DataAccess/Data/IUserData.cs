using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IUserData
    {
        Task DeleteUser(Guid id);
        Task<UserModel?> GetUser(Guid id);
        Task<UserModel?> GetUserOneLiner(Guid id);
        Task<IEnumerable<UserModel>> GetUsers();
        Task InsertUser(UserModel user);
        Task UpdateUser(UserModel user);
    }
}