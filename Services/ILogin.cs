using Models;
using System.Threading.Tasks;

namespace Services
{
    public interface ILogin
    {
        Task<LoginData[]> GetLoginData();
    }
}