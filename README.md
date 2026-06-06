<div align="center">

# 🍳 Kitchen Chaos

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Made with Unity](https://img.shields.io/badge/Made_with-Unity_6-000000.svg?logo=unity)](https://unity.com/)
[![C#](https://img.shields.io/badge/C%23-239120?logo=c-sharp&logoColor=white)]()

*A frantic, top-down 3D cooking management game built in Unity, featuring clean C# architecture, advanced state machines, and complete Gamepad support.*

</div>

---

## 📸 Gameplay Screenshots

<details open>
<summary><b>Click to collapse/expand screenshots</b></summary>
<br>

<table>
  <tr>
    <td align="center"><b>Main Gameplay & Counters</b></td>
    <td align="center"><b>Recipe Delivery UI</b></td>
  </tr>
  <tr>
    <td><img src="screenshots/screenshot1.png" alt="Main Gameplay" width="100%"></td>
    <td><img src="screenshots/screenshot2.png" alt="Delivery UI" width="100%"></td>
  </tr>
  <tr>
    <td align="center"><b>Stove State Machine (Cooking/Burning)</b></td>
    <td align="center"><b>Cutting Counter Progress</b></td>
  </tr>
  <tr>
    <td><img src="screenshots/screenshot3.png" alt="Stove State Machine" width="100%"></td>
    <td><img src="screenshots/screenshot4.png" alt="Cutting Counter" width="100%"></td>
  </tr>
</table>

<div align="center">
  <b>Dynamic Main Menu & UI</b><br>
  <img src="Screenshots/Screenshot5.png" alt="Main Menu" width="60%">
</div>

</details>

---

## 🚀 About the Project

**Kitchen Chaos** is an Overcooked-inspired 3D game developed to demonstrate production-quality code architecture in Unity. The primary focus of this project is writing highly scalable, decoupled C# code rather than relying on quick-and-dirty prototype scripts. 

The game relies heavily on C# Interfaces, Scriptable Objects, and custom event-driven UI systems to create a seamless cooking experience where players must gather ingredients, chop, cook, plate, and deliver specific recipes before time runs out.

### 💡 Core Mechanics & Architecture
- **Robust Physics Controller:** Custom collision detection using `Physics.CapsuleCast` to handle diagonal wall-sliding perfectly without getting stuck.
- **Event-Driven UI:** UI elements (progress bars, warning flashes, icons) react to C# Events rather than running expensive logic in `Update()` loops.
- **Interface-Based Interactions:** Implementation of `IKitchenObjectParent` to seamlessly transfer ingredients between the Player, Clear Counters, Stoves, and Plates without hard-coupling classes.
- **Data-Driven Recipes:** Utilizing **Scriptable Objects** to define individual ingredients, cutting steps, and complex final recipes.
- **Finite State Machines:** The Stove Counter uses an FSM (Idle -> Frying -> Fried -> Burned) to handle cooking logic, complete with visual/audio warnings.
- **Modern Input System:** Full implementation of Unity's New Input System, supporting seamless transitions between Keyboard/Mouse and Gamepad, including dynamic key-rebinding.

### 💻 Tech Stack & Tools
* **Engine:** Unity (Universal Render Pipeline - URP)
* **Language:** C#
* **Camera:** Cinemachine
* **UI:** TextMeshPro & World Space Canvases
* **Audio:** Custom SoundManager with volume scaling and global event listening.

---

## 🛠️ Installation & Setup

Follow this step-by-step checklist to get the kitchen up and running locally!

<details open>
<summary><b>1️⃣ Open the Project in Unity</b></summary>
<br>

- [ ] Launch **Unity Hub**.
- [ ] Click **Add** and select your cloned `kitchen-chaos` folder.
- [ ] Open the project. 
  > *Note: First-time loading might take a few minutes as Unity automatically imports the Universal Render Pipeline (URP), TextMeshPro, and the New Input System packages.*

</details>

<details open>
<summary><b>2️⃣ Configure the Scenes</b></summary>
<br>

- [ ] Navigate to `Assets/Scenes` in the Project window.
- [ ] Open the **Build Settings** (`File` > `Build Settings` or <kbd>Ctrl</kbd> + <kbd>Shift</kbd> + <kbd>B</kbd>).
- [ ] Drag and drop the scenes into the "Scenes in Build" list in this **exact order**:
  1. `MainMenuScene` (Index 0)
  2. `LoadingScene` (Index 1)
  3. `GameScene` (Index 2)
- [ ] Open `MainMenuScene` and press the ▶️ **Play** button!

</details>

---

## 🎮 Controls & Bindings

The game utilizes Unity's New Input System. Controls can be dynamically rebound in the in-game Options menu, but the default mappings are:

| Action | Keyboard / Mouse | Gamepad (Xbox / PlayStation) |
| :--- | :--- | :--- |
| **Movement** | <kbd>W</kbd> <kbd>A</kbd> <kbd>S</kbd> <kbd>D</kbd> | Left Joystick |
| **Interact** *(Pick up / Drop)* | <kbd>E</kbd> | <kbd>A</kbd> / <kbd>✕</kbd> |
| **Alternate Interact** *(Chop)* | <kbd>F</kbd> | <kbd>X</kbd> / <kbd>□</kbd> |
| **Pause Game** | <kbd>Esc</kbd> | <kbd>Start</kbd> / <kbd>Options</kbd> |

<details>
<summary><b>🔧 Troubleshooting Input Issues?</b></summary>
<br>
If your keyboard isn't responding during testing, ensure that your <b>Active Input Handling</b> in <code>Edit > Project Settings > Player</code> is set to either <b>Input System Package (New)</b> or <b>Both</b>.
</details>

---

## 🤝 Acknowledgements

* **Core Assets & Base Tutorial:** Huge thanks to [Code Monkey](https://www.youtube.com/c/CodeMonkeyUnity) for the incredible free tutorial series and the beautiful 3D assets used in this project.
* **Development Environment:** Built utilizing Unity's Universal Render Pipeline and modern C# architectures.
