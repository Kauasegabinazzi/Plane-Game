# Plane Game

An endless 2D flying game made in Unity (C#). Tap to keep the plane in the air and fly through gaps in the obstacles. The game gets faster the longer you survive.

## Features

- Physics-based flight: each tap applies an upward force to a `Rigidbody2D`, and the animator follows the plane's vertical speed (`Player.cs`).
- Obstacles spawn at a random height and score a point when passed (`Obstacle.cs`).
- Difficulty ramps from easy to hard over time by shortening the spawn interval (`Difficulty.cs`, `GenereteObstacle.cs`).
- Scrolling background loop whose speed is shared with the obstacles through a `ScriptableObject` (`Carousel.cs`, `SharedVariable.cs`).
- Game over screen, restart and a saved best score (`Director.cs`, `Score.cs`, `InterfaceGameOver.cs`).

## Repository contents

This repository holds the project's `Assets` folder: scripts, scenes, sprites and audio.
