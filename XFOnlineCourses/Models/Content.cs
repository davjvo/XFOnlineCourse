using System;

namespace XFOnlineCourses.Models
{
    public class Content
    {
        public bool Current { get; set; }
        public string Description { get; set; }
        public TimeSpan Duration { get; set; }
        public string PlayColor { get { return Current ? "#5D48CA" : "#E4E7F6"; } }
    }
}
