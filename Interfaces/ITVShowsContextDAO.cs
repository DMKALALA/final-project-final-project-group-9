using final_project_final_project_group_9.Models;

namespace final_project_final_project_group_9.Interfaces
{
    public interface ITVShowsContextDAO
    {
        // CRUD operations for FavoriteTVShows

        // Create
        int? AddTVShow(TVShow tvShow);

        // Read
        List<TVShow> GetTVShowByID(int? id);

        // Update
        int? UpdateTVShow(TVShow tvShow);

        // Delete
        int? RemoveTVShowByID(int id);
    }
}
