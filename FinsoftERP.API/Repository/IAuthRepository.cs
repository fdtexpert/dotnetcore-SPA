using System.Threading.Tasks;
using FinsoftERP.API.Models;

namespace FinsoftERP.API.Repository
{
    public interface IAuthRepository
    {

         Task<User> Register(User user, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExists(string username);
         
    }
}