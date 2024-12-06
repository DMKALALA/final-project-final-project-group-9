using System.ComponentModel.DataAnnotations;

namespace final_project_final_project_group_9.Models
{
   public class TVShow
    {
        [Key]
        public int ID { get; set; }

        public string ShowName { get; set; }

        public string Genre { get; set; }

        public int NumSeasons { get; set; }

        public DateOnly ReleaseDate { get; set; }
    }

}