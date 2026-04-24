using UserManagementAPI.Models;

namespace UserManagementAPI.Services;

public class UserService
{
    private readonly List<User> _users = [];
    private int _nextId = 1;

    public List<User> GetAll() => _users;

    public User? GetById(int id) => _users.FirstOrDefault(user => user.Id == id);

    public User Create(User user)
    {
        user.Id = _nextId++;
        _users.Add(user);
        return user;
    }

    public bool Update(int id, User updatedUser)
    {
        var existingUser = _users.FirstOrDefault(user => user.Id == id);
        if (existingUser is null)
        {
            return false;
        }

        existingUser.Name = updatedUser.Name;
        existingUser.Email = updatedUser.Email;
        existingUser.Age = updatedUser.Age;
        return true;
    }

    public bool Delete(int id)
    {
        var existingUser = _users.FirstOrDefault(user => user.Id == id);
        if (existingUser is null)
        {
            return false;
        }

        _users.Remove(existingUser);
        return true;
    }
}
