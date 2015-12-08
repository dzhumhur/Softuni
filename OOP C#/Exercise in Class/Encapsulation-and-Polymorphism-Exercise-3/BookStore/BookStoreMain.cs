namespace BookStore
{
    using UI;
    using Engine;

    public class BookStoreMain
    {
        public static void Main()
        {
            ConsoleRenderer consoleRenderer = new ConsoleRenderer();
            ConsoleInputHandler inputHandler = new ConsoleInputHandler();

            BookStoreEngine engine = new BookStoreEngine(inputHandler, consoleRenderer);

            engine.Run();
        }
    }
}
