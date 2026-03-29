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

public class MainMenu : IGameState {
    private Text[] menuButtons;
    private Text title;
    private int currentButton = 0;
    private StateMachine stateMachine;
    private Image backGroundImage;

    public MainMenu(StateMachine stateMachine) {
        this.stateMachine = stateMachine;
        backGroundImage = new Image("SandGame.Assets.pink.png");
        title = new Text("GALAGA", new Vector2(0.28f, 0.68f), 1.0f);
        menuButtons = new Text[] {new Text("New Game", new Vector2(0.35f, 0.55f), 0.5f), new Text("Quit", new Vector2(0.35f, 0.45f), 0.5f)};
    }

    public void Update() {
        menuButtons[currentButton].SetColor(0, 0, 255);
        for(int i = 0; i < menuButtons.Length; i++) {
            if (i != currentButton) {
                menuButtons[i].SetColor(255, 255, 255);
            }
        }
    }
    public void Render(WindowContext context) {
        backGroundImage.Render(context, new StationaryShape(0.0f, 0.0f, 1.0f, 1.0f));
        title.Render(context);
        foreach (Text button in menuButtons) {
            button.Render(context);
        }
    }
    public void HandleKeyEvent(KeyboardAction action, KeyboardKey key) {
        switch (action, key) {
            case (KeyboardAction.KeyPress, KeyboardKey.Up):
                currentButton = (currentButton + menuButtons.Length - 1) % menuButtons.Length; //added additional menuButtons.Length, to inforce that the remainder isn't negative in case currentButton is 0.
                break;
            case (KeyboardAction.KeyPress, KeyboardKey.Down):
                currentButton = (currentButton + 1) % menuButtons.Length;
                break;
            case (KeyboardAction.KeyPress, KeyboardKey.Enter):
                /*if (currentButton == 0) {
                    stateMachine.ActiveState = new GameRunning(stateMachine);
                }*/
                if (currentButton == 1) {
                    Environment.Exit(1);
                }
                break;
        }
    }
}