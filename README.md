# Blueprint Accelerator: Mixed Reality with HoloLens and Dynamics 365

## Overview
This is an accelerator for connecting and displaying data from Dynamics 365 in a Microsoft HoloLens application. This accelerator code is intended for experimentation and exploration to help shortcut the time developers spend to set up the data pipeline and access. Accelerator code originally developed by Ray Wu (Blueprint Alumni).


## Installation
1) Install Unity Hub

2) Run Unity Hub. 
   Select the latest Unity build from Official Releases.
   Select both UWP components
   Select Visual Studio 2017 Community (or newer) if it's not on your PC
   Download and install

3) Install Visual Studio Tools for Unity: https://docs.microsoft.com/en-us/visualstudio/cross-platform/visual-studio-tools-for-unity?view=vs-2017 
   
4) Run Unity and open project CRM

5) Goto Files -> Build Settings, switch Platform to Universal Windows Platform, Target: Hololens

6) Build and Select "App" as the folder

7) Goto App folder, open CRM solution in Visual Studio
   
   Start without Debugging
   
   The new app will be deployed to Remote Devices (HoloLens)
   
## Demonstration
1) Install the Microsoft HoloLens windows app on your laptop/desktop. This will allow a live stream of what you view in the HoloLens to other people from your laptop/desktop.

2) Connect to Hololens. 

3. Launch the CRM app from the HoloLens

![hololens-dynamics365-1](https://user-images.githubusercontent.com/642655/164390156-b7ae4c6a-e3db-4655-80a9-579d4f1c357e.jpg)

## Validation

1) Add an entry to your Dynamics 365 instance and update.
![image](https://user-images.githubusercontent.com/642655/164393632-cbe3d867-92d6-4a80-9660-5cd527ff2ceb.png)

2) View the change in real-time in the HoloLens CRM application
![image](https://user-images.githubusercontent.com/642655/164394000-090434d5-14fe-43bb-bb90-e8de7940c739.png)


