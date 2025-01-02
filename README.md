# Radiation Zone Simulation

This XR Unity project simulates a customizable radiation zone with interactive features, such as toggling visibility, selecting one of three uranium isotopes, adjusting activity levels, and dynamic warnings when entering the zone. The project includes user-friendly controls for seamless interaction.

---

## **Features**
### **Customizable Radiation Sphere**
- Toggle the sphere’s visibility on and off.
- Choose from 3 different uranium isotopes.
- Adjust activity level using a slider or manual input (1–1,000,000).

### **Warning System**
- Displays a warning message whenever the user enters the radiation zone, regardless of the sphere’s visibility.
- Activates a red haze effect when the user enters the radiation zone, but only if the sphere is visible.

### **Settings Menu**
- A menu accessible via a button on the screen to control the sphere’s visibility, isotope selection, activity level, and other settings.
- A checkmark appears on the sphere toggle button to indicate its visibility status.

---

## **Requirements**
- **Unity Editor Version**: 6000.0.32f1
- **Plugins**:
  - Mixed Reality Toolkit (MRTK)
  - TextMesh Pro
  - Input System
  - XR Plugin Management
  - XR Core Utilities

---

## **Setup Instructions**
1. **Clone the Repository**:
   git clone https://github.com/mayacou/radiation-zone-simulation.git

2. **Open the Project**:
   - Launch Unity Hub.
   - Click **Add Project** and locate the project folder.

3. **Run the Project**:
   - Open the scene in Unity and press the **Play** button.

---

## Usage Guide

### 1. Toggle Sphere Visibility
- Press the **Menu Button**.
- Use the “Sphere Toggle” button to show or hide the radiation sphere.
- A checkmark indicates whether the sphere is currently visible.

### 2. Adjust Activity Level
- Drag the slider to adjust the sphere’s activity level.
- Alternatively, manually type the activity value into the input field.

### 3. Interact with the Radiation Zone
- Enter the zone to activate the warning message.
- If the sphere is visible, the red haze effect will activate when inside the zone.

### 4. Access the Settings Menu
- Use the button in the bottom corner to toggle the settings menu.
- Adjust the sphere’s visibility, isotope selection, and activity level from the menu.

---

## Project Architecture

### Scripts Overview
#### **ActivitySliderValueDisplay**
- **Purpose**: Synchronizes the activity slider and manual input field for activity level adjustments.
- **Key Functionality**:
  - Updates the slider value dynamically as the user drags it.
  - Displays the current activity level above the slider.
  - Updates the slider when a value is typed into the input field.

#### **MenuToggle**
- **Purpose**: Toggles the visibility of the settings menu.
- **Key Functionality**:
  - Displays or hides the `SphereSettingsPanel` when the `MenuToggleButton` is clicked.

#### **RadiationZoneCalculator**
- **Purpose**: Performs calculations related to the radiation zone, such as radius calculations.
- **Key Functionality**:
  - Uses isotope type and activity level to calculate the radiation zone radius.

#### **RadiationZoneScaler**
- **Purpose**: Dynamically adjusts the size of the radiation sphere based on the calculated radius.
- **Key Functionality**:
  - Updates the sphere's scale in real time as the activity level changes.

#### **RadiationZoneTrigger**
- **Purpose**: Handles player interactions with the radiation zone.
- **Key Functionality**:
  - Detects when the player enters or exits the radiation zone.
  - Activates the red haze effect and warning text when the player is inside the zone.

#### **SphereToggle**
- **Purpose**: Toggles the visibility of the radiation sphere and manages the visibility checkmark.
- **Key Functionality**:
  - Toggles the sphere's renderer on or off.
  - Updates the UI checkmark to reflect the sphere's visibility.

---

### Hierarchy Overview
#### **SampleScene**
- Root scene containing all major components.

#### **MixedRealityToolkit**
- Handles XR-related inputs and configurations.

#### **MixedRealityPlayspace**
- Houses the main camera and other XR-related GameObjects.

#### **RadiationSphere**
- The main radiation sphere object:
  - Scales dynamically based on activity level.
  - Contains the material for visual representation.

#### **RedHazeCanvas**
- Displays a red overlay on the screen when the player is inside the radiation zone.
- Includes the `RedHazePanel` for the visual effect.

#### **Canvas**
- Main UI container with the following sub-elements:
  - **RadiationAlertText**: Displays a warning message when the player is inside the radiation zone.
  - **SphereSettingsPanel**: Contains UI elements for customizing the sphere:
    - **Select Isotope**: Dropdown to select an isotope.
    - **Set Activity Level**: Label for the activity slider.
    - **ActivitySlider**: Slider to adjust activity levels dynamically.
    - **ActivityValueText**: Displays the current value of the slider.
    - **ActivityInputField**: Allows manual entry of activity values.
    - **ToggleSphereButton**: Button to toggle the sphere's visibility.
    - **Checkmark**: Indicator for the sphere's visibility status.
  - **MenuToggleButton**: Toggles the visibility of the `SphereSettingsPanel`.

---

## Credits
- **Developer**: Maya Couceiro
- Built using Unity **6000.0.32f1**
