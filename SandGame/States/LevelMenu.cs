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

public class LevelMenu : IGameState {
    private Text[] levelButtons;
    private int currentButton = 0;
    private StateMachine stateMachine;
    private Image backGroundImage;

    public LevelMenu(StateMachine stateMachine) {
        this.stateMachine = stateMachine;
        backGroundImage = new Image("SandGame.Assets.pink.png");
        levelButtons = new Text[] { new Text("Level 1", new Vector2(0.35f, 0.7f), 0.5f), 
                                    new Text("Level 2", new Vector2(0.35f, 0.6f), 0.5f),
                                    new Text("Level 3", new Vector2(0.35f, 0.5f), 0.5f),
                                    new Text("Level 4", new Vector2(0.35f, 0.4f), 0.5f),
                                    new Text("Level 5", new Vector2(0.35f, 0.3f), 0.5f),
                                    new Text("Go back", new Vector2(0.35f, 0.2f), 0.5f)};
    }

    public void Update() {
        levelButtons[currentButton].SetColor(0, 0, 255);
        for(int i = 0; i < levelButtons.Length; i++) {
            if (i != currentButton) {
                levelButtons[i].SetColor(255, 255, 255);
            }
        }
    }
    public void Render(WindowContext context) {
        backGroundImage.Render(context, new StationaryShape(0.0f, 0.0f, 1.0f, 1.0f));
        foreach (Text button in levelButtons) {
            button.Render(context);
        }
    }
    public void HandleKeyEvent(KeyboardAction action, KeyboardKey key) {
        switch (action, key) {
            case (KeyboardAction.KeyPress, KeyboardKey.Up):
                currentButton = (currentButton + levelButtons.Length - 1) % levelButtons.Length; //added additional menuButtons.Length, to inforce that the remainder isn't negative in case currentButton is 0.
                break;
            case (KeyboardAction.KeyPress, KeyboardKey.Down):
                currentButton = (currentButton + 1) % levelButtons.Length;
                break;
            case (KeyboardAction.KeyPress, KeyboardKey.Enter):
                if (currentButton == levelButtons.Length - 1) {
                    stateMachine.ActiveState = new MainMenu(stateMachine);
                }
                break;
        }
    }
}