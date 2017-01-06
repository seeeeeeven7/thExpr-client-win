using Newtonsoft.Json;
using System.Net.Http;
using ThExpr.Models;
using ThExpr.Utility;
using System;

namespace ThExpr.Services
{
    class UserService
    {
        public static User getUser()
        {
            HttpResponseMessage response = NetworkUtility.GetAsync("user");
            Console.WriteLine(response.StatusCode);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                User user = JsonConvert.DeserializeObject<User>(response.Content.ReadAsStringAsync().Result);
                return user;
            }
            else
            {
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                return null;
            }
        }
    }
}
