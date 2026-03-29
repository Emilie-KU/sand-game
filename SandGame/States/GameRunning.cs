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
    private Grid grid = new Grid(new Vector2(0.1f, 0.1f), 3);

    public GameRunning(StateMachine stateMachine) {
        this.stateMachine = stateMachine;
    }

    public void Update() {
        
    }
    public void Render(WindowContext context) {
        grid.RenderGrid(context);
    }
    public void HandleKeyEvent(KeyboardAction action, KeyboardKey key) {
        switch (action, key) {
            case (KeyboardAction.KeyPress, KeyboardKey.Up):
                ;
                break;
            
        }
    }
}