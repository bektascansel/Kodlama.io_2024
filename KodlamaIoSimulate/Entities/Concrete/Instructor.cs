using Entities.Abstract;
using System.Text.Json.Serialization;

namespace Entities.Concrete
{
    public class Instructor :IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }

        [JsonIgnore]
        public List<Course> Courses { get; set; }
        
    }
}