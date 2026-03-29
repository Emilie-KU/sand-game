namespace SandGame;

using System.Numerics;
using DIKUArcade;
using DIKUArcade.GUI;
using DIKUArcade.Input;
using DIKUArcade.Entities;
using DIKUArcade.Graphics;
using DIKUArcade.Events;

public abstract class Unit : Entity {
    public Unit(Shape shape, IBaseImage image) : base(shape, image) {
    }

    public void CenterX() {
        base.Shape.Position = new Vector2 (0.5f - base.Shape.Extent.X / 2, base.Shape.Position.Y);
    }

    public void RenderUnit(WindowContext context) {
        base.RenderEntity(context);
    }
}