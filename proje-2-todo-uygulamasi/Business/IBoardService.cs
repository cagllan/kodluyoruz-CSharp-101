namespace proje_2_todo_uygulamasi
{

    public interface IBoardService 
    {
        void GetAllCardFromBoard();
        void AddCartToBoard();
        void DeleteCartFromBoard();
        void ChangeCardLineInBoard();
        void UpdateCardInBoard();
    }

}