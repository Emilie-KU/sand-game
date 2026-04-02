namespace SandGame.States;

using System;
using System.Numerics;
using DIKUArcade;
using DIKUArcade.Entities;
using DIKUArcade.Events;
using DIKUArcade.Fonts;
using DIKUArcade.Graphics;
using DIKUArcade.GUI;
using DIKUArcade.Input;

public class GameRunning : IGameState {
    private StateMachine stateMachine;
    private Image backGroundImage;
    private Grid grid = new Grid(new Vector2(0.1f, 0.1f), new Vector2(0.1f, 0.2f), new Vector2(0.01f, 0.02f), 4, 2);
    private Grid grid2 = new Grid(new Vector2(0.6f, 0.1f), 0.1f, 0.01f, 2);
    private ColoredUnit unit = new ColoredUnit(new DynamicShape(new Vector2(0.6f, 0.6f), new Vector2(0.05f, 0.05f)), new Image("SandGame.Assets.green.png"), 1);

    public GameRunning(StateMachine stateMachine) {
        this.stateMachine = stateMachine;
        backGroundImage = new Image("SandGame.Assets.pink.png");
        unit.CenterX();
        unit.MoveToY(0.8f);
    }

    public void Update() {
    }
    
    public void Render(WindowContext context) {
        backGroundImage.Render(context, new StationaryShape(0.0f, 0.0f, 1.0f, 1.0f));
        grid.RenderGrid(context);
        grid2.RenderGrid(context);
        unit.RenderUnit(context);
    }
    public void HandleKeyEvent(KeyboardAction action, KeyboardKey key) {
        switch (action, key) {
            case (KeyboardAction.KeyPress, KeyboardKey.Up):
                ;
                break;
            
        }
    }
}