using final_project_final_project_group_9.Data;
using final_project_final_project_group_9.Models;

namespace final_project_final_project_group_9.Interfaces
{
    public interface IFoodsContextDAO
    {
        int? AddFood(FavoriteFoods personsFood);
        List<FavoriteFoods> GetAllFoods();
        
        FavoriteFoods GetFoodById(int id);
        int? RemoveFoodById(int id);
        int? UpdateFood(FavoriteFoods personsFood);
    }
}


