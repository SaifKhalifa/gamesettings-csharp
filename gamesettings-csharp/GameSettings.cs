namespace gamesettings_csharp
{
    // Singleton
    public class GameSettings
    {
        // single shared instance
        private static GameSettings _instance = new GameSettings();

        public string Difficulty { get; set; }
        public int SoundVolume { get; set; }

        // Private constructor, so no one can create another instance
        private GameSettings() { }

        public static GameSettings GetInstance()
        {
            return _instance;
        }
    }
}
