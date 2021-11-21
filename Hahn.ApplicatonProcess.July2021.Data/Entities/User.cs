using System.Collections.Generic;
namespace Hahn.ApplicatonProcess.July2021.Data.Entities
{
    public class User
    {
        public User() { }
        public int Id { get; set; }
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public List<Asset> Assets { get; set; }
    }
}