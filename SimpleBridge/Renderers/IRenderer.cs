namespace SimpleBridge.Renderers
{
    public interface IRenderer
    {
        string WhatToRenderAs { get; set; }

        string RenderShape();
    }
}