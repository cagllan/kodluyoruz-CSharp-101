namespace proje_1_telefon_rehberi_uygulamasi
{
    public class ViewRecordManager
    {
        IPhoneBookDal _phoneBookDal;

        public ViewRecordManager(IPhoneBookDal phoneBookDal)
        {
            _phoneBookDal = phoneBookDal;
        }

       public void GetAllRecord()
       {

            System.Console.WriteLine("Telefon Rehberi");
            System.Console.WriteLine("*******************************");

           foreach(var record in _phoneBookDal.GetAllUsers())
           {
               System.Console.WriteLine("İsim               : {0}", record.FirstName);
               System.Console.WriteLine("Soyisim            : {0}", record.LastName);
               System.Console.WriteLine("Telefon Numarası   : {0}", record.PhoneNumber);
               System.Console.WriteLine("-");
           }
       }



    }
}