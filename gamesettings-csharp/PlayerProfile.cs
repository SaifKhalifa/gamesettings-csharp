namespace gamesettings_csharp
{
    public class PlayerProfile
    {
        public string Username { get; private set; }
        public string ClassType { get; private set; }
        public int Level { get; private set; }
        public List<string> Inventory { get; private set; } = new List<string>();

        // private constructor, hoomans can only create object using `Builder` class.
        private PlayerProfile() { }

        public void Print()
        {
            Console.WriteLine($"Username: {Username}");
            Console.WriteLine($"Classtype: {ClassType}");
            Console.WriteLine($"Level: {Level}");

            Console.WriteLine("Items: ");
            Inventory.ForEach(x => Console.WriteLine(x));
        }

        // methods return `this` object, needed for method chaining
        public class Builder
        {
            private PlayerProfile _player = new PlayerProfile();

            public Builder SetUsername(string username)
            {
                _player.Username = username;
                return this;
            }

            public Builder SetClassType(string classType)
            {
                _player.ClassType = classType;
                return this;
            }

            public Builder SetLevel(int level)
            {
                _player.Level = level;
                return this;
            }

            public Builder AddItem(string item)
            {
                _player.Inventory.Add(item);
                return this;
            }

            public PlayerProfile Build()
            {
                return _player;
            }
        }
    }
}
