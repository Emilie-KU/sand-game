namespace SandGame;

using System;
using DIKUArcade.GUI;

class Program {
    static void Main(string[] args) {
        var windowArgs = new WindowArgs() { Title = "Sand Game" };
        var game = new Game(windowArgs);
        game.Run();
    }
}

