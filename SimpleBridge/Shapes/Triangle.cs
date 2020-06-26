using SimpleBridge.Renderers;

namespace SimpleBridge.Shapes
{
    public class Triangle : Shape
    {
        public Triangle(IRenderer renderer) : base(renderer) => Name = "Triangle";
    }
}