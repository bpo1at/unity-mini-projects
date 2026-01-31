# Project 1: Basic Movement

A simple Unity 2D platformer prototype demonstrating basic player movement and camera following.

## Overview

This project is a learning prototype that implements fundamental game mechanics:
- **Player Movement**: WASD/Arrow key controls for horizontal movement
- **Jumping**: Space bar to jump when grounded
- **Camera Follow**: Smooth camera tracking of the player

## Scripts

### PlayerMovement.cs
- Handles player input and physics-based movement
- Implements ground detection for jumping
- Configurable movement speed and jump force
- Uses Rigidbody2D for physics interactions

### CameraFollow.cs
- Smooth camera following with configurable offset
- Optional boundary constraints
- Interpolated movement for smooth transitions

## Learning Objectives

This project demonstrates:
1. Unity's Input System (classic input)
2. Rigidbody2D physics
3. Transform and position manipulation
4. Ground detection using Physics2D.OverlapCircle
5. Camera follow mechanics
6. Inspector-exposed variables with SerializeField
7. Gizmos for debugging

## How to Use

1. Open this project in Unity (2020.3 or later recommended)
2. Create a 2D scene
3. Add a player GameObject with:
   - SpriteRenderer (for visualization)
   - Rigidbody2D (2D physics body)
   - PlayerMovement script
4. Add a Camera with the CameraFollow script
5. Set the CameraFollow target to your player
6. Create ground objects with a collider and assign them to the "Ground" layer
7. Press Play and use WASD/Arrows to move, Space to jump

## Requirements

- Unity 2020.3 or later
- Basic understanding of Unity Editor
- Familiarity with C# syntax

## Future Enhancements

Possible improvements for learning:
- Animation system integration
- Double jump mechanic
- Wall jump/wall slide
- Different movement states (running, crouching)
- Sound effects
- Particle effects
