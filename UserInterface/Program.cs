namespace Ex05_UserInterface
{
    using System;

    // $G$ CSS-999 (0) Overall very very good job!
    public static class Program
    {
        [STAThread]
        // $G$ CSS-012 (-5) Access modifiers are missing.
        static void Main()
        {
            GameRunner game = new GameRunner();
            game.Run();
        }
    }
}
