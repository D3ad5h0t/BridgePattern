using System;

namespace Bridge.Renderers
{
    public class VectorRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"Drawing circle of radius {radius}");
        }
    }
}