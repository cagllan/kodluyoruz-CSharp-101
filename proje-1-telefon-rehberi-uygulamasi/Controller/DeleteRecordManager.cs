namespace proje_1_telefon_rehberi_uygulamasi
{
    public class DeleteRecordManager
    {
        IPhoneBookDal _phoneBookDal;

        public DeleteRecordManager(IPhoneBookDal phoneBookDal)
        {
            _phoneBookDal = phoneBookDal;
        }
        public void DeleteUserRecord(string searchingUser)
        {
            User user = new User();
            user.FirstName = searchingUser;
            user.LastName = searchingUser;
            _phoneBookDal.Delete(user);
        }


        public void ViewDeleteOptions()
        {
            System.Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");

            string searchingUser = Console.ReadLine();

            if(_phoneBookDal.IsUserThere(searchingUser))
            {

                System.Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", searchingUser);

                string choise = Console.ReadLine();

                if(choise == "y")
                {
                    DeleteUserRecord(searchingUser);
                    System.Console.WriteLine("{0} isimli kişi rehberden silindi.", searchingUser);
                }
                else if(choise == "n")
                {
                    System.Console.WriteLine("{0} isimli kişinin rehberden silinmesi iptal edildi.", searchingUser);
                }
                
            }
            else
            {
               System.Console.WriteLine("Aradığınız kiriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız: "); 

               System.Console.WriteLine("* Silmeyi sonlandırmak için: (1)");
               System.Console.WriteLine("* Yeniden denemek için: (2)");

               string t = Console.ReadLine();
               if(t == "1")
               {
                   return;
               }
               else
               {
                   ViewDeleteOptions();
               }
            }
        }
    }
}