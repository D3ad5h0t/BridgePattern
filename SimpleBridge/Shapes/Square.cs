using SimpleBridge.Renderers;

namespace SimpleBridge.Shapes
{
    public class Square : Shape
    {
        public Square(IRenderer renderer) : base(renderer) => Name = "Square";
    }
}