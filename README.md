# 🐤 Flappy Bird

A simple clone of the classic **Flappy Bird** game built with C# and Windows Forms (.NET Framework 4.7.2).

## 📸 Preview
<img width="431" height="520" alt="image" src="https://github.com/user-attachments/assets/7ff9e558-8d53-4405-aa4d-3a1a74b52f3f" />


## Gameplay

Guide the bird 🐥 through the gaps between the pipes 🟩 without hitting them, the ground, or the screen edges. Each pipe you pass increases your score, and the game gets progressively faster.

## Controls

| Key | Action |
| --- | --- |
| `Space` (hold) | Fly up |
| `Space` (release) | Fall down (gravity) |
| `Left Arrow` | Move left |
| `Right Arrow` | Move right |

## Features

- 🏆 Score counter that increments for every pipe 🟩 successfully passed.
- ⚡ Increasing difficulty: pipe speed increases by 2 every time the score reaches a multiple of 5.
- 💥 Collision detection against pipes 🟩, ground, and screen boundaries.
- 🎮 "Game Over" screen displaying your final score.

## Requirements

- Windows OS
- [.NET Framework 4.7.2](https://dotnet.microsoft.com/download/dotnet-framework/net472)
- Visual Studio 2017 or later (recommended for building)

## Getting Started

1. Clone or download this repository.
2. Open `FlappyBird.sln` in Visual Studio.
3. Build the solution (`Ctrl+Shift+B`).
4. Run the project (`F5`) to start playing.

Alternatively, run the compiled executable directly:

```
FlappyBird\bin\Debug\FlappyBird.exe
```

## Project Structure

```
FlappyBird.sln            # Solution file
FlappyBird/
├── Form1.cs              # Main game logic (movement, scoring, collisions)
├── Form1.Designer.cs     # UI layout and control definitions
├── Program.cs            # Application entry point
├── Properties/           # Assembly info, resources, settings
└── Resources/            # Game images (bird, pipes, ground)
```

## How It Works

The game runs on a `Timer` (`gameTimerEvent`) that fires on a regular interval to:

- Apply gravity to the bird � (moving it up or down).
- Scroll the pipes 🟩 to the left across the screen.
- Reposition pipes 🟩 once they leave the screen and award a point.
- Detect collisions 💥 and trigger the game-over state.

## License

This project is for educational and training purposes.
