using Leilao.API.Entities;
using Leilao.API.Interfaces;

namespace Leilao.API.Repositories.DataAccess;

public class UserRepository : IUserRepository
{
    private readonly LeilaoDbContext _dbContext;

    public UserRepository(LeilaoDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public bool ExistUserWithEmaiil(string email)
    {
        return _dbContext.Users.Any(user => user.Email.Equals(email));
    }

    public User GetUserByEmail(string email)
    {
        return _dbContext.Users.First(user => user.Email.Equals(email));
    }
}
