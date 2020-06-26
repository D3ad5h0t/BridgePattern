namespace SimpleBridge.Renderers
{
    public class VectorRenderer : IRenderer
    {
        public string WhatToRenderAs { get; set; }

        public string RenderShape() => $"Drawing {WhatToRenderAs} as line";
    }
}