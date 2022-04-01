namespace proje_2_todo_uygulamasi
{
    public class TeamMemberDal : ITeamMemberDal
    {        
        TeamMember _teamMember;

        public TeamMemberDal()
        {
            _teamMember = new TeamMember(
                new Dictionary<int,User>()
                    {
                        {1, new User(1, "Claire Bennet")},
                        {2, new User(2, "Peter Petrelli")},
                        {3, new User(3, "Hiro Nakamura")},
                        {4, new User(4, "Niki Sanders")},
                        {5, new User(5, "Sylar")},
                    }
            );
        }

        public User GetTeamMember(int key)
        { 
            if(_teamMember.TeamMembers.ContainsKey(key))
                return _teamMember.TeamMembers.GetValueOrDefault(key);

            return null;            
        }

        public TeamMember GetAllTeamMembers()
        {
            return _teamMember;
        }
    }
}