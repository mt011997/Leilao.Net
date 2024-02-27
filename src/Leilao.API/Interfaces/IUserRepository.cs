using Leilao.API.Entities;

namespace Leilao.API.Interfaces;

public interface IUserRepository
{
    bool ExistUserWithEmaiil(string email);
    User GetUserByEmail(string email);
}
