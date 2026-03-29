namespace SandGame;

using System.Numerics;
using DIKUArcade;
using DIKUArcade.GUI;
using DIKUArcade.Input;
using DIKUArcade.Entities;
using DIKUArcade.Graphics;
using DIKUArcade.Events;

public class ColoredUnit : Unit {
    public int Color;
    public ColoredUnit(Shape shape, IBaseImage image, int color) : base(shape, image) {
        this.Color = color;
    }
}