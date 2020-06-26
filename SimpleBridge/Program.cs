using System;
using System.Threading.Channels;
using SimpleBridge.Renderers;
using SimpleBridge.Shapes;

namespace SimpleBridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle(new RasterRenderer()).ToString();
            Console.WriteLine(triangle);
        }
    }
}