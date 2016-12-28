namespace Battleships.Game
{
    public enum GameStatus
    {
        Creation, Start
    }
    public enum PanelStatus
    {
        Singleplayer, Multiplayer, None
    }

    public static class GameStatusController
    {
        public static GameStatus ActiveGameStatus { get; set; }
        public static PanelStatus ActivePanelStatus { get; set;}
    }
}
