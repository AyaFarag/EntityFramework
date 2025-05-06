

using System.ComponentModel.DataAnnotations;

namespace CodeFirstApp
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int? Age { get; set; }
        public ICollection<Course> Courses { get; set; }

        [Timestamp]
        public DateTime? Created_at { get; set; }
        [Timestamp]
        public DateTime? Updated_at { get;set; }
    }
}
