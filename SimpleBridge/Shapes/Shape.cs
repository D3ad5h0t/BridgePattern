using SimpleBridge.Renderers;

namespace SimpleBridge.Shapes
{
    public abstract class Shape
    {
        public string Name { get; set; }
        private IRenderer _renderer;

        public Shape(IRenderer renderer)
        {
            _renderer = renderer;
        }

        public override string ToString()
        {
            _renderer.WhatToRenderAs = Name;
            return _renderer.RenderShape();
        }
    }
}