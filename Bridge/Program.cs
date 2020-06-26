using Autofac;
using Bridge.Renderers;
using Bridge.Shapes;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simple Bridge
            // =============
            // var raster = new RasterRenderer();
            // var vector = new VectorRenderer();
            // var circle = new Circle(raster, 5);
            //
            // circle.Draw();
            // circle.Resize(2);
            // circle.Draw();
            
            // With Dependency Injection
            // =========================
            var cb = new ContainerBuilder();
            cb.RegisterType<VectorRenderer>().As<IRenderer>();
            cb.Register((c, p) => new Circle(
                c.Resolve<IRenderer>(),
                p.Positional<float>(0)
            ));

            using (var c = cb.Build())
            {
                var circle = c.Resolve<Circle>(
                    new PositionalParameter(0, 5.0f)
                    );
                circle.Draw();
                circle.Resize(3);
                circle.Draw();
            }
        }
    }
}