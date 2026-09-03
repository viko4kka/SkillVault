namespace SkillVault.Modules.Users;

public interface IUserService
{
    IEnumerable<User> GetAll();
    void Add(User user);
}