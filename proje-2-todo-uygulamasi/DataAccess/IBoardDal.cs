namespace proje_2_todo_uygulamasi
{
    public interface IBoardDal 
    {
        List<Card> GetAllBoardItem();
        List<Card> GetAllBoardItemWithLine(string line);
        Card GetBoardItem(string title);
        void AddCardToBoard(Card card);
        void UpdateCardInBoard(Card card);
        void DeleteCardToBoard(Card card);
    }
}