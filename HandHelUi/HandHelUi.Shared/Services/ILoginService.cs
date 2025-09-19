
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HandHelUi.Shared.Services
{
    public interface ILoginService
    {
        Task<string> GetLocalStorageItem(string key);
        Task SetLocalStorageItem(string key, string value); 
        Task SetCookie(string name, string value, int days);
        Task SetCookie(string name, object value, int days);
        Task<(bool Success, string Message)> Login(string clientId, string username, string password, string ipAddress);
        //Task RecordUsageLog(string clientId, string username);
        //Task<string> GetRestaurantInformation();
        //Task<string> ValidateAttributes();
        Task ClearSessionData();
        //Task<Dictionary<string, string[]>> GetBillGenCsValues();
        Task ClearAllData();
        Task<string> LoginRequest(string clientId, string username, string password, string ipAddress);
        Task<string> RecordUsageLog(string clientId, string username);
        Task<string> GetRestaurantInformation();
        Task<string> ValidateAttributes();
        Task<Dictionary<string, List<string>>> GetBillGenCsValues();

        // Helper method to get client token
        Task<List<string>> GetClientToken();
    }
}