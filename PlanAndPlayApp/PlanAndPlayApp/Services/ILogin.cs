using PlanAndPlayApp.Models;
using System.Threading.Tasks;

namespace PlanAndPlayApp.Services
{
    public interface ILogin
    {
        Task<LoginData[]> GetLoginData();
    }
}