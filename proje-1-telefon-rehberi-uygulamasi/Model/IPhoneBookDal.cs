namespace proje_1_telefon_rehberi_uygulamasi
{

    public interface IPhoneBookDal {
        void Add(User user);        
        void Delete(User user);
        void Update(User user);
        User GetUser(User user);
        List<User> GetAllUsers();
        List<User> GetAllUsersWithNameSurName(User user);
        List<User> GetAllUsersWithPhoneNumber(User user);
        bool IsUserThere(string searchText);
    }
    
}