using System.ComponentModel.DataAnnotations;

namespace final_project_final_project_group_9
{
    public class Course
    {
        [Key]
        public int ID { get; set; }
        public string CourseNumber { get; set; }

        public string CourseName { get; set; }

        public string Track { get; set; }

        public int CreditHours { get; set; }
    }
}
