namespace SimpleBridge.Renderers
{
    public class RasterRenderer : IRenderer
    {
        public string WhatToRenderAs { get; set; }

        public string RenderShape() => $"Drawing {WhatToRenderAs} as pixels";
    }
}