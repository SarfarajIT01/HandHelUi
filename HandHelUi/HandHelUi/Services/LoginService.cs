using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using HandHelUi.Shared.Services;
using Microsoft.Maui.Storage;

namespace HandHelUi.Services
{
    public class LoginService : ILoginService
    {
        private readonly HttpClient _httpClient;

        public LoginService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> LoginRequest(string clientId, string username, string password, string ipAddress)
        {
            try
            {
                var baseUri = string.IsNullOrEmpty(ipAddress) ? "" : $"http://{ipAddress}";
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseUri);
                    var response = await client.GetAsync($"api/CSATsu_RMS_su2login/{clientId}/{username}/{password}");

                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        var loginModel = JsonSerializer.Deserialize<LoginModel>(result);

                        if (loginModel?.emp_code == "Active")
                        {
                            await SecureStorage.SetAsync("AuthCookie",
                                $"{clientId}~{username}~{password}~{loginModel.Pass_exp}~{loginModel.CompanyName}");
                            return "Active";
                        }
                        return loginModel?.emp_code ?? "Login failed";
                    }
                    return "Server error";
                }
            }
            catch
            {
                return "Connection error";
            }
        }

        public async Task<string> RecordUsageLog(string clientId, string username)
        {
            try
            {
                var clientToken = await GetClientToken();
                var ipAddress = await SecureStorage.GetAsync("IPAddress");
                var log = new { Comp_code = clientId, Mod_code = "CSATHH", user_id = username };

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri($"http://{ipAddress}");
                    client.DefaultRequestHeaders.Add("clientId", clientToken[0]);
                    client.DefaultRequestHeaders.Add("Token", clientToken[1]);

                    var response = await client.PostAsJsonAsync("api/CSATSU_UsageLog", log);
                    return response.IsSuccessStatusCode ? "Success" : "Failed";
                }
            }
            catch
            {
                return "Error";
            }
        }

        public async Task<string> GetRestaurantInformation()
        {
            try
            {
                var clientToken = await GetClientToken();
                var ipAddress = await SecureStorage.GetAsync("IPAddress");

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri($"http://{ipAddress}");
                    client.DefaultRequestHeaders.Add("clientId", clientToken[0]);
                    client.DefaultRequestHeaders.Add("Token", clientToken[1]);

                    var response = await client.GetAsync("api/RMS_RESTINFO_MST");
                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<string> ValidateAttributes()
        {
            try
            {
                var clientToken = await GetClientToken();
                var ipAddress = await SecureStorage.GetAsync("IPAddress");

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri($"http://{ipAddress}");
                    client.DefaultRequestHeaders.Add("clientId", clientToken[0]);
                    client.DefaultRequestHeaders.Add("Token", clientToken[1]);

                    var response = await client.GetAsync("api/CSATSU_RMS_Validation");
                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<Dictionary<string, List<string>>> GetBillGenCsValues()
        {
            try
            {
                var clientToken = await GetClientToken();
                var ipAddress = await SecureStorage.GetAsync("IPAddress");

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri($"http://{ipAddress}");
                    client.DefaultRequestHeaders.Add("clientId", clientToken[0]);
                    client.DefaultRequestHeaders.Add("Token", clientToken[1]);

                    var response = await client.GetAsync("api/BillGenCsValue");
                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadFromJsonAsync<Dictionary<string, List<string>>>();
                    }
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<string>> GetClientToken()
        {
            var authCookie = await SecureStorage.GetAsync("AuthCookie");
            if (!string.IsNullOrEmpty(authCookie))
            {
                var parts = authCookie.Split('~');
                if (parts.Length >= 3)
                {
                    return new List<string> { parts[0], parts[2] }; // clientId and token
                }
            }
            return new List<string> { "", "" };
        }

        public Task<string> GetLocalStorageItem(string key)
        {
            throw new NotImplementedException();
        }

        public Task SetLocalStorageItem(string key, string value)
        {
            throw new NotImplementedException();
        }

        public Task SetCookie(string name, string value, int days)
        {
            throw new NotImplementedException();
        }

        public Task SetCookie(string name, object value, int days)
        {
            throw new NotImplementedException();
        }

        public Task<(bool Success, string Message)> Login(string clientId, string username, string password, string ipAddress)
        {
            throw new NotImplementedException();
        }

        public Task ClearSessionData()
        {
            throw new NotImplementedException();
        }

        public Task ClearAllData()
        {
            throw new NotImplementedException();
        }
    }

    public class LoginModel
    {
        public string emp_code { get; set; }
        public string Token { get; set; }
        public string Pass_exp { get; set; }
        public string CompanyName { get; set; }
    }
}