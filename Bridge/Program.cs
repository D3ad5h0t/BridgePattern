using Bridge.Renderers;
using Bridge.Shapes;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var raster = new RasterRenderer();
            var vector = new VectorRenderer();
            var circle = new Circle(raster, 5);
            
            circle.Draw();
            circle.Resize(2);
            circle.Draw();
        }
    }
}