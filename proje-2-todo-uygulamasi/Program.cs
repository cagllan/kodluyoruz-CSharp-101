using System;

namespace proje_2_todo_uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int boardChoiseNumberOption;

            ITeamMemberService teamMemberManager = new TeamMemberManager(new TeamMemberDal());
            IBoardService boardManager = new BoardManager(new BoardDal(), teamMemberManager);

            while(flag)
            {                
                System.Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz!");
                System.Console.WriteLine("*******************************************");
                System.Console.WriteLine("(1) Board Listelemek");
                System.Console.WriteLine("(2) Board'a Kart Eklemek");
                System.Console.WriteLine("(3) Board'dan Kart Silmek");
                System.Console.WriteLine("(4) Kart Taşımak");
                System.Console.WriteLine("(5) Kart Güncellemek");         
                boardChoiseNumberOption = Convert.ToInt32(Console.ReadLine());

                switch (boardChoiseNumberOption)
                {
                    case 1:
                        // listeleme
                        boardManager.GetAllCardFromBoard();
                        Console.ReadLine();
                        break;
                    case 2:
                        // kart ekleme
                        boardManager.AddCartToBoard();
                        Console.ReadLine();
                        break;
                    case 3:
                        // kart silme
                        boardManager.DeleteCartFromBoard();
                        Console.ReadLine();
                        break;
                    case 4:
                        // kart taşıma 
                        boardManager.ChangeCardLineInBoard();
                        Console.ReadLine();
                        break;
                    case 5:
                        // kart güncelleme
                        boardManager.UpdateCardInBoard();
                        Console.ReadLine();
                        break;
                    default:
                        flag=false;
                        break;
                }
            }           
        }
    }
}
