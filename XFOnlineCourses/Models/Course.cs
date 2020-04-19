using System.Collections.Generic;

namespace XFOnlineCourses.Models
{
    public class Course
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Background { get; set; }
        public decimal Price { get; set; }
        public List<Content> Content { get; set; }
    }
}
