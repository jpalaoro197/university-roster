using System.Collections.Generic;

namespace UniversityRoster.Models
{
  public class Course
    {
        public Course()
        {
            this.JoinEntities = new HashSet<CourseStudent>();
        }

        public int CourseId { get; set; }
        public string Class { get; set; }
        public string Num { get; set; }
        public virtual ICollection<CategoryItem> JoinEntities { get; set; }

    }
}