namespace proje_2_todo_uygulamasi
{

    public class BoardManager : IBoardService
    {
        IBoardDal _boardDal;
        ITeamMemberService _teamMemberManager;


        public BoardManager(IBoardDal boardDal, ITeamMemberService teamMemberManager)
        {
            _teamMemberManager = teamMemberManager;
            _boardDal = boardDal;
        }

        public void GetAllCardFromBoard()
        {
            List<Card> todoCard = _boardDal.GetAllBoardItemWithLine(BoardLine.todo.ToString());
            List<Card> inProgressCard = _boardDal.GetAllBoardItemWithLine(BoardLine.inProgress.ToString());
            List<Card> doneCard = _boardDal.GetAllBoardItemWithLine(BoardLine.done.ToString());

            System.Console.WriteLine("TODO Line");
            System.Console.WriteLine("************************");

            if (todoCard.Count > 0)
            {
                foreach (var card in todoCard)
                {
                    System.Console.WriteLine("Başlık      : {0}", card.Title);
                    System.Console.WriteLine("İçerik      : {0}", card.Content);
                    System.Console.WriteLine("Atanan Kişi : {0}", _teamMemberManager.GetTeamMember(card.UserId).Name);
                    System.Console.WriteLine("Büyüklük    : {0}", card.CardSizeOption);
                    System.Console.WriteLine(" - ");
                }
            }
            else
            {
                System.Console.WriteLine("~ BOŞ ~");
            }

            System.Console.WriteLine("IN PROGRESS Line");
            System.Console.WriteLine("************************");

            if (inProgressCard.Count > 0)
            {
                foreach (var card in inProgressCard)
                {
                    System.Console.WriteLine("Başlık      : {0}", card.Title);
                    System.Console.WriteLine("İçerik      : {0}", card.Content);
                    System.Console.WriteLine("Atanan Kişi : {0}", _teamMemberManager.GetTeamMember(card.UserId).Name);
                    System.Console.WriteLine("Büyüklük    : {0}", card.CardSizeOption);
                    System.Console.WriteLine(" - ");
                }
            }
            else
            {
                System.Console.WriteLine("~ BOŞ ~");
            }

            System.Console.WriteLine("DONE Line");
            System.Console.WriteLine("************************");
            
            if (doneCard.Count > 0)
            {
                foreach (var card in doneCard)
                {
                    System.Console.WriteLine("Başlık      : {0}", card.Title);
                    System.Console.WriteLine("İçerik      : {0}", card.Content);
                    System.Console.WriteLine("Atanan Kişi : {0}", _teamMemberManager.GetTeamMember(card.UserId).Name);
                    System.Console.WriteLine("Büyüklük    : {0}", card.CardSizeOption);
                    System.Console.WriteLine(" - ");
                }
            }
            else
            {
                System.Console.WriteLine("~ BOŞ ~");
            }
        }


        public void AddCartToBoard()
        {
            Card card = new Card();
            int defaultCardSizeOption = 1;
            bool userFlag = false;

            System.Console.WriteLine("Board'a yeni kart ekle.");
            System.Console.WriteLine("************************");

            System.Console.Write("Başlık Giriniz                                  : ");
            card.Title = Console.ReadLine();

            System.Console.Write("İçerik Giriniz                                  : ");
            card.Content = Console.ReadLine();

            System.Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  : " + defaultCardSizeOption);
            card.CardSizeOption = (CardSize)Enum.Parse(typeof(CardSize), defaultCardSizeOption.ToString());

            while (!userFlag)
            {
                System.Console.Write("Kişi Seçiniz                                    : ");
                card.UserId = int.Parse(Console.ReadLine());
                if (_teamMemberManager.GetTeamMember(card.UserId) != null)
                {
                    userFlag = true;
                }
                else
                {
                    System.Console.WriteLine("Kullanıcı id bulunamıyor, lütfen tekrar deneyin.");
                }
                
            }

            card.Line = BoardLine.todo;
            _boardDal.AddCardToBoard(card);
            System.Console.WriteLine("Yeni kart eklendi ana menüye dönmek içn herhangi bir tuşa basın");
        }


        public void DeleteCartFromBoard()
        {
            System.Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            System.Console.Write("Lütfen kart başlığını yazınız: ");
            string deletedCartTitle = Console.ReadLine();

            if (_boardDal.GetBoardItem(deletedCartTitle) != null)
            {
                Card card = new Card();
                card.Title = deletedCartTitle;
                _boardDal.DeleteCardToBoard(card);
                System.Console.WriteLine("{0} başlıklı kart board dan silindi.", deletedCartTitle);
            }
            else
            {
                System.Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                System.Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                System.Console.WriteLine("* Yeniden denemek için : (2)");
                string deleteChoise = Console.ReadLine();

                if (deleteChoise == "1")
                {
                    return;
                }
                else if (deleteChoise == "2")
                {
                    DeleteCartFromBoard();
                }
            }
        }


        public void ChangeCardLineInBoard()
        {
            System.Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            System.Console.Write("Lütfen kart başlığını yazınız: ");
            string title = Console.ReadLine();

            if (_boardDal.GetBoardItem(title) != null)
            {
                Card card = _boardDal.GetBoardItem(title);
                System.Console.WriteLine("Bulunan Kart Bilgileri:");
                System.Console.WriteLine("**************************************");
                System.Console.WriteLine("Başlık      : {0}", card.Title);
                System.Console.WriteLine("İçerik      : {0}", card.Content);
                System.Console.WriteLine("Atanan Kişi : {0}", _teamMemberManager.GetTeamMember(card.UserId).Name);
                System.Console.WriteLine("Büyüklük    : {0}", card.CardSizeOption.ToString());
                System.Console.WriteLine("Line        : {0}", card.Line);

                System.Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
                System.Console.WriteLine("(1) TODO");
                System.Console.WriteLine("(2) IN PROGRESS");
                System.Console.WriteLine("(3) DONE");
                string lineChoise = Console.ReadLine();

                switch (lineChoise)
                {
                    case "1":
                        card.Line = BoardLine.todo;
                        break;
                    case "2":
                        card.Line = BoardLine.inProgress;
                        break;
                    case "3":
                        card.Line = BoardLine.done;
                        break;
                }

                _boardDal.UpdateCardInBoard(card);

                System.Console.WriteLine("Card line güncellendi.");
                System.Console.WriteLine("(1) Board Listelemek");
                string listBoardChoise = Console.ReadLine();

                if (listBoardChoise == "1")
                {
                    GetAllCardFromBoard();
                }
            }
            else
            {
                System.Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                System.Console.WriteLine("* İşlemi sonlandırmak için : (1)");
                System.Console.WriteLine("* Yeniden denemek için : (2)");
                string changeCardChoise = Console.ReadLine();

                if (changeCardChoise == "1")
                {
                    return;
                }
                else if (changeCardChoise == "2")
                {
                    ChangeCardLineInBoard();
                }
            }
        }


        public void UpdateCardInBoard()
        {
            System.Console.WriteLine("Öncelikle güncellemek istediğiniz kartı seçmeniz gerekiyor.");
            System.Console.Write("Lütfen kart başlığını yazınız: ");
            string title = Console.ReadLine();

            if(_boardDal.GetBoardItem(title) != null)
            {
                Card card = _boardDal.GetBoardItem(title);

                System.Console.WriteLine("Bulunan Kart Bilgileri:");
                System.Console.WriteLine("**************************************");
                System.Console.WriteLine("Başlık      : {0}", card.Title);
                System.Console.WriteLine("İçerik      : {0}", card.Content);
                System.Console.WriteLine("Atanan Kişi : {0}", _teamMemberManager.GetTeamMember(card.UserId).Name);
                System.Console.WriteLine("Büyüklük    : {0}", card.CardSizeOption.ToString());
                System.Console.WriteLine("Line        : {0}", card.Line);

                System.Console.WriteLine("Güncelleme işlemine devam etmek veya sonlandırmak için seçeneklerden birini seçin:");
                System.Console.WriteLine("(1) Güncelle");
                System.Console.WriteLine("(2) Güncellemeyi sonlandır");


                string updateChoise = Console.ReadLine();

                if(updateChoise == "1")
                {
                    // güncelleme işlemleri
                    bool userFlag = false;
                    
                    System.Console.Write("Başlık                                         : ");                    
                    card.Title =  Console.ReadLine();

                    System.Console.Write("İçerik                                         : ");
                    card.Content =  Console.ReadLine();

                    while (!userFlag)
                    {
                        System.Console.Write("Atanan Kişi                                    : ");
                        card.UserId = int.Parse(Console.ReadLine());
                        if (_teamMemberManager.GetTeamMember(card.UserId) != null)
                        {
                            userFlag = true;
                        }
                        else
                        {
                            System.Console.WriteLine("Kullanıcı id bulunamıyor, lütfen tekrar deneyin.");
                        }
                        
                    }

                    System.Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5) : ");
                    card.CardSizeOption = (CardSize)int.Parse(Console.ReadLine());

                    System.Console.Write("Line -> todo(1),inProgress(2),done(3)          : ");
                    card.Line = (BoardLine)int.Parse(Console.ReadLine());

                    _boardDal.UpdateCardInBoard(card);
                        
                }
                else if(updateChoise == "2")
                {
                    return;
                }


                _boardDal.UpdateCardInBoard(card);


                System.Console.WriteLine("Card güncellendi.");

                System.Console.WriteLine("(1) Board Listelemek");

                string listBoardChoise = Console.ReadLine();

                if(listBoardChoise == "1")
                {
                    GetAllCardFromBoard();
                }


            }
            else
            {
                System.Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                System.Console.WriteLine("* İşlemi sonlandırmak için : (1)");
                System.Console.WriteLine("* Yeniden denemek için : (2)");
                string changeCardChoise = Console.ReadLine();

                if(changeCardChoise == "1")
                {
                    return;
                }
                else if(changeCardChoise == "2")
                {
                    UpdateCardInBoard();
                }
            }
        }


    }
}