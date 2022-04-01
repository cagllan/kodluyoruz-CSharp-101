namespace proje_2_todo_uygulamasi
{
    public class Board
    {
        private List<Card> cards;
        public List<Card> Cards { get => cards; set => cards = value; }
        public Board(List<Card> cards)
        {
            Cards = cards;
        }
        public Board(){}
    }
}