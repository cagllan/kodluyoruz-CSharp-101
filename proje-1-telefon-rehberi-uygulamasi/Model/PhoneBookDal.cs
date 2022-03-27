namespace proje_1_telefon_rehberi_uygulamasi
{
    public class PhoneBookDal:IPhoneBookDal
    {
        List<User> _phoneBook;

        public PhoneBookDal()
        {
            _phoneBook = new List<User>{
                new User("Anna","Torv","1111111"),
                new User("John","Noble","2222222"),
                new User("Gillian","Anderson","3333333"),
                new User("David","Duchovny","4444444"),
                new User("Hugh","Laurie","5555555")
                };

        }

        public void Add(User user)
        {
            _phoneBook.Add(user);
        }

        public void Delete(User user)
        {
            foreach (var item in _phoneBook)
            {
                if(item.FirstName.ToLower() == user.FirstName.ToLower() || item.LastName.ToLower() == user.LastName.ToLower())
                {
                    _phoneBook.Remove(item);
                    break;
                }
            }
            
        }

        public User GetUser(User user)
        {

            foreach(var item in _phoneBook)
            {
                if(item.FirstName.ToLower() == user.FirstName.ToLower() || item.LastName.ToLower() == user.LastName.ToLower())
                {
                    return item;
                }
            }
            return null;
        }

        public List<User> GetAllUsers()
        {
            return _phoneBook;
        }

        public void Update(User user)
        {

            foreach(var item in _phoneBook)
            {
                if(item.FirstName.ToLower() == user.FirstName.ToLower() || item.LastName.ToLower() == user.LastName.ToLower())
                {
                    item.PhoneNumber = user.PhoneNumber;
                    return;
                }
            }            

        }


        public bool IsUserThere(string searchText)
        {
            foreach (var user in _phoneBook)
            {
                if(user.FirstName.ToLower() == searchText.ToLower() || user.LastName.ToLower() == searchText.ToLower() || user.PhoneNumber == searchText)
                {
                    return true;
                }
                
            }

            return false;
        }


        public List<User> GetAllUsersWithNameSurName(User user)
        {
            List<User> newList = new List<User>();

            foreach (var item in _phoneBook)
            {
                if(item.FirstName.ToLower() == user.FirstName.ToLower() || item.LastName.ToLower() == user.LastName.ToLower())
                {
                    newList.Add(item);
                }
            }

            return newList;
        }

        public List<User> GetAllUsersWithPhoneNumber(User user)
        {
            List<User> newList = new List<User>();

            foreach (var item in _phoneBook)
            {
                if(item.PhoneNumber.ToLower() == user.PhoneNumber.ToLower())
                {
                    newList.Add(item);
                }
            }

            return newList;
        }
    }
}