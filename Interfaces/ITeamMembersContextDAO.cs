using final_project_final_project_group_9.Models;

namespace final_project_final_project_group_9.Data
{
    public interface ITeamMembersContextDAO

    {
        //Team Members
        int? AddInfo(TeamMember i);
        List<TeamMember> GetAllInfo();
        TeamMember GetInfoById(int Id);
        int? RemoveInfoById(int Id);
        int? UpdateInfo(TeamMember i);

    }
}