namespace proje_2_todo_uygulamasi
{
    public interface ITeamMemberDal 
    {
        User GetTeamMember(int key);
        TeamMember GetAllTeamMembers();
    }
}