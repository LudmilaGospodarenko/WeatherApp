using System.Collections.Generic;

namespace WeatherApp.Logic
{
    public class UserList
    {
        string user1 = "Lyudmila Gospodarenko";
        string user2 = "Sergey Gospodarenko";

        public List<string> getUsers()
        {
            var users = new List<string> { user1 };
            return users;
        }
    }
}
