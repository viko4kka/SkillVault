namespace SkillVault.Modules.Users;

public class UserService : IUserService
{
    private readonly List<User> _users = new();

    public IEnumerable<User> GetAll() => _users;
    public void Add(User user)
    {
        user.Id = Guid.NewGuid();
        _users.Add(user);
    }
}