# Quick Start Guide

This guide will help you get started with the Unity Mini Projects repository.

## Prerequisites

- Unity Hub installed
- Unity Editor (2020.3 LTS or later recommended)
- Basic understanding of Unity Editor
- C# knowledge (beginner-friendly)

## Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/bpo1at/unity-mini-projects.git
cd unity-mini-projects
```

### 2. Open a Project in Unity

1. Open Unity Hub
2. Click "Add" or "Open"
3. Navigate to the project folder (e.g., `Project1-BasicMovement/`)
4. Select the folder and click "Open"
5. Unity will import the project assets

### 3. Explore the Project

Each project contains:
- **Assets/Scripts/** - C# scripts with game logic
- **Assets/Scenes/** - Unity scenes (game levels)
- **ProjectSettings/** - Unity configuration
- **README.md** - Project-specific documentation

## Project 1: Basic Movement

### Setup Instructions

1. Open the project in Unity
2. Open the SampleScene (Assets/Scenes/SampleScene.unity)
3. Create game objects:
   - **Ground**: Create a 2D Sprite object with a BoxCollider2D, set layer to "Ground"
   - **Player**: Create a 2D Sprite object, add:
     - Rigidbody2D component (Gravity Scale: 1)
     - BoxCollider2D or CircleCollider2D
     - PlayerMovement script (drag from Scripts folder)
4. Configure the Main Camera:
   - Add the CameraFollow script
   - Drag the Player object to the "Target" field
5. Press Play and use WASD/Arrow keys to move, Space to jump

### Controls

- **WASD** or **Arrow Keys**: Move left/right
- **Space**: Jump (when grounded)

### Customization

You can adjust these values in the Inspector:
- **Move Speed**: How fast the player moves
- **Jump Force**: How high the player jumps
- **Ground Check Radius**: Size of ground detection area
- **Camera Smooth Speed**: How smoothly camera follows

## Tips for Learning

1. **Experiment**: Try changing values in the Inspector to see what happens
2. **Read the Code**: Open the scripts and read the comments
3. **Debug**: Use Debug.Log() to print values and understand what's happening
4. **Iterate**: Make small changes and test frequently
5. **Visualize**: Use Gizmos (visible in Scene view) to see ground check area

## Common Issues

### Player falls through ground
- Make sure ground has a Collider2D
- Check that ground is on "Ground" layer
- Verify ground layer is selected in PlayerMovement's "Ground Layer" setting

### Jump doesn't work
- Ensure Rigidbody2D is on the player
- Check that ground detection is working (visible via Gizmos)
- Verify Jump button is mapped in InputManager

### Camera doesn't follow
- Make sure CameraFollow script has the player as its target
- Check that camera position has Z = -10 (for 2D)

## Next Steps

After completing Project 1:
1. Try adding animation to the player
2. Create multiple levels
3. Add sound effects
4. Implement a scoring system
5. Explore the next project in the repository

## Resources

- [Unity Documentation](https://docs.unity3d.com/)
- [Unity Learn](https://learn.unity.com/)
- [C# Programming Guide](https://docs.microsoft.com/en-us/dotnet/csharp/)

## Getting Help

If you encounter issues:
1. Check the project README
2. Review the code comments
3. Search Unity forums and documentation
4. Experiment with simpler versions of your code

Happy learning! 🎮
