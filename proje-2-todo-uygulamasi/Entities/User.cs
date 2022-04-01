namespace proje_2_todo_uygulamasi
{
    public class User
    {
        private int id ;
        private string name;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public User(){}
        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}