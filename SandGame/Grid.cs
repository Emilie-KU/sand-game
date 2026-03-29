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
    public List<List<StationaryShape>> tiles = new List<List<StationaryShape>>();
    public IBaseImage texture = new Image("SandGame.Assets.blue.png");

    // Constructor for asymmetrical grid:
    public Grid(Vector2 gridPosition, Vector2 tileExtend, Vector2 tileSpacing, int tileAmountX, int tileAmountY) {
        float xCounter = 0.0f;
        for (int i = 0; i < tileAmountX; i++) {
            tiles.Add(new List<StationaryShape>());
            float yCounter = 0.0f;
            for (int j = 0; j < tileAmountY; j++) {
                tiles[i].Add(new StationaryShape(new Vector2(gridPosition.X + xCounter, gridPosition.Y + yCounter), tileExtend));
                yCounter += tileExtend.Y + tileSpacing.Y;
            }
            xCounter += tileExtend.X + tileSpacing.X;
        }
    }

    // Constructor for symmetrical grid:
    public Grid(Vector2 gridPosition, float tileExtend, float tileSpacing, int tileAmount) {
        float xCounter = 0.0f;
        for (int i = 0; i < tileAmount; i++) {
            tiles.Add(new List<StationaryShape>());
            float yCounter = 0.0f;
            for (int j = 0; j < tileAmount; j++) {
                tiles[i].Add(new StationaryShape(new Vector2(gridPosition.X + xCounter, gridPosition.Y + yCounter), new Vector2(tileExtend, tileExtend)));
                yCounter += tileExtend + tileSpacing;
            }
            xCounter += tileExtend + tileSpacing;
        }
    }

    public void RenderGrid(WindowContext context) {
        foreach (var tilerow in tiles) {
            foreach (var tile in tilerow) {
                texture.Render(context, tile);
            }
        }
    }
}