namespace proje_2_todo_uygulamasi
{

    public interface ITeamMemberService {
        User GetTeamMember(int key);
        TeamMember GetAllTeamMembers();
    }

}