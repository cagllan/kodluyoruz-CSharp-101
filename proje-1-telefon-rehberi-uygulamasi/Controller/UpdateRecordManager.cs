namespace proje_1_telefon_rehberi_uygulamasi
{
    public class UpdateRecordManager
    {
        IPhoneBookDal _phoneBookDal;
        public UpdateRecordManager(IPhoneBookDal phoneBookDal)
        {
            _phoneBookDal = phoneBookDal;            
        }


        public void UpdateUserRecord(User user)
        {
            _phoneBookDal.Update(user);
        }

        public void viewUpdateOptions()
        {
            System.Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            

            string userText = Console.ReadLine();

            

            if(_phoneBookDal.IsUserThere(userText))
            {
                User searchingUser = new User();
                searchingUser.FirstName = userText;
                searchingUser.LastName = userText;
                

                    System.Console.WriteLine("Lütfen yeni numarayı girin: ");
                    string newNumber = Console.ReadLine();                    

                    User newUser = _phoneBookDal.GetUser(searchingUser);
                    newUser.PhoneNumber = newNumber;

                    UpdateUserRecord(newUser);

                    
                    System.Console.WriteLine("{0} isimli kişinin numarası güncellendi.", userText);
                
            }
            else
            {
                System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");

                System.Console.WriteLine("* Güncellemeyi sonlandırmak için    : (1)");
                System.Console.WriteLine("* Yeniden denemek için              : (2)");

                string updateChoise = Console.ReadLine();

                if(updateChoise == "1")
                {
                    System.Console.WriteLine("Güncelleme sonlandırıldı.");
                    return;
                }
                else if(updateChoise == "2")
                {
                    viewUpdateOptions();
                }
            }
        }
    }
}