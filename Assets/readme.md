# Robotics Project Repository

This repository contains various projects and experiments in robotics, leveraging tools and technologies such as ROS (Robot Operating System), Gazebo, and other relevant frameworks. Below is an overview of the contents and purpose of each project.

## Table of Contents
1. [Overview](#overview)
2. [Projects](#projects)
3. [Setup and Installation](#setup-and-installation)
4. [Usage](#usage)
5. [Troubleshooting](#troubleshooting)
6. [Contributing](#contributing)
7. [License](#license)

## Overview
This repository serves as a centralized location for:
- Robotics simulations and experiments using Gazebo and ROS.
- Development of robot commands and control systems.
- Testing and debugging tools for robotic systems.
- Integration with LLMs and other AI tools for robotic applications.

## Projects

### 1. Robot Command System
**Description**: This project involves creating and testing a system to control a robot through predefined commands. The system integrates user input to dynamically interact with the robot.

### 2. Gazebo Simulations
**Description**: Includes various simulation scenarios for testing robot behavior in virtual environments using Gazebo.

### 3. LLM Integration for Robotics
**Description**: Utilizes large language models to facilitate advanced functionalities such as task assistance, navigation guidance, and conversational interfaces for robots.

## Setup and Installation

### Prerequisites
- Ubuntu (Recommended: 20.04 or later)
- ROS Noetic
- Gazebo
- Python 3.8+

### Installation Steps
1. Clone the repository:
   ```bash
   git clone https://github.com/Tolga-dev/robotics-projects.git
   cd robotics-projects
   ```

2. Install required dependencies:
   ```bash
   sudo apt update
   sudo apt install ros-noetic-desktop-full python3-pip
   pip3 install -r requirements.txt
   ```

3. Set up ROS environment:
   ```bash
   source /opt/ros/noetic/setup.bash
   ```

## Usage

### Running a Gazebo Simulation
1. Launch the Gazebo world:
   ```bash
    export TURTLEBOT3_MODEL=burger
    roslaunch auto_nav turtlebot3_world.launch
   ```
2. Open a new terminal and run the navigation stack:
   ```bash
    export TURTLEBOT3_MODEL=burger
    roslaunch turtlebot3_navigation turtlebot3_navigation.launch map_file:=$HOME/map.yaml
    control + c
   ```
3. Open another terminal and run the auto-navigation script:
   ```bash
    roslaunch auto_nav turtlebot3_auto_nav.launch
   ```
4. Open another terminal and run the goal pose script:
   ```bash
    rosrun auto_nav goal_pose.py
   ```

## Troubleshooting
- **Memory Errors in Gazebo**:
  Refer to [this guide](https://classic.gazebosim.org/tutorials).
- **ROS Node Crashes**:
  Use `rosnode info <node_name>` to debug. 


## Contributing
Contributions are welcome! Please submit issues or pull requests for new features, bug fixes, or improvements.
Main Course that i used : https://www.youtube.com/playlist?list=PLlqdnFs9xNwql5KET7v7zyl393y10qxtw

* Uygar Büyükkahraman (github: "xor-shift"):
* Tolga Konat (github: https://github.com/Tolga-dev)
* Emre Selek 

## License
This project is licensed under the MIT License. See the LICENSE file for details.
