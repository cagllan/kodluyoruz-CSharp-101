namespace proje_1_telefon_rehberi_uygulamasi
{
    public class SearchRecordManager
    {
        IPhoneBookDal _phoneBookDal;

        public SearchRecordManager(IPhoneBookDal phoneBookDal)
        {
            _phoneBookDal = phoneBookDal;
        }


        public void GetRecordsWithChoise()
        {
            System.Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.\n");
            System.Console.WriteLine("**************************************");
            System.Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            System.Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

            string searchChoise = Console.ReadLine();

            if(searchChoise == "1")
            {
                System.Console.Write("Arama yapmak istediğiniz isim veya soyismi girin: ");
                string searchText = Console.ReadLine();

                if(_phoneBookDal.IsUserThere(searchText))
                {
                    User user = new User();
                    user.FirstName = searchText;
                    user.LastName = searchText;

                    List<User> users = _phoneBookDal.GetAllUsersWithNameSurName(user);

                    System.Console.WriteLine("Arama Sonuçlarınız:");
                    System.Console.WriteLine("**********************************************");
                    foreach(var record in users)
                    {
                        System.Console.WriteLine("İsim               : {0}", record.FirstName);
                        System.Console.WriteLine("Soyisim            : {0}", record.LastName);
                        System.Console.WriteLine("Telefon Numarası   : {0}", record.PhoneNumber);
                        System.Console.WriteLine("-");
                    }
                }
                else
                {
                    System.Console.WriteLine("{0} isimde veya soyisimde herhangi bir kayıt bulunamadı.", searchText);
                }
            }            
            else if(searchChoise == "2")
            {
                System.Console.Write("Arama yapmak istediğiniz numarayı girin: ");
                string searchNumber = Console.ReadLine();

                if(_phoneBookDal.IsUserThere(searchNumber))
                {
                    User user = new User();
                    user.PhoneNumber = searchNumber;
                    

                    List<User> users = _phoneBookDal.GetAllUsersWithPhoneNumber(user);

                    System.Console.WriteLine("Arama Sonuçlarınız:");
                    System.Console.WriteLine("**********************************************");
                    foreach(var record in users)
                    {
                        System.Console.WriteLine("İsim               : {0}", record.FirstName);
                        System.Console.WriteLine("Soyisim            : {0}", record.LastName);
                        System.Console.WriteLine("Telefon Numarası   : {0}", record.PhoneNumber);
                        System.Console.WriteLine("-");
                    }
                }
                else
                {
                    System.Console.WriteLine("{0} numaralı her hangi bir kayıt bulunamadı.", searchNumber);
                }
            }
        }
    }
}