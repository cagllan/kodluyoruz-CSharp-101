namespace proje_1_telefon_rehberi_uygulamasi
{
    public class AddRecordManager
    {
        IPhoneBookDal _phoneBookDal;
        public AddRecordManager(IPhoneBookDal phoneBookDal)
        {
            _phoneBookDal = phoneBookDal;
        }


        public void AddUser(string firstName, string lastName,string phone)
        {
            User user = new User(firstName, lastName, phone);
            _phoneBookDal.Add(user);

        }

        public void ViewRecordOptions()
        {
            string firstName, lastName, phoneNumber;
            
            System.Console.Write("Lütfen isim giriniz           : ");
            firstName = Console.ReadLine();
           

            System.Console.Write("Lütfen soyisim giriniz        : ");
            lastName = Console.ReadLine();
            

            System.Console.Write("Lütfen telefon numarası giriniz: ");
            phoneNumber = Console.ReadLine();
            

            AddUser(firstName, lastName, phoneNumber);
        }
    }
}