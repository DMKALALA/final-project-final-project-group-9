
using final_project_final_project_group_9.Models;
using Microsoft.AspNetCore.Mvc;

namespace final_project_final_project_group_9.Data
{
    public class TeamMembersContextDAO : ITeamMembersContextDAO
    {
        TeamMembersContext _context;

        public TeamMembersContextDAO(TeamMembersContext context)
        {
            _context = context;
        }

        public int? AddInfo(TeamMember i)
        {
            var data = this.GetInfoById(i.Id);
            if (data != null)
            {
                return null;
            }
            _context.TeamMembers.Add(i);
            return _context.SaveChanges();
        }

        public List<TeamMember> GetAllInfo()
        {
            return _context.TeamMembers.ToList();
        }

        public TeamMember GetInfoById(int ID)
        {
            return _context.TeamMembers.FirstOrDefault(x => x.Id == ID);
        }

        public int? RemoveInfoById(int ID)
        {
            var data = this.GetInfoById(ID);
            if (data == null)
            {
                return null;
            }
            _context.TeamMembers.Remove(data);
            return _context.SaveChanges();
        }

        public int? UpdateInfo(TeamMember i)
        {
            _context.TeamMembers.Update(i);
            return _context.SaveChanges();
        }
        
    }
}
