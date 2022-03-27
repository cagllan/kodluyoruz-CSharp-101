using System;

namespace proje_1_telefon_rehberi_uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isActive = true;
            IPhoneBookDal phoneBookDal = new PhoneBookDal();

            

            while(isActive)
            {
                System.Console.WriteLine("*******************************************\n");
                System.Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz\n");
                System.Console.WriteLine("*******************************************\n");
                System.Console.WriteLine("(1) Yeni Numara Kaydetmek");
                System.Console.WriteLine("(2) Varolan Numarayı Silmek");
                System.Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                System.Console.WriteLine("(4) Rehberi Listelemek");
                System.Console.WriteLine("(5) Rehberde Arama Yapmak");
                System.Console.WriteLine("*******************************************\n");

                int userChoise = Convert.ToInt32(Console.ReadLine());
                
                switch(userChoise)
                {
                    case 1:
                        AddRecordManager addRecord = new AddRecordManager(phoneBookDal);
                        addRecord.ViewRecordOptions();
                        Console.ReadLine();
                    break;
                    case 2:                        
                        DeleteRecordManager deleteRecord = new DeleteRecordManager(phoneBookDal);
                        deleteRecord.ViewDeleteOptions();
                        Console.ReadLine();
                    break;
                    case 3:
                        UpdateRecordManager updateRecord = new UpdateRecordManager(phoneBookDal);
                        updateRecord.viewUpdateOptions();
                        Console.ReadLine();
                    break;
                    case 4:
                        ViewRecordManager viewRecord = new ViewRecordManager(phoneBookDal);
                        viewRecord.GetAllRecord();
                        Console.ReadLine();
                    break;
                    case 5:
                        SearchRecordManager searchRecord = new SearchRecordManager(phoneBookDal);
                        searchRecord.GetRecordsWithChoise();
                        Console.ReadLine();
                    break;
                    default:
                        System.Console.WriteLine("Başka bir tuşa bastınız");
                        isActive = false;
                    break;

                }
            }
        }
    }
}
