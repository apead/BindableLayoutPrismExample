using System.Collections.Generic;

namespace PrismBindable.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public IEnumerable<Follower> TopFollowers { get; set; }
        public IEnumerable<string> FavoriteTech { get; set; }
        public IEnumerable<string> Achievements { get; set; }
    }
}
