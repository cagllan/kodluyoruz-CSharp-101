namespace proje_2_todo_uygulamasi
{

    public class BoardDal : IBoardDal
    {
        Board _board;       
        public BoardDal()
        {
            _board = new Board(
                new List<Card>()
                {
                    {new Card("test", "merhaba bu bir test kartı - todo", 1, BoardLine.todo, CardSize.XS)},
                    {new Card("test", "merhaba bu bir test kartı - inprogress", 1, BoardLine.inProgress, CardSize.XS)},
                    {new Card("test2", "merhaba bu ikinci test kartı - todo", 1, BoardLine.todo, CardSize.XS)},
                    
                }
            );
        }


        public List<Card> GetAllBoardItem()
        {
            return _board.Cards;
        }

        public List<Card> GetAllBoardItemWithLine(string line)
        {
            return _board.Cards.FindAll(x => x.Line.ToString().ToLower() == line.ToLower());
        }

        public Card GetBoardItem(string title)
        {
            return _board.Cards.FirstOrDefault(x=> x.Title.ToLower() == title.ToLower());
        }

        public void AddCardToBoard(Card card)
        {
            _board.Cards.Add(card);
        }

        public void UpdateCardInBoard(Card card)
        {
            Card updatedCard = _board.Cards.FirstOrDefault(x => x.Title.ToLower() == card.Title.ToLower());

            if(updatedCard != null)
            {
                updatedCard.Title = card.Title;
                updatedCard.Content = card.Content;
                updatedCard.CardSizeOption = card.CardSizeOption;
                updatedCard.Line = card.Line;
                updatedCard.UserId = card.UserId;
            }           
        }

        public void DeleteCardToBoard(Card card)
        {
            List<Card> deletedCards = _board.Cards.Where(x => x.Title.ToLower() == card.Title.ToLower()).ToList();
            foreach (var deletedCard in deletedCards)
            {
                _board.Cards.Remove(deletedCard);
            }
        }
    }
}