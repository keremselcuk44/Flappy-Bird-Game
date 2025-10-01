# Flappy Bird Game - C# Windows Forms

## Project Overview

This project is a C# Windows Forms implementation of the classic Flappy Bird game. Players control a bird using the spacebar to navigate through pipes and score points.

## Features

### 🎮 Game Mechanics
- **Bird Control**: Make the bird flap using spacebar
- **Gravity System**: Bird constantly falls downward
- **Pipes**: Navigate through pipes with random heights
- **Ground Movement**: Continuously moving ground effect

### ⚡ Difficulty System
- **Progressive Difficulty**: Speed and gravity increase with score
- **Levels**:
  - 0-5 score: Normal speed
  - 6-10 score: Medium speed
  - 11-20 score: High speed
  - 20+ score: Very high speed

### 🏆 Scoring System
- **Current Score**: Real-time game score
- **High Score**: All-time best score
- **Auto Save**: High score automatically saved

### 🎯 Game Over & Restart
- **Collision Detection**: Pipe, ground, and screen boundary checks
- **Game Over Panel**: Modern game over screen
- **Quick Restart**: Instant restart with restart button
- **Exit Option**: Quit game with exit button

## Technical Specifications

### 🛠️ Development Environment
- **Platform**: Windows Forms
- **Language**: C#
- **Framework**: .NET Framework

### 🎨 User Interface
- **Responsive Design**: Centered game over panel
- **Modern Buttons**: Hover-effect buttons
- **Color Scheme**:
  - Restart Button: Green tones
  - Exit Button: Red tones
  - Background: Semi-transparent black panel

### ⚙️ Controls
- **Keyboard Input**: Spacebar control
- **Mouse Input**: Button clicks
- **Focus Management**: Keyboard focus handling

## Installation & Running

### Requirements
- Visual Studio (2019 or later)
- .NET Framework 4.5 or higher

### Running Steps
1. Clone or download the project
2. Open in Visual Studio
3. Ensure required NuGet packages are installed
4. Build and run the project

## Game Controls

| Key | Action |
|-----|--------|
| `Space` | Flap bird |
| `Restart Button` | Restart game |
| `Exit Button` | Quit game |

## Game Rules

1. Progress as far as possible without hitting pipes or ground
2. Gain 1 point for each pipe set passed
3. Try to beat your high score
4. Be careful as difficulty increases

## Developer Notes

### Code Structure
- **OOP Principles**: Class-based structure
- **Event Handling**: Timer and keyboard events
- **Collision Detection**: Bounds.IntersectsWith method

### Extensibility
- New pipe sets can be added
- Different difficulty levels can be defined
- Visual improvements can be made

## Class Structure

### Main Form (play.cs)
- **Properties**: Game variables (speed, gravity, score)
- **Methods**: Game logic, collision detection, UI management
- **Events**: Keyboard handlers, timer tick events

### Game Components
- **Pipes**: Multiple pipe sets for continuous gameplay
- **Bird**: Player-controlled character
- **Ground**: Moving background element
- **UI Elements**: Score display, game over panel

## License

This project is developed for educational purposes. The original Flappy Bird game belongs to .Gears company.

## Contributing

1. Fork the project
2. Create a feature branch (`git checkout -b feature/amazingFeature`)
3. Commit your changes (`git commit -m 'Add some amazingFeature'`)
4. Push to the branch (`git push origin feature/amazingFeature`)
5. Open a Pull Request

---

**Note**: This README reflects the current state of the project. Development and updates may continue.