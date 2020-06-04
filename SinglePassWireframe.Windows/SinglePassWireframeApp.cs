using Stride.Engine;

namespace SinglePassWireframe.Windows
{
    class SinglePassWireframeApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
