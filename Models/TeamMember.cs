using System.ComponentModel.DataAnnotations;

namespace final_project_final_project_group_9.Models
{
    public class TeamMember
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime Birthdate { get; set; }
        public string CollegeProgram { get; set; }
        public string YearInProgram { get; set; }

        public string GetText()
        {
            return $" {Id} \t {FullName} \t {Birthdate} \t {CollegeProgram} \t {YearInProgram}";
        }
    }

}
