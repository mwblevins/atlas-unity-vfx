# Unity - Beat Detection: The Rhythm of Play

## Background Context

Welcome to the "Beat Detection" project, where you'll dive into the captivating realm of beat detection in gaming using Unity's audio analysis capabilities and event-driven design. Understanding and responding to beats, along with differentiating between various kinds of beats, will elevate your game's immersion and interactivity.

## Technical Description

### 1. Audio Analysis
Implement a basic beat detection algorithm to analyze beats in an audio clip, laying the foundation for beat-driven game design.

### 2. Visual Feedback
Create visual effects that dynamically respond to detected beats, enhancing the visual dimension of your game.

### 3. Event-Driven Gameplay
Design gameplay events triggered by detected beats, enriching the overall gameplay experience.

### 4. Advanced Beat Differentiation
Enhance your beat detection system to differentiate between various beat types and trigger corresponding gameplay events.

### 5. Genre Adjustment
Fine-tune beat detection parameters to suit different music genres, ensuring system versatility.


## Getting Started

1. **Requirements**
   - Unity 2021.3.x or Newer
   - Basic knowledge of C# programming

2. **Installation**
   - Clone or download the starting project.
   - Open the project in Unity.

3. **Project Structure**
   - **Assets/**
     - Contains scripts, prefabs, materials, and other assets.
   - **Scenes/**
     - Includes scenes for gameplay and testing.

## Codebase Overview

### Scripts
1. **AudioPeer.cs**
   - Implements the beat detection algorithm.
   - Analyzes audio clips for beats.
   - Triggers events based on beat detection.

2. **ParamCubeMAt.cs**
   - Manages visual effects triggered by beats for materials changing color on game objects.

3. **GameplayEvents.cs**
   - Defines gameplay events triggered by beats.
   - Controls player actions, level progression, etc.


## How to Use

1. **Audio Analysis**
   - Attach AudioPeer.cs to an audio source.
   - Adjust parameters like threshold and sensitivity for beat detection.

2. **Visual Feedback**
   - Attach ParamCubeMat.cs to game objects for visual feedback.
   - Customize Color and Emissions

3. **Advanced Configuration**
   - Experiment with advanced beat differentiation in AudioPeer.cs.
   - Fine-tune parameters for different music genres.

