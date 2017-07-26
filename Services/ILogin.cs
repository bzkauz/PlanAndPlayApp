using Models;
using System.Threading.Tasks;

namespace Services
{
    public interface ILogin<T>
    {
        Task<LoginData[]> GetLoginDataAsync();
        void SendAsync(string UriAdresse);
        
    }
}