namespace Task12_1_5
{
    public class User
    {
        public User(string login, string name, bool isPremium)
        {
            Login = login;
            Name = name;
            IsPremium = isPremium;
        }

        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }

        public static User[] CreateUsers()
        {
            return new User[]
            {
                new User("dmitry", "Дмитрий", true),
                new User("ivan", "Иван", false),
                new User("anton", "Антон", true),
                new User("olga", "Ольга", false)
            };
        }
    }
}
