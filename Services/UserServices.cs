using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ViewComponentSys.Domain;

namespace ViewComponentSys.Services
{
    public class UserServices : IUserServices
    {
        string endPoint = "https://jsonplaceholder.typicode.com/users";
        public async Task<User> GetUserAsync(int id)
        {
            using (HttpClient client= new HttpClient())
            {
                var jsonResult = await client.GetStringAsync(endPoint + $"/{id}");
                return JsonConvert.DeserializeObject<User>(jsonResult);
            }
        }
        // Blocking = Asynchronus
        public async Task<List<User>> GetUsersAsync()
        {
            // Dispose Object from Memeory
            HttpClient client = new HttpClient();
            var jsonResult = await client.GetStringAsync(endPoint);
            // List of users as object : JSon to objects
            return JsonConvert.DeserializeObject<List<User>>(jsonResult);
        }
    }
}
