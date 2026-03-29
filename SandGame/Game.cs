namespace SandGame;

using System;
using System.Numerics;
using System.Collections.Generic;
using DIKUArcade;
using DIKUArcade.GUI;
using DIKUArcade.Input;
using DIKUArcade.Entities;
using DIKUArcade.Graphics;
using DIKUArcade.Events;
using SandGame.States;

public class Game : DIKUGame {
    private StateMachine state;

    public Game(WindowArgs windowArgs) : base(windowArgs) {
        state = new StateMachine();        
    }

    public override void Render(WindowContext context) {
        state.ActiveState.Render(context);
    }
    public override void Update() {
        state.ActiveState.Update();
    }
    public override void KeyHandler(KeyboardAction action, KeyboardKey key) {
        state.ActiveState.HandleKeyEvent(action, key);
    }
}