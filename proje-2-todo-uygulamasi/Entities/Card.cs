namespace proje_2_todo_uygulamasi
{
    public class Card
    {
        private string title;
        private string content;
        private CardSize cardSizeOption;
        private BoardLine line;
        private int userId;

        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }        
        public int UserId { get => userId; set => userId = value; }
        public BoardLine Line { get => line; set => line = value; }
        public CardSize CardSizeOption { get => cardSizeOption; set => cardSizeOption = value; }

        public Card(string title, string content, int userId, BoardLine line, CardSize cardSizeOption)
        {
            Title = title;
            Content = content;
            UserId = userId;
            Line = line;
            CardSizeOption = cardSizeOption;
        }

        public Card(){}
    }
}