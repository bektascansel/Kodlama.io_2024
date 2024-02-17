using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Course:IEntity
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int InstructorId { get; set; }
        [JsonIgnore]
        public Instructor Instructor { get; set; }
        public int CategoryId { get; set; }
        [JsonIgnore]
        public Category Category { get; set; }


    }
}
