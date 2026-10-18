namespace gamesettings_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // singleton test
            GameSettings a = GameSettings.GetInstance();
            GameSettings b = GameSettings.GetInstance();

            a.Difficulty = "Hard";

            Console.WriteLine("`a` <> `b`, same instance? " + ReferenceEquals(a, b));
            Console.WriteLine("b.Difficulty = " + b.Difficulty);

            // Builder
            PlayerProfile emptyPlayer = new PlayerProfile.Builder().Build();

            PlayerProfile theGOAT = new PlayerProfile.Builder()
                .SetUsername("General Adham")
                .SetClassType("GLA")
                .SetLevel(Int32.MaxValue)
                .AddItem("Scud Launcher")
                .AddItem("Technical")
                .AddItem("Rebel Squad")
                .Build();

            Console.WriteLine("\nEmpty Player Info:");
            emptyPlayer.Print();

            Console.WriteLine("\nThe GOAT Info:");
            theGOAT.Print();

            Console.ReadLine();
        }
    }
}
