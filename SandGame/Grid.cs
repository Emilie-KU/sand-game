namespace SandGame;

using System;
using System.Collections.Generic;
using System.Numerics;
using DIKUArcade;
using DIKUArcade.GUI;
using DIKUArcade.Input;
using DIKUArcade.Entities;
using DIKUArcade.Graphics;
using DIKUArcade.Events;
using System.Reflection;
using System.Diagnostics.Metrics;

public class Grid {
    public List<StationaryShape> tiles = new List<StationaryShape>();
    public IBaseImage texture = new Image("SandGame.Assets.blue.png");
    public Grid(Vector2 position, int size) {
        float xCounter = 0.0f;
        for (int i = 0; i < size; i++) {
            float yCounter = 0.0f;
            for (int j = 0; j < size; j++) {
                tiles.Add(new StationaryShape(new Vector2(position.X + xCounter, position.Y + yCounter), new Vector2(0.1f, 0.1f)));
                yCounter += 0.11f;
            }
            xCounter += 0.11f;
        }
    }

    public void RenderGrid(WindowContext context) {
        foreach (var tile in tiles) {
            texture.Render(context, tile);
        }
    }
}