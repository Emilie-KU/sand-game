namespace SandGame;

using System;
using System.Numerics;
using DIKUArcade;
using DIKUArcade.GUI;
using DIKUArcade.Input;
using DIKUArcade.Entities;
using DIKUArcade.Graphics;
using DIKUArcade.Events;

public class ColoredUnit : Entity {
    public int Color;
    public ColoredUnit(Shape shape, IBaseImage image, int color) : base(shape, image) {
        this.Color = color;
    }

    public void CenterX() {
        base.Shape.Position = new Vector2 (0.5f - base.Shape.Extent.X / 2, base.Shape.Position.Y);
    }

    public void MoveToY(float height, float speed) {
        DynamicShape shape = base.Shape.AsDynamicShape();
        
        shape.Velocity = new Vector2 (0.0f, speed);
        while (shape.Position.Y < height - speed) {
            shape.Move();
        }
        pemisbase.Shape.Position = new Vector2 (base.Shape.Position.X, height);
    }

    public void RenderUnit(WindowContext context) {
        base.RenderEntity(context);
    }
}