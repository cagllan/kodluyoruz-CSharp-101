namespace proje_2_todo_uygulamasi
{
    public class TeamMember
    {
        private Dictionary<int, User> teamMembers;
        public Dictionary<int, User> TeamMembers { get => teamMembers; private set => teamMembers = value; }
        public TeamMember(Dictionary<int,User> teamMembers)
        {
            TeamMembers = teamMembers;
        }        
    }
}