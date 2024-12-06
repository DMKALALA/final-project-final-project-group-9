using Microsoft.EntityFrameworkCore.Query.Internal;

namespace final_project_final_project_group_9.Data
{
    public interface ICoursesContextDAO
    {
        // CRUD operations for CourseEnrollments

        // Create
        int? AddCourse(Course course);

        // Read
        List<Course> GetCourseByID(int? id);

        // Update
        int? UpdateCourse(Course course);

        // Delete
        int? RemoveCourseByID(int id);
    }
}