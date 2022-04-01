namespace proje_2_todo_uygulamasi
{

    public class TeamMemberManager : ITeamMemberService
    {
        ITeamMemberDal _teamMemberDal;

        public TeamMemberManager(ITeamMemberDal teamMemberDal)
        {
            _teamMemberDal = teamMemberDal;
        }
        public TeamMember GetAllTeamMembers()
        {
            return _teamMemberDal.GetAllTeamMembers();
        }

        public User GetTeamMember(int key)
        {
            return _teamMemberDal.GetTeamMember(key);
        }
    }

}